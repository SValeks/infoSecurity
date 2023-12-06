
namespace infformationSecurityLab1
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
            System.Windows.Forms.Button button3;
            this.label8 = new System.Windows.Forms.Label();
            this.shifrHorizontal = new System.Windows.Forms.NumericUpDown();
            this.shifrVertical = new System.Windows.Forms.NumericUpDown();
            this.shifrResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.shifrText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.режимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифровкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифровкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.взломToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupboxShyfr = new System.Windows.Forms.GroupBox();
            this.groupboxRasshifr = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rasshifrHorizontal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rasshifrVertical = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rasshifrResult = new System.Windows.Forms.TextBox();
            this.rasshifrText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupboxVzlom = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vzlomResult = new System.Windows.Forms.TextBox();
            this.vzlomText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shifrHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shifrVertical)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupboxShyfr.SuspendLayout();
            this.groupboxRasshifr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rasshifrHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasshifrVertical)).BeginInit();
            this.groupboxVzlom.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(180, 203);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(120, 23);
            button3.TabIndex = 21;
            button3.Text = "Взломать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Закодированное сообщение:";
            // 
            // shifrHorizontal
            // 
            this.shifrHorizontal.Location = new System.Drawing.Point(190, 227);
            this.shifrHorizontal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shifrHorizontal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shifrHorizontal.Name = "shifrHorizontal";
            this.shifrHorizontal.Size = new System.Drawing.Size(103, 23);
            this.shifrHorizontal.TabIndex = 18;
            this.shifrHorizontal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // shifrVertical
            // 
            this.shifrVertical.Location = new System.Drawing.Point(190, 146);
            this.shifrVertical.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shifrVertical.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shifrVertical.Name = "shifrVertical";
            this.shifrVertical.Size = new System.Drawing.Size(103, 23);
            this.shifrVertical.TabIndex = 17;
            this.shifrVertical.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // shifrResult
            // 
            this.shifrResult.Location = new System.Drawing.Point(108, 366);
            this.shifrResult.Name = "shifrResult";
            this.shifrResult.Size = new System.Drawing.Size(270, 23);
            this.shifrResult.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shifrText
            // 
            this.shifrText.Location = new System.Drawing.Point(140, 58);
            this.shifrText.Name = "shifrText";
            this.shifrText.Size = new System.Drawing.Size(217, 23);
            this.shifrText.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Количество букв по горизонтали:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Количество букв по вертикали:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите сообщения для шифрования:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режимToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // режимToolStripMenuItem
            // 
            this.режимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расшифровкаToolStripMenuItem,
            this.расшифровкаToolStripMenuItem1,
            this.взломToolStripMenuItem});
            this.режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            this.режимToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.режимToolStripMenuItem.Text = "Режим";
            // 
            // расшифровкаToolStripMenuItem
            // 
            this.расшифровкаToolStripMenuItem.Name = "расшифровкаToolStripMenuItem";
            this.расшифровкаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.расшифровкаToolStripMenuItem.Text = "Шифрование";
            this.расшифровкаToolStripMenuItem.Click += new System.EventHandler(this.расшифровкаToolStripMenuItem_Click);
            // 
            // расшифровкаToolStripMenuItem1
            // 
            this.расшифровкаToolStripMenuItem1.Name = "расшифровкаToolStripMenuItem1";
            this.расшифровкаToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.расшифровкаToolStripMenuItem1.Text = "Расшифровка";
            this.расшифровкаToolStripMenuItem1.Click += new System.EventHandler(this.расшифровкаToolStripMenuItem1_Click);
            // 
            // взломToolStripMenuItem
            // 
            this.взломToolStripMenuItem.Name = "взломToolStripMenuItem";
            this.взломToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.взломToolStripMenuItem.Text = "Взлом";
            this.взломToolStripMenuItem.Click += new System.EventHandler(this.взломToolStripMenuItem_Click);
            // 
            // groupboxShyfr
            // 
            this.groupboxShyfr.Controls.Add(this.shifrResult);
            this.groupboxShyfr.Controls.Add(this.label8);
            this.groupboxShyfr.Controls.Add(this.label1);
            this.groupboxShyfr.Controls.Add(this.shifrHorizontal);
            this.groupboxShyfr.Controls.Add(this.button1);
            this.groupboxShyfr.Controls.Add(this.shifrText);
            this.groupboxShyfr.Controls.Add(this.shifrVertical);
            this.groupboxShyfr.Controls.Add(this.label2);
            this.groupboxShyfr.Controls.Add(this.label3);
            this.groupboxShyfr.Location = new System.Drawing.Point(26, 38);
            this.groupboxShyfr.Name = "groupboxShyfr";
            this.groupboxShyfr.Size = new System.Drawing.Size(521, 411);
            this.groupboxShyfr.TabIndex = 21;
            this.groupboxShyfr.TabStop = false;
            // 
            // groupboxRasshifr
            // 
            this.groupboxRasshifr.Controls.Add(this.label9);
            this.groupboxRasshifr.Controls.Add(this.label6);
            this.groupboxRasshifr.Controls.Add(this.rasshifrHorizontal);
            this.groupboxRasshifr.Controls.Add(this.label5);
            this.groupboxRasshifr.Controls.Add(this.rasshifrVertical);
            this.groupboxRasshifr.Controls.Add(this.label4);
            this.groupboxRasshifr.Controls.Add(this.rasshifrResult);
            this.groupboxRasshifr.Controls.Add(this.rasshifrText);
            this.groupboxRasshifr.Controls.Add(this.button2);
            this.groupboxRasshifr.Location = new System.Drawing.Point(26, 38);
            this.groupboxRasshifr.Name = "groupboxRasshifr";
            this.groupboxRasshifr.Size = new System.Drawing.Size(521, 411);
            this.groupboxRasshifr.TabIndex = 22;
            this.groupboxRasshifr.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Исходное сообщение:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Зашифрованное сообщение:";
            // 
            // rasshifrHorizontal
            // 
            this.rasshifrHorizontal.Location = new System.Drawing.Point(251, 227);
            this.rasshifrHorizontal.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.rasshifrHorizontal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rasshifrHorizontal.Name = "rasshifrHorizontal";
            this.rasshifrHorizontal.Size = new System.Drawing.Size(120, 23);
            this.rasshifrHorizontal.TabIndex = 30;
            this.rasshifrHorizontal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Количество букв по вертикали:";
            // 
            // rasshifrVertical
            // 
            this.rasshifrVertical.Location = new System.Drawing.Point(251, 136);
            this.rasshifrVertical.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.rasshifrVertical.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rasshifrVertical.Name = "rasshifrVertical";
            this.rasshifrVertical.Size = new System.Drawing.Size(120, 23);
            this.rasshifrVertical.TabIndex = 29;
            this.rasshifrVertical.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Количество букв по горизонтали:";
            // 
            // rasshifrResult
            // 
            this.rasshifrResult.Location = new System.Drawing.Point(193, 366);
            this.rasshifrResult.Name = "rasshifrResult";
            this.rasshifrResult.Size = new System.Drawing.Size(245, 23);
            this.rasshifrResult.TabIndex = 28;
            // 
            // rasshifrText
            // 
            this.rasshifrText.Location = new System.Drawing.Point(226, 58);
            this.rasshifrText.Name = "rasshifrText";
            this.rasshifrText.Size = new System.Drawing.Size(170, 23);
            this.rasshifrText.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupboxVzlom
            // 
            this.groupboxVzlom.Controls.Add(this.label10);
            this.groupboxVzlom.Controls.Add(this.vzlomResult);
            this.groupboxVzlom.Controls.Add(button3);
            this.groupboxVzlom.Controls.Add(this.vzlomText);
            this.groupboxVzlom.Controls.Add(this.label7);
            this.groupboxVzlom.Location = new System.Drawing.Point(26, 38);
            this.groupboxVzlom.Name = "groupboxVzlom";
            this.groupboxVzlom.Size = new System.Drawing.Size(521, 411);
            this.groupboxVzlom.TabIndex = 23;
            this.groupboxVzlom.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Исходное сообщение:";
            // 
            // vzlomResult
            // 
            this.vzlomResult.Location = new System.Drawing.Point(150, 291);
            this.vzlomResult.Name = "vzlomResult";
            this.vzlomResult.Size = new System.Drawing.Size(168, 23);
            this.vzlomResult.TabIndex = 22;
            // 
            // vzlomText
            // 
            this.vzlomText.Location = new System.Drawing.Point(150, 132);
            this.vzlomText.Name = "vzlomText";
            this.vzlomText.Size = new System.Drawing.Size(168, 23);
            this.vzlomText.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Сообщение, которое необходимо взломать";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 555);
            this.Controls.Add(this.groupboxVzlom);
            this.Controls.Add(this.groupboxRasshifr);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupboxShyfr);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №1";
            ((System.ComponentModel.ISupportInitialize)(this.shifrHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shifrVertical)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupboxShyfr.ResumeLayout(false);
            this.groupboxShyfr.PerformLayout();
            this.groupboxRasshifr.ResumeLayout(false);
            this.groupboxRasshifr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rasshifrHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rasshifrVertical)).EndInit();
            this.groupboxVzlom.ResumeLayout(false);
            this.groupboxVzlom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown shifrHorizontal;
        private System.Windows.Forms.NumericUpDown shifrVertical;
        private System.Windows.Forms.TextBox shifrResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox shifrText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расшифровкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расшифровкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem взломToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupboxShyfr;
        private System.Windows.Forms.GroupBox groupboxRasshifr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown rasshifrHorizontal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown rasshifrVertical;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rasshifrResult;
        private System.Windows.Forms.TextBox rasshifrText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupboxVzlom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox vzlomResult;
        private System.Windows.Forms.TextBox vzlomText;
        private System.Windows.Forms.Label label7;
    }
}

