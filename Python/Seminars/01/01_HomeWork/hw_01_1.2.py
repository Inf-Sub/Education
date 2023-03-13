# 1.2[4]. Петя, Катя и Сережа делают из бумаги журавликов. Вместе они сделали S журавликов. 
# Сколько журавликов сделал каждый ребенок, если известно, что Петя и Сережа сделали одинаковое 
# количество журавликов, а Катя сделала в два раза больше журавликов, чем Петя и Сережа вместе?
# Примеры/Тесты:
# 6 >>>  1  4  1
# 24 >>> 4  16  4
# 60 >>> 10  40  10

input_sum = int(input('Введите число журавликов: '))
# input_sum = 60
child = 3
progress = 2
user_petr = 0
user_ekaterina = 0
user_sergey = 0

user_ekaterina = input_sum // child * progress
user_petr = user_sergey = input_sum // child // progress
print(f'{user_petr} {user_ekaterina} {user_sergey}')


