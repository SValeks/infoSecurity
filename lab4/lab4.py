import tkinter as tk
from tkinter import messagebox
import gmpy2

# Число простое?
def is_prime(number):
    # Преобразование числа в объект gmpy2
    mpz_number = gmpy2.mpz(number)
    # Проверка, является ли число простым
    return gmpy2.is_prime(mpz_number)


# Шифрование сообщения
def encrypt_message():
    try:
        p = gmpy2.mpz(p_entry.get())
        q = gmpy2.mpz(q_entry.get())
        # Проверка данных на условия
        if p == q or not (is_prime(p)) or not(is_prime(q)):
            return messagebox.showerror("Ошибка", "p == q или p и q не простые числа")
        n = p * q
        phi = (p - 1) * (q - 1)
        e = gmpy2.mpz(e_entry.get())
        if gmpy2.gcd(e, phi) != 1:
            return messagebox.showerror("Ошибка", "НОД(e, phi(n)) не равен единице")
        d = int(d_entry_encrypt.get())
        if (e*d)%phi != 1:
            return messagebox.showerror("Ошибка", "e*d должно равняться 1%phi(n)")
        message = message_entry_encrypt.get()
        # Переводим буквы в числа и делаем (m^e) mod n
        encrypted_numbers = [(ord(char) ** e) % n for char in message]
        # Перевод обратно в буквы
        encrypted_chars = [chr(number) for number in encrypted_numbers]
        message_entry_encrypt_result.delete(0, tk.END)
        # Вывод зашифрованного сообщения
        message_entry_encrypt_result.insert(0, "".join(map(str, encrypted_chars)))

    except ValueError:
        messagebox.showerror("Ошибка", "Пожалуйста, введите корректные числовые значения.")

# Расшифровка сообщения
def decrypt_message():
    try:
        d = gmpy2.mpz(d_entry_decrypt.get())
        n = gmpy2.mpz(n_entry_decrypt.get())
        encrypted_message = message_entry_decrypt.get()
        # Переводим буквы в числа и делаем (s^d) mod n
        decrypted_numbers = [(ord(char) ** d) % n for char in encrypted_message]
        # Переводим обратно в буквы
        decrypted_chars = [chr(number) for number in decrypted_numbers]
        # Вывод расшифрованного сообщения
        message_entry_decrypt_result.delete(0, tk.END)
        message_entry_decrypt_result.insert(0, "".join(map(str, decrypted_chars)))

    except ValueError:
        messagebox.showerror("Ошибка", "Пожалуйста, введите корректные числовые значения.")


def on_input_p_or_q(ev):
    try:
        p = gmpy2.mpz(p_entry.get())
        q = gmpy2.mpz(q_entry.get())
        n = p * q
        phi = (p - 1) * (q - 1)
        n_output.config(text=n)
        phi_output.config(text = phi)
    except ValueError:
        pass


def copy_text():
    # Копирование текста из Entry в буфер обмена
    root.clipboard_clear()
    root.clipboard_append(message_entry_encrypt_result.get())
    root.update()



# Главное окно
root = tk.Tk()
root.title("RSA")

# Левая часть формы
left_frame = tk.Frame(root)
left_frame.pack(side=tk.LEFT, padx=10, pady=10)

p_label = tk.Label(left_frame, text="p:")
p_label.grid(row=0, column=0, sticky="E")
p_entry = tk.Entry(left_frame)
p_entry.grid(row=0, column=1)
p_entry.bind("<FocusOut>", on_input_p_or_q)

q_label = tk.Label(left_frame, text="q:")
q_label.grid(row=1, column=0, sticky="E")
q_entry = tk.Entry(left_frame)
q_entry.grid(row=1, column=1)
q_entry.bind("<FocusOut>", on_input_p_or_q)

n_label = tk.Label(left_frame, text="n:")
n_label.grid(row=2, column=0, sticky="E")
n_output = tk.Label(left_frame, text="")
n_output.grid(row=2, column=1)

phi_label = tk.Label(left_frame, text="Фи:")
phi_label.grid(row=3, column=0, sticky="E")
phi_output = tk.Label(left_frame, text="")
phi_output.grid(row=3, column=1)

e_label = tk.Label(left_frame, text="e:")
e_label.grid(row=4, column=0, sticky="E")
e_entry = tk.Entry(left_frame)
e_entry.grid(row=4, column=1)

d_encrypt_label = tk.Label(left_frame, text="d:")
d_encrypt_label.grid(row=5, column=0, sticky="E")
d_entry_encrypt = tk.Entry(left_frame)
d_entry_encrypt.grid(row=5, column=1)

message_label_encrypt = tk.Label(left_frame, text="Сообщение:")
message_label_encrypt.grid(row=6, column=0, sticky="E")
message_entry_encrypt = tk.Entry(left_frame)
message_entry_encrypt.grid(row=6, column=1)

encrypt_button = tk.Button(left_frame, text="Зашифровать", command=encrypt_message)
encrypt_button.grid(row=7, column=0, columnspan=2, pady=10)

message_label_encrypt_result = tk.Label(left_frame, text="Зашифрованное сообщение:")
message_label_encrypt_result.grid(row=8, column=0, sticky="E")
message_entry_encrypt_result = tk.Entry(left_frame)
message_entry_encrypt_result.grid(row=8, column=1)

decrypt_button = tk.Button(left_frame, text="Копировать", command=copy_text)
decrypt_button.grid(row=9, column=1, columnspan=2, pady=10)

# Правая часть формы
right_frame = tk.Frame(root)
right_frame.pack(side=tk.RIGHT, padx=10, pady=10)

d_decrypt_label = tk.Label(right_frame, text="d:")
d_decrypt_label.grid(row=0, column=0, sticky="E")
d_entry_decrypt = tk.Entry(right_frame)
d_entry_decrypt.grid(row=0, column=1)

n_label_decrypt = tk.Label(right_frame, text="n:")
n_label_decrypt.grid(row=1, column=0, sticky="E")
n_entry_decrypt = tk.Entry(right_frame)
n_entry_decrypt.grid(row=1, column=1)

message_label_decrypt = tk.Label(right_frame, text="Зашифрованное сообщение:")
message_label_decrypt.grid(row=2, column=0, sticky="E")
message_entry_decrypt = tk.Entry(right_frame)
message_entry_decrypt.grid(row=2, column=1)

decrypt_button = tk.Button(right_frame, text="Расшифровать", command=decrypt_message)
decrypt_button.grid(row=4, column=0, columnspan=2, pady=10)

message_label_decrypt_result = tk.Label(right_frame, text="Расшифрованное сообщение:")
message_label_decrypt_result.grid(row=5, column=0, sticky="E")
message_entry_decrypt_result = tk.Entry(right_frame)
message_entry_decrypt_result.grid(row=6, column=1)


root.mainloop()
