namespace Security4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.encryptButton = new System.Windows.Forms.Button();
            this.encryptTextRight = new System.Windows.Forms.RichTextBox();
            this.encryptTextLeft = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.decryptTextRight = new System.Windows.Forms.RichTextBox();
            this.decryptTextLeft = new System.Windows.Forms.RichTextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ключ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(15, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 394);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.encryptButton);
            this.tabPage1.Controls.Add(this.encryptTextRight);
            this.tabPage1.Controls.Add(this.encryptTextLeft);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(765, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифрування";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(6, 329);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(150, 30);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "Шифрувати";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // encryptTextRight
            // 
            this.encryptTextRight.Location = new System.Drawing.Point(389, 6);
            this.encryptTextRight.Name = "encryptTextRight";
            this.encryptTextRight.Size = new System.Drawing.Size(370, 302);
            this.encryptTextRight.TabIndex = 1;
            this.encryptTextRight.Text = "";
            // 
            // encryptTextLeft
            // 
            this.encryptTextLeft.Location = new System.Drawing.Point(6, 6);
            this.encryptTextLeft.Name = "encryptTextLeft";
            this.encryptTextLeft.Size = new System.Drawing.Size(370, 302);
            this.encryptTextLeft.TabIndex = 0;
            this.encryptTextLeft.Text = "Hello";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.importButton);
            this.tabPage2.Controls.Add(this.decryptTextRight);
            this.tabPage2.Controls.Add(this.decryptTextLeft);
            this.tabPage2.Controls.Add(this.decryptButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(765, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Розшифрування";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // decryptTextRight
            // 
            this.decryptTextRight.Location = new System.Drawing.Point(389, 6);
            this.decryptTextRight.Name = "decryptTextRight";
            this.decryptTextRight.Size = new System.Drawing.Size(370, 302);
            this.decryptTextRight.TabIndex = 2;
            this.decryptTextRight.Text = "";
            // 
            // decryptTextLeft
            // 
            this.decryptTextLeft.Location = new System.Drawing.Point(6, 6);
            this.decryptTextLeft.Name = "decryptTextLeft";
            this.decryptTextLeft.Size = new System.Drawing.Size(370, 302);
            this.decryptTextLeft.TabIndex = 1;
            this.decryptTextLeft.Text = "";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(6, 329);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(150, 30);
            this.decryptButton.TabIndex = 0;
            this.decryptButton.Text = "Розшифрувати";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(60, 8);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(66, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.Text = "0101101010";
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(163, 329);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(222, 30);
            this.importButton.TabIndex = 3;
            this.importButton.Text = "Імпортувати з 1ої вкладки";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Шифрування S-DES";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.RichTextBox encryptTextRight;
        private System.Windows.Forms.RichTextBox encryptTextLeft;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox decryptTextRight;
        private System.Windows.Forms.RichTextBox decryptTextLeft;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button importButton;
    }
}

