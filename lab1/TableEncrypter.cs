using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace infformationSecurityLab1
{
    class TableEncrypter
    {
        // Шифрование текста
        public string Encryption(string originalText, int numRows, int numColumns)
        {
            // Инициализируем переменную для хранения зашифрованного текста
            string encryptedText = "";
            for (int column = 0; column < numColumns; column++)
            {
                for (int row = 0; row < numRows; row++)
                {
                    // Вычисляем индекс текущего символа в оригинальном тексте
                    int index = column + row * numColumns;
                    // Проверяем, находится ли индекс в пределах длины текста
                    if (index < originalText.Length)
                    {
                        // Добавляем текущий символ в зашифрованный текст
                        encryptedText += originalText[index];
                    }
                    else
                    {
                        // Если выходит за пределы текста, добавляем пробел
                        encryptedText += " ";
                    }
                }
            }
            return encryptedText;
        }

        // Расшифровка текста
        public string Decryption(string encryptedText, int numRows, int numColumns)
        {
            string decryptedText = "";
            for (int row = 0; row < numRows; row++)
            {
                for (int column = 0; column < numColumns; column++)
                {
                    // Вычисляем индекс текущего символа в зашифрованном тексте
                    int index = row + column * numRows;
                    // Проверяем, находится ли индекс в пределах длины текста
                    if (index < encryptedText.Length)
                    {
                        // Добавляем текущий символ в расшифрованный текст
                        decryptedText += encryptedText[index];
                    }
                }
            }
            // Удаляем пробелы из начала и конца расшифрованного текста
            return decryptedText.Trim();
        }

        // Функция возвращает массив из слов текста, которые есть в русском словаре
        private List<string> GetListOfWordsFromRussianDictionary(string inputText)
        {
            // Инициализируем список для хранения найденных слов из словаря
            List<string> foundWords = new List<string>();
            // Паттерн, чтобы оставить только буквы русского языка в тексте
            string russianLettersPattern = "[^а-яА-Я ]";
            // Все остальные буквы и символы заменяем на пустую строку
            List<string> cleanTextList = new List<string>(Regex.Replace(inputText, russianLettersPattern, "").Split(" "));
            // Регистрация провайдера кодировок для поддержки дополнительных кодировок
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            // Меняем кодировку (чтобы файл читался адекватно)
            var dictionaryReader = new System.IO.StreamReader("ru_dictionary.txt", encoding: Encoding.GetEncoding(1251));
            // Пробегаемся по файлу словаря
            while (dictionaryReader.Peek() >= 0)
            {
                // Читаем новую строку из словаря
                string dictionaryWord = dictionaryReader.ReadLine().Trim();
                // Ищем в переданном тексте итерируемое слово
                List<string> matchingWords = cleanTextList.FindAll(e => e.ToLower() == dictionaryWord.ToLower());
                // Добавляем найденные слова в список
                foundWords.AddRange(matchingWords);
            }
            // Возвращаем список найденных слов
            return foundWords;
        }


        // Функция принимает на вход список слов и возвращает суммарное количество букв в этих словах
        private int CalculateTotalLettersCount(List<string> listOfWords)
        {
            // счетчик букв
            int totalLettersCount = 0;
            // Проходим по каждому слову в списке
            foreach (var word in listOfWords)
            {
                // Увеличиваем счетчик на длину текущего слова
                totalLettersCount += word.Length;
            }
            // Возвращаем общее количество букв в словах
            return totalLettersCount;
        }


        // Взлом шифра
        public string HackTextCipher(string encryptedText)
        {
            // Взломанное сообщение
            string decryptedMessage = "";
            // Проверенные и добавленные варианты расшифровки
            Dictionary<string, int> decryptionVariants = new Dictionary<string, int>();
            // Паттерн, чтобы оставить только буквы русского языка в тексте
            string russianLettersPattern = "[^а-яА-Я]";
            int maxWordCount = 0;
            // Перебор возможных ключей для дешифровки
            for (int i = 0; i < encryptedText.Length; i++)
            {
                for (int j = 0; j < encryptedText.Length; j++)
                {
                    if (encryptedText.Length <= i * j)
                    {
                        // Новый вариант расшифровки
                        string currentDecryptionAttempt = Decryption(encryptedText, i, j);
                        // Проверяем, чтобы такого варианта еще не было в словаре
                        if (!decryptionVariants.ContainsKey(currentDecryptionAttempt))
                        {
                            // Все слова, найденные в словаре
                            List<string> wordsList = GetListOfWordsFromRussianDictionary(currentDecryptionAttempt);
                            // Убираем все символы, кроме русских 
                            string cleanText = Regex.Replace(currentDecryptionAttempt, russianLettersPattern, "");
                            int lettersCount = CalculateTotalLettersCount(wordsList);
                            // Если количество русских букв совпало, то возвращаем ответ
                            if (cleanText.Length == lettersCount)
                                return currentDecryptionAttempt;

                            // Добавляем вариант расшифровки в словарь
                            decryptionVariants.Add(currentDecryptionAttempt, lettersCount);
                        }
                    }
                }
            }

            // Отбираем вариант с максимальным совпадением букв
            foreach (KeyValuePair<string, int> dict in decryptionVariants)
            {
                if (dict.Value > maxWordCount)
                {
                    decryptedMessage = dict.Key;
                    maxWordCount = dict.Value;
                }
            }
            // Обрезаем пробелы
            return decryptedMessage.Trim();
        }

    }
}
