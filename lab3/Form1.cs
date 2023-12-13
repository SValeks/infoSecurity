using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void закодироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void раскодироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        // Таблица замены
        private static byte[,] Table = {
            {0x4, 0xA, 0x9, 0x2, 0xD, 0x8, 0x0, 0xE, 0x6, 0xB, 0x1, 0xC, 0x7, 0xF, 0x5, 0x3},
            {0xE, 0xB, 0x4, 0xC, 0x6, 0xD, 0xF, 0xA, 0x2, 0x3, 0x8, 0x1, 0x0, 0x7, 0x5, 0x9},
            {0x5, 0x8, 0x1, 0xD, 0xA, 0x3, 0x4, 0x2, 0xE, 0xF, 0xC, 0x7, 0x6, 0x0, 0x9, 0xB},
            {0x7, 0xD, 0xA, 0x1, 0x0, 0x8, 0x9, 0xF, 0xE, 0x4, 0x6, 0xC, 0xB, 0x2, 0x5, 0x3},
            {0x6, 0xC, 0x7, 0x1, 0x5, 0xF, 0xD, 0x8, 0x4, 0xA, 0x9, 0xE, 0x0, 0x3, 0xB, 0x2},
            {0x4, 0xB, 0xA, 0x0, 0x7, 0x2, 0x1, 0xD, 0x3, 0x6, 0x8, 0x5, 0x9, 0xC, 0xF, 0xE},
            {0xD, 0xB, 0x4, 0x1, 0x3, 0xF, 0x5, 0x9, 0x0, 0xA, 0xE, 0x7, 0x6, 0x8, 0x2, 0xC},
            {0x1, 0xF, 0xD, 0x0, 0x5, 0x7, 0xA, 0x4, 0x9, 0x2, 0x3, 0xE, 0x6, 0xB, 0x8, 0xC}
        };


        // Функция строит из строки длиной 16 символов ключ длиной 8 символов (по 32 бита)
        static List<UInt32> DivideKeyInto8Pieces(string key16Pieces)
        {
            List<UInt32> key8Pieces = new List<UInt32>();
            for (int keyIndex = 0; keyIndex < key16Pieces.Length; keyIndex += 2)
            {
                // Переводим в двоичную систему исчисления и добавляем нулей слева, чтобы
                // длина была 16 символов (16 бит)
                string binarLeftPart = Convert.ToString(key16Pieces[keyIndex], 2).PadLeft(16, '0');
                string binarRightPart = Convert.ToString(key16Pieces[keyIndex + 1], 2).PadLeft(16, '0');
                // Склеиваем биты левой и правой частей и конвертируем в число
                key8Pieces.Add(Convert.ToUInt32(binarLeftPart + binarRightPart, 2));
            }
            // Если пользователь ввел меньше 16 символов, то докидываем нулей
            while (key8Pieces.Count != 8)
                key8Pieces.Add(0);
            key8Pieces.Reverse();
            return key8Pieces;
        }

        // Составляем из строки блок в 64 бита (массив из двух блоков по 32)
        static List<UInt32> CombineTextTo64BitsBlock(string input)
        {
            string binarLeftPart1, binarLeftPart2, binarRightPart1, binarRightPart2;
            // Каждый символ переводим в биты (16 бит)
            if (input.Length > 0)
                binarLeftPart1 = Convert.ToString(input[0], 2).PadLeft(16, '0');
            else
                binarLeftPart1 = new string('0', 16);
            if (input.Length > 1)
                binarLeftPart2 = Convert.ToString(input[1], 2).PadLeft(16, '0');
            else
                binarLeftPart2 = new string('0', 16);
            if (input.Length > 2)
                binarRightPart1 = Convert.ToString(input[2], 2).PadLeft(16, '0');
            else
                binarRightPart1 = new string('0', 16);
            if (input.Length > 3)
                binarRightPart2 = Convert.ToString(input[3], 2).PadLeft(16, '0');
            else
                binarRightPart2 = new string('0', 16);
            // Соединяем биты первых двух букв и последних двух 
            string binarLeftPart = binarLeftPart1 + binarLeftPart2;
            string binarRightPart = binarRightPart1 + binarRightPart2;

            // Возвращаем 2 блока по 32 бита
            return new List<UInt32> {
                Convert.ToUInt32(binarLeftPart, 2),
                Convert.ToUInt32(binarRightPart, 2)
            };
        }

        // Функция делит двоичный код числа на несколько частей по pieceSize знаков 
        static List<string> DivideBinaryIntoBlocks(string binaryNumber, int pieceSize)
        {
            List<string> blocks = new List<string>();
            for (int i = 0; i < binaryNumber.Length; i += pieceSize)
                blocks.Add(binaryNumber.Substring(i, pieceSize));
            return blocks;
        }

        // Функция принимает на вход массив из побитовых разложений чисел
        // Конвертирует каждое разложение в число и возвращает массив из получившихся чисел
        static List<UInt32> ConvertBlocksToNumbers(List<string> bitBlocks)
        {
            List<UInt32> result = new List<UInt32>();
            foreach (string block in bitBlocks)
                result.Add(Convert.ToUInt32(block, 2));
            return result;
        }

        // Функция заменяет биты числа 32 битного числа number в соответствии с таблицей Table
        private static void ChangeBitsWithTable(ref UInt32 num32bit)
        {
            // Преобразование числа в двоичное представление
            string binaryNumber = Convert.ToString(num32bit, 2).PadLeft(32, '0');
            // Разбиение двоичного представления на блоки по 4 бита
            List<string> bitBlocks = DivideBinaryIntoBlocks(binaryNumber, 4);
            // Конвертируем блоки в числа
            List<UInt32> numbersArray = ConvertBlocksToNumbers(bitBlocks);
            numbersArray.Reverse();
            List<string> newBitBlocks = new List<string>();
            // Заменяем биты в соответствии с таблицей 
            for (int i = 0; i < numbersArray.Count; i++)
                newBitBlocks.Add(Convert.ToString(Table[i, numbersArray[i]], 2).PadLeft(4, '0'));
            newBitBlocks.Reverse();
            // Новые биты переводим обратно в числа
            num32bit = Convert.ToUInt32(string.Join("", newBitBlocks), 2);

        }

        // Кодирование
        private string Cipher(string message, string key)
        {
            string answer = "";
            List<UInt32> key8Pieces = DivideKeyInto8Pieces(key);
            char[] messageArray = message.ToCharArray();
            while (messageArray.Length > 0)
            {
                // Получаем новые 4 символа из сообщения
                string pieceOfMessage = string.Join("", messageArray.Take(4));
                messageArray = messageArray.Skip(4).ToArray();
                int i = 1;
                // Склеиваем пары символов и получаем 2 32 битовых числа
                List<UInt32> blocks = CombineTextTo64BitsBlock(pieceOfMessage);
                // Работаем с левой и правой частью
                UInt32 l = blocks[0];
                UInt32 r = blocks[1];
                UInt32 v;
                while (i <= 32)
                {
                    v = r;
                    int j = i < 25 ? (i - 1) % 8 : (32 - i) % 8;
                    r = (r + key8Pieces[j]) % UInt32.MaxValue;
                    ChangeBitsWithTable(ref r);
                    r = (r << 11) | (r >> (32 - 11));
                    r = r ^ l;
                    l = v;
                    i++;
                }
                // Соединяем биты правой и левой частей
                string block64Bit = Convert.ToString(r, 2).PadLeft(32, '0') + Convert.ToString(l, 2).PadLeft(32, '0');
                // Разбиваем большой блок на 4 маленьких по 16 символов
                List<string> bitBlocksString = DivideBinaryIntoBlocks(block64Bit, 16);
                foreach (string bitBlock in bitBlocksString)
                    answer += Convert.ToChar(Convert.ToUInt16(bitBlock, 2)) + "";
            }
            return answer;
        }


        // Раскодирование
        private string Decipher(string message, string key)
        {
            string answer = "";
            List<UInt32> key8Pieces = DivideKeyInto8Pieces(key);
            char[] messageArray = message.ToCharArray();
            while (messageArray.Length > 0)
            {
                string pieceOfMessage = string.Join("", messageArray.Take(4));
                messageArray = messageArray.Skip(4).ToArray();
                int i = 1;
                // Склеиваем пары символов и получаем 2 32 битовых числа
                List<UInt32> blocks = CombineTextTo64BitsBlock(pieceOfMessage);
                // Работаем с левой и правой частью
                UInt32 l = blocks[0];
                UInt32 r = blocks[1];
                UInt32 v;
                while (i <= 32)
                {
                    // Делаем тоже самое, но j берем другой
                    v = r;
                    int j = i <= 8 ? (i - 1) % 8 : (32 - i) % 8;
                    r = (r + key8Pieces[j]) % UInt32.MaxValue;
                    ChangeBitsWithTable(ref r);
                    r = (r << 11) | (r >> (32 - 11));
                    r = r ^ l;
                    l = v;
                    i++;
                }
                // Соединяем биты правой и левой частей
                string block64Bit = Convert.ToString(r, 2).PadLeft(32, '0') + Convert.ToString(l, 2).PadLeft(32, '0');
                // Разбиваем большой блок на 4 маленьких по 16 символов
                List<string> bitBlocksString = DivideBinaryIntoBlocks(block64Bit, 16);
                foreach (var bitBlock in bitBlocksString)
                    answer += Convert.ToChar(Convert.ToUInt16(bitBlock, 2)) + "";
            }
            return answer;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string message = cipherMessage.Text;
            string key = cipherKey.Text;
            cipherAnswer.Text = Cipher(message, key);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = decipherMessage.Text;
            string key = decipherKey.Text;
            decipherAnswer.Text = Decipher(message, key);
        }
    }
}
