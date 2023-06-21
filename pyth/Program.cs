import random
import string


population = string.ascii_letters+ string.digits+ string.punctuation 
weights_pun= 7 
weights_digits=8 
weights_ascii=9
weights= [weights_ascii] *len(string.ascii_letters) + [weights_digits] * len(string.digits) +[weights_pun] * len(string.punctuation)
password = ''.join(random.choices(population, weights = weights, k = 6))
print(password)

from collections import Counter
counted = Counter(password)

upper = sum(c.isupper() for c in password)


    if len(password) >= min_length and n_upper >= min_upper and n_lower >= min_lower
and n_digits >= min_digits and n_special >= min_special:
print("The password is strong.")
else:
print("The password is weak.")


password = pass50
n_upper = n_lower = n_digits = n_special = 0
for char in password:
10
if char in string.ascii_uppercase:
n_upper += 1
elif char in string.ascii_lowercase:
n_lower += 1
elif char in string.digits:
n_digits += 1
elif char in string.punctuation:
n_special += 1
print('The password is:', password)
print('n_upper', n_upper)
print('n_lower', n_lower)
print('n_digits', n_digits)
print('n_special', n_special)
strength = len(password) + n_upper + n_lower + (2 * n_digits) + (3 * n_special)
print('The password strength is:', strength)




def password_strength(password):
n_upper = n_lower = n_digits = n_special = 0
for char in password:
if char in string.ascii_uppercase:
n_upper += 1
elif char in string.ascii_lowercase:
n_lower += 1
elif char in string.digits:
n_digits += 1
elif char in string.punctuation:
n_special += 1
# Calculate strength based on character types and length
strength = len(password) + n_upper + n_lower + (2 * n_digits) + (3 *
,→n_special)
# Categorize password strength
if strength < 20:
11
return 'Weak'
elif strength< 40:
return 'Moderate'
else:
return 'Strong'
strength = password_strength(password)
print(f'Password strength: {strength}')



def caesar_cipher_encrypt(plaintext, shift):
encrypted_text = ""
for char in plaintext:
if char.isalpha():
shift_amount = shift % 26
if char.islower():
encrypted_text += chr((ord(char) - ord('a') + shift_amount) % 26
+ ord('a'))
else:
encrypted_text += chr((ord(char) - ord('A') + shift_amount) % 26
+ ord('A'))
else:
encrypted_text += char
return encrypted_text



def caesar_cipher_decrypt(ciphertext, shift):
decrypted_text = ""
for char in ciphertext:
if char.isalpha():
shift_amount = shift % 26
if char.islower():
decrypted_text += chr((ord(char) - ord('a') - shift_amount) % 26
+ ord('a'))
else:
decrypted_text += chr((ord(char) - ord('A') - shift_amount) % 26
+ ord('A'))



result = subprocess.run(['ipconfig'],capture_output = True, text = True)
t = result.stdout
print(result.stdout)


result = subprocess.run(['SYSTEMINFO'],capture_output = True, text = True)
print(result.stdout)


result = subprocess.run(['netstat', '-ano'], capture_output = True, text = True)
print(result.stdout)



 with subprocess.Popen(['ping', 'www.facebook.com'], stdout = subprocess.PIPE,␣
text = True) as proc:
for line in proc.stdout:
print(line.strip())



import uuid
mac_address = uuid.getnode()
print(mac_address)



import socket
# Get the IP address of a remote host
remote_host = 'www.facebook.com'
ip_address = socket.gethostbyname(remote_host)
print(f'The IP address of {remote_host} is {ip_address}')


info = socket.getaddrinfo('google.com', 80)
print(info)


port = socket.getservbyname("https")
print(port)

os.mkdir('Ahmad')
directories = os.listdir('.')
print(directories)



