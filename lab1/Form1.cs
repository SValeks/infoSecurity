using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infformationSecurityLab1
{
    public partial class Form1 : Form
    {
        TableEncrypter tableEncrypter = new TableEncrypter();
        public Form1()
        {
            InitializeComponent();
            groupboxShyfr.Visible = true;
            groupboxRasshifr.Visible = false;
            groupboxVzlom.Visible = false;
        }

        // Переключение режима на шифрование
        private void расшифровкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupboxShyfr.Visible = true;
            groupboxRasshifr.Visible = false;
            groupboxVzlom.Visible = false;
        }
        // Переключение режима на расшифрование
        private void расшифровкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            groupboxRasshifr.Visible = true;
            groupboxShyfr.Visible = false;
            groupboxVzlom.Visible = false;
        }

        // Переключение режима на взлом
        private void взломToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupboxVzlom.Visible = true;
            groupboxRasshifr.Visible = false;
            groupboxShyfr.Visible = false;
        }

        // Расшифровать
        private void button2_Click(object sender, EventArgs e)
        {
            string text = rasshifrText.Text;
            int numRows = (int)rasshifrVertical.Value;
            int numColumns = (int)rasshifrHorizontal.Value;
            if (text.Length > numRows * numColumns) {
                MessageBox.Show("Ошибка! Перепроверьте длину текста и введенные значения");
            }
            else {
                string newText = tableEncrypter.Decryption(text, numRows, numColumns);
                rasshifrResult.Text = newText;
            }
        }
        // Зашифровать
        private void button1_Click(object sender, EventArgs e)
        {
            string text = shifrText.Text;
            int numRows = (int)shifrVertical.Value;
            int numColumns = (int)shifrHorizontal.Value;
            if (text.Length > numRows * numColumns) {
                MessageBox.Show("Ошибка! Перепроверьте длину текста и введенные значения");
            }
            else {
                string newText = tableEncrypter.Encryption(text, numRows, numColumns);
                shifrResult.Text = newText;
            }
        }


        // Взломать
        private void button3_Click(object sender, EventArgs e)
        {
            string text = vzlomText.Text;
            string newText = tableEncrypter.HackTextCipher(text);
            vzlomResult.Text = newText;
        }
    }
}
