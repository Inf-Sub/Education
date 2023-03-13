# #### 1.3[6]. Вы пользуетесь общественным транспортом? Вероятно, вы расплачивались за проезд и получали билет с номером.
# Счастливым билетом называют такой билет с шестизначным номером, где сумма первых трех цифр равна сумме последних трех. Т.е. 
# билет с номером 385916 – счастливый, т.к. 3+8+5=9+1+6. Вам требуется написать программу, которая проверяет счастливость билета.

# 	Примеры/Тесты:
# 	385916 >>> yes
# 	123456 >>> no

# **Усложнение.** Вывод результат на экран сделайте одной строкой(только один print), для этого используйте тернарный оператор

flag = True
ticket_len = 6
ticket_half_len = ticket_len // 2
left_sum = 0
right_sum = 0

while flag:
    ticket = int(input('Введите номер билета: '))

    if 10 ** (ticket_len - 1) - 1 < ticket < 10 ** ticket_len:
        flag = False
    else:
        print('Это неправильный номер билета! Попробуйте еще раз...')

ticket_number_left = ticket // 10 ** ticket_half_len
ticket_number_rigth = ticket % 10 ** ticket_half_len

for i in range(ticket_half_len):
    left_residue = ticket_number_left % 10
    ticket_number_left = ticket_number_left // 10
    left_sum += left_residue

    rigth_residue = ticket_number_rigth % 10
    ticket_number_rigth = ticket_number_rigth // 10
    right_sum += rigth_residue

print(f"{'yes' if left_sum == right_sum else 'no'}")