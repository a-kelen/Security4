using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            des = new DES();
            des.SetKey("1001010010");

        }
        DES des;

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string freeText = encryptTextLeft.Text;
            encryptTextRight.Text = des.Encrypt(freeText);
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !(e.KeyChar == '1' || e.KeyChar == '0'))
            {
                
                e.Handled = true;
            }
            des.SetKey(maskedTextBox1.Text);
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            decryptTextLeft.Text = encryptTextRight.Text;
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string encryptedText = decryptTextLeft.Text;
            string decrypted = des.Decrypt(encryptedText);
            BitArray bits = new BitArray(decrypted.Length);
            for(int i = 0; i < decrypted.Length; i++)
            {
                bits.Set(i, decrypted[i] == '1' ? true : false);
            }
            decryptTextRight.Text = Encoding.UTF8.GetString(ToByteArray(bits));
            if (decryptTextRight.Text == string.Join("", des.ToBinary(encryptTextLeft.Text, Encoding.UTF8)))
                MessageBox.Show("Yaa");
        }
        public byte[] ToByteArray(BitArray bits)
        {
            int numBytes = bits.Count / 8;
            if (bits.Count % 8 != 0) numBytes++;

            byte[] bytes = new byte[numBytes];
            int byteIndex = 0, bitIndex = 0;

            for (int i = 0; i < bits.Count; i++)
            {
                if (bits[i])
                    bytes[byteIndex] |= (byte)(1 << (7 - bitIndex));

                bitIndex++;
                if (bitIndex == 8)
                {
                    bitIndex = 0;
                    byteIndex++;
                }
            }

            return bytes;
        }
    }
}
