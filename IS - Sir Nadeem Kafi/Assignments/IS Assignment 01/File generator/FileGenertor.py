import os
desired_size = 50 * 1024 * 1024  # 10MB

random_data = os.urandom(desired_size)

temp_file = r"C:\Users\Bilal\Desktop\IS Assignment 01\Files for Encryption\Exe Files\10MB.exe"
with open(temp_file, "wb") as file:
    file.write(random_data)

print(f"Generated executable file: {temp_file}")
