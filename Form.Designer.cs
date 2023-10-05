namespace ChatEncryptionTools
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(11, 392);
            button1.Name = "button1";
            button1.Size = new Size(341, 43);
            button1.TabIndex = 0;
            button1.Text = "Generate New Key Pair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 39);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(341, 139);
            textBox1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(342, 27);
            label2.TabIndex = 16;
            label2.Text = "Public Key (Non-Standard Format)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 181);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(350, 27);
            label1.TabIndex = 17;
            label1.Text = "Private Key (Non-Standard Format)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 211);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(341, 139);
            textBox2.TabIndex = 18;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 441);
            button2.Name = "button2";
            button2.Size = new Size(342, 43);
            button2.TabIndex = 19;
            button2.Text = "Copy Public Key (Clipboard)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 353);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 27);
            label3.TabIndex = 20;
            label3.Text = "Length";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "0";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1024", "2048", "4096", "8192" });
            comboBox1.Location = new Point(93, 355);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(259, 29);
            comboBox1.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(376, 39);
            textBox3.Margin = new Padding(2, 3, 2, 3);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(461, 139);
            textBox3.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(376, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(278, 27);
            label4.TabIndex = 23;
            label4.Text = "Another Person's Public Key";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(376, 181);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(158, 27);
            label5.TabIndex = 24;
            label5.Text = "Encrypted Data";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(376, 211);
            textBox4.Margin = new Padding(2, 3, 2, 3);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(461, 91);
            textBox4.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(376, 305);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(185, 27);
            label6.TabIndex = 26;
            label6.Text = "Unencrypted Data";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(376, 335);
            textBox5.Margin = new Padding(2, 3, 2, 3);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(461, 100);
            textBox5.TabIndex = 27;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(376, 441);
            button3.Name = "button3";
            button3.Size = new Size(227, 43);
            button3.TabIndex = 28;
            button3.Text = "Encryption";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(609, 441);
            button4.Name = "button4";
            button4.Size = new Size(227, 43);
            button4.TabIndex = 29;
            button4.Text = "Decryption";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 496);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form";
            Text = "Chat Encryption Tools";
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Button button3;
        private Button button4;
    }
}