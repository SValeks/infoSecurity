
namespace lab3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cipherAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cipherKey = new System.Windows.Forms.TextBox();
            this.cipherMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.decipherAnswer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.decipherMessage = new System.Windows.Forms.TextBox();
            this.decipherKey = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.закодироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.раскодироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cipherAnswer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cipherKey);
            this.groupBox1.Controls.Add(this.cipherMessage);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Закодированное сообщение:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Введите сообщение, которое надо закодировать:";
            // 
            // cipherAnswer
            // 
            this.cipherAnswer.Location = new System.Drawing.Point(43, 347);
            this.cipherAnswer.Name = "cipherAnswer";
            this.cipherAnswer.Size = new System.Drawing.Size(277, 23);
            this.cipherAnswer.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Введите 16-ти символьный ключ:";
            // 
            // cipherKey
            // 
            this.cipherKey.Location = new System.Drawing.Point(43, 173);
            this.cipherKey.MaxLength = 16;
            this.cipherKey.Name = "cipherKey";
            this.cipherKey.Size = new System.Drawing.Size(277, 23);
            this.cipherKey.TabIndex = 16;
            // 
            // cipherMessage
            // 
            this.cipherMessage.Location = new System.Drawing.Point(43, 89);
            this.cipherMessage.Name = "cipherMessage";
            this.cipherMessage.Size = new System.Drawing.Size(277, 23);
            this.cipherMessage.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.decipherAnswer);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.decipherMessage);
            this.groupBox2.Controls.Add(this.decipherKey);
            this.groupBox2.Location = new System.Drawing.Point(435, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 411);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Исходное сообщение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Закодированное сообщение:";
            // 
            // decipherAnswer
            // 
            this.decipherAnswer.Location = new System.Drawing.Point(63, 347);
            this.decipherAnswer.Name = "decipherAnswer";
            this.decipherAnswer.Size = new System.Drawing.Size(267, 23);
            this.decipherAnswer.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Введите 16-ти символьный ключ:";
            // 
            // decipherMessage
            // 
            this.decipherMessage.Location = new System.Drawing.Point(63, 89);
            this.decipherMessage.Name = "decipherMessage";
            this.decipherMessage.Size = new System.Drawing.Size(267, 23);
            this.decipherMessage.TabIndex = 15;
            // 
            // decipherKey
            // 
            this.decipherKey.Location = new System.Drawing.Point(63, 173);
            this.decipherKey.MaxLength = 16;
            this.decipherKey.Name = "decipherKey";
            this.decipherKey.Size = new System.Drawing.Size(267, 23);
            this.decipherKey.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закодироватьToolStripMenuItem,
            this.раскодироватьToolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // закодироватьToolStripMenuItem
            // 
            this.закодироватьToolStripMenuItem.Name = "закодироватьToolStripMenuItem";
            this.закодироватьToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.закодироватьToolStripMenuItem.Text = "Закодировать";
            this.закодироватьToolStripMenuItem.Click += new System.EventHandler(this.закодироватьToolStripMenuItem_Click);
            // 
            // раскодироватьToolStripMenuItem1
            // 
            this.раскодироватьToolStripMenuItem1.Name = "раскодироватьToolStripMenuItem1";
            this.раскодироватьToolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.раскодироватьToolStripMenuItem1.Text = "Раскодировать";
            this.раскодироватьToolStripMenuItem1.Click += new System.EventHandler(this.раскодироватьToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cipherAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cipherKey;
        private System.Windows.Forms.TextBox cipherMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decipherAnswer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decipherMessage;
        private System.Windows.Forms.TextBox decipherKey;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem закодироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem раскодироватьToolStripMenuItem1;
    }
}

