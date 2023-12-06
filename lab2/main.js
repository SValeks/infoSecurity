const ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ";

// Функция построения нового алфавита на основе сдвига
function getNewAlphabet(letterIndex) {
    let newAlphabet = "";
    for (let i = 0; i < ALPHABET.length; i++) {
        // Строим алфавит от letterIndex
        if (i + letterIndex < ALPHABET.length) {
            newAlphabet += ALPHABET[i + letterIndex];
        } else {
            // Строим алфавит до letterIndex
            newAlphabet += ALPHABET[i - (ALPHABET.length - letterIndex)];
        }
    }
    return newAlphabet;
}

// Шифрование текста методом Вижинера
function encryptText(text, secretWord) {
    let encryptedText = "";
    let secretWordIterator = 0;

    for (let i = 0; i < text.length; i++) {
        // Если символ это русская буква
        if (text[i].match(/[А-Яа-я]/)) {
            const letterPosition = ALPHABET.indexOf(text[i].toUpperCase());
            const newAlphabet = getNewAlphabet(ALPHABET.indexOf(secretWord[secretWordIterator].toUpperCase()));

            // Возвращаем кейс
            if (text[i] === text[i].toUpperCase()) {
                encryptedText += newAlphabet[letterPosition];
            } else {
                encryptedText += newAlphabet[letterPosition].toLowerCase();
            }
            secretWordIterator++;
            // Обнуляем итератор, если вышли за предел ключа
            if (secretWordIterator >= secretWord.length) {
                secretWordIterator = 0;
            }
        } else {
            encryptedText += text[i];
        }
    }

    return encryptedText;
}

// Расшифровка текста
function decryptText(encryptedText, secretWord) {
    let decryptedText = "";
    let secretWordIterator = 0;

    for (let i = 0; i < encryptedText.length; i++) {
        if (encryptedText[i].match(/[А-Яа-я]/)) {
            // Строим новый алфавит на основе буквы ключа
            const newAlphabet = getNewAlphabet(ALPHABET.indexOf(secretWord[secretWordIterator].toUpperCase()));
            // Получаем позицию символа в алфавите
            const letterPosition = newAlphabet.indexOf(encryptedText[i].toUpperCase());
            if (encryptedText[i] === encryptedText[i].toUpperCase()) {
                decryptedText += ALPHABET[letterPosition];
            } else {
                decryptedText += ALPHABET[letterPosition].toLowerCase();
            }

            secretWordIterator++;
            if (secretWordIterator >= secretWord.length) {
                secretWordIterator = 0;
            }
        } else {
            decryptedText += encryptedText[i];
        }
    }
    return decryptedText;
}

function encryptBtnListener() {
    const message = document.getElementById("encryptMessage").value;
    const key = document.getElementById("encryptKey").value;
    const encryptedMessage = encryptText(message, key)
    document.getElementById("encryptionResult").innerText = "Результат шифрования: " + encryptedMessage;
}

function decryptBtnListener() {
    // Реализация вашей логики расшифровки
    const message = document.getElementById("decryptMessage").value;
    const key = document.getElementById("decryptKey").value;
    const decryptedMessage = decryptText(message, key)
    document.getElementById("decryptionResult").innerText = "Результат расшифровки: " + decryptedMessage;
}

// Ставим слушатели на кнопки
document.getElementById("encryptBtn").addEventListener("click", () => encryptBtnListener())
document.getElementById("decryptBtn").addEventListener("click", () => decryptBtnListener())
