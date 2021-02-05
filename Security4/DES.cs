using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Security4
{
    public class DES
    {
        byte[] _key;
        public byte[] Key { 
            get {
                return _key;
            }
        }
        public void SetKey(string k)
        {
            if (k.Length != 10) return;
           _key = k.Select(x => x == '1' ? Convert.ToByte(1) : Convert.ToByte(0)).ToArray();
            CalculateKeys();
        }
        byte[] K1 { get; set; }
        byte[] K2 { get; set; }

        byte[] Content { get; set; }

        public string Encrypt(string text)
        {
            var binaryText = ToBinary(text, Encoding.UTF8);
            string res = "";
            byte[] temp;
            for(int i = 0; i < binaryText.Length; i+=8)
            {
                temp = EncryptBlock(binaryText.Skip(i).Take(8).ToArray());
                res += string.Join("", temp);
            }
            return res;
        }
        public string Decrypt(string text)
        {
            var binaryText = text.Select(x => x == '1' ? Convert.ToByte(1) : Convert.ToByte(0)).ToArray();
            string res = "";
            byte[] temp;
            for (int i = 0; i < binaryText.Length; i += 8)
            {
                temp = DecryptBlock(binaryText.Skip(i).Take(8).ToArray());
                res += string.Join("", temp);
            }
            return res;
        }

        public byte[] ToBinary(string text, Encoding encoding)
        {
            var str = string.Join("", encoding.GetBytes(text).Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
            List<byte> list = new List<byte>();
            foreach(var c in str)
            {
                list.Add(c == '1' ? Convert.ToByte(1) : Convert.ToByte(0));
            }
            return list.ToArray();
        }

        void CalculateKeys()
        {
            if (_key.Length != 10)
                return;
            var res = P10(_key);
            var l = res.Take(5).ToArray();
            var r = res.Skip(5).Take(5).ToArray();
            l = LeftSwap(l);
            r = LeftSwap(r);
            var c = Concat(l, r);
            K1 = P8(c);
            l = RightSwap(l);
            r = RightSwap(r);
            c = Concat(l, r);
            K2 = P8(c);

        }
        byte[] EncryptBlock(byte[] e)
        {
            if (e.Length != 8) return null;
            var res = IP(e);
            res = Fk(res, K1);
            res = SW(res);
            res = Fk(res, K2);
            res = IPinv(res);
            return res;
        }
        byte[] DecryptBlock(byte[] e)
        {
            if (e.Length != 8) return null;
            var res = IP(e);
            res = Fk(res,K2);
            res = SW(res);
            res = Fk(res, K1);
            res = IPinv(res);
            return res;
        }


        byte[] P10(byte[] e)
        {
            if (e.Length != 10)
                return null;
            byte[] arr = { e[2], e[4], e[1], e[6], e[3], e[9], e[0], e[9], e[7], e[5] };
            return arr;
        }

        byte[] P8(byte[] e)
        {
            if (e.Length != 10)
                return null;
            byte[] arr = { e[5], e[2], e[6], e[3], e[7], e[4], e[9], e[8] };
            return arr;
        }

        byte[] P4(byte[] e)
        {
            if (e.Length != 4)
                return null;
            byte[] arr = { e[1], e[3], e[2], e[0] };
            return arr;
        }

        byte[] LeftSwap(byte[] e) 
        {
            if (e.Length != 5)
                return null;

           return e.Skip(1).Take(4).Concat(e.Take(1)).ToArray();
        }
        byte[] RightSwap(byte[] e)
        {
            if (e.Length != 5)
                return null;

            return e.Skip(3).Take(2).Concat(e.Take(3)).ToArray();
        }
        byte[] IP(byte[] e)
        {
            if (e.Length != 8)
                return null;
            byte[] arr = { e[1], e[5], e[2], e[0], e[3], e[7], e[4], e[6] };
            return arr;
        }

        byte[] IPinv(byte[] e)
        {
            if (e.Length != 8)
                return null;
            byte[] arr = { e[3], e[0], e[2], e[4], e[6], e[1], e[7], e[5] };
            return arr;
        }

        byte[] Stretch(byte[] e)
        {
            if (e.Length != 4)
                return null;
            byte[] arr = { e[3], e[0], e[1], e[2], e[1], e[2], e[3], e[0] };
            return arr;
        }

        byte[] XOR(byte[] l, byte[] r)
        {
            if (l.Length != r.Length)
                return null;
            List<byte> arr = new List<byte>();
            for (int i = 0; i < l.Length; i++)
            {
                var t = l[i] + r[i] == 1 ? Convert.ToByte(1) : Convert.ToByte(0);
                arr.Add(t);
            }

            return arr.ToArray();
        }

        byte[] S0(byte[] e)
        {
            if (e.Length != 4)
                return null;
            int row = e[0] * 2 + e[3] * 1;
            int col = e[1] * 2 + e[2] * 1;
            byte[,] s = { 
                            {1,0,3,2},
                            {2,2,1,0},
                            {0,2,1,3},
                            {3,1,3,1},
                        };
            byte selected = s[row, col];

            byte[] arr = { Convert.ToByte(selected / 2), Convert.ToByte(selected % 2 ) };
            return arr;
        }

        byte[] S1(byte[] e)
        {
            if (e.Length != 4)
                return null;
            int row = e[0] * 2 + e[3] * 1;
            int col = e[1] * 2 + e[2] * 1;
            byte[,] s = {
                            {1,1,2,3},
                            {2,0,1,3},
                            {3,0,1,0},
                            {2,1,0,3},
                        };
            byte selected = s[row, col];

            byte[] arr = { Convert.ToByte(selected / 2), Convert.ToByte(selected % 2) };
            return arr;
        }

        byte[] Concat(byte[] l, byte[] r) 
        {
            if (l.Length != r.Length)
                return null;
            return l.Concat(r).ToArray();
        }

        byte[] SW(byte[] e)
        {
            if (e.Length % 2 != 0)
                return null;

            var res = e.Skip(4).Take(4).Concat( e.Take(4) );
            return res.ToArray();
        }

        byte[] Fk(byte[] e, byte[] k)
        {
            if (e.Length != 8)
                return null;
            if (k.Length != 8)
                return null;

            var l = e.Take(4).ToArray();
            var r = e.Skip(4).Take(4).ToArray();
            var x = XOR(l, F(r, k));
            return Concat(x, r);
        }

        byte[] F(byte[] r, byte[] k) 
        {
            if (r.Length != 4)
                return null;

            var res = Stretch(r);
            res = XOR(res, k);
            var s0 = S0(res.Take(4).ToArray());
            var s1 = S1(res.Skip(4).Take(4).ToArray());
            res = Concat(s0, s1);
            res = P4(res);
            return res;

        }
    }
}
