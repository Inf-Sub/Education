# №1.4[7]. Дано натуральное число. Требуется определить, является ли год с данным номером високосным.
# Если год является високосным, то выведите YES, иначе выведите NO.
# В соответствии с григорианским календарем, год является високосным, если
# его номер кратен 4, но не кратен 100; или если он кратен 400.
# 1. Записать условие для високосного года в одну строку
# 2. Записать условие с использованием двух булевых переменных (по одной для каждой части условия)
# 3. Усложнение [*] Использовать тернарный оператор
# Примеры/Тесты:
#     1900 -> NO
#     2000 -> YES
#     2016 -> YES

print(f'Определить, является ли год високосным.')
# years = (int(input(f'Введите год:')),)
years = 1900,2000,2016

for year in years:
    # print(f'{bool(not year % 400)} or ({bool(not year % 4)} and {bool(year % 100)}) {bool(not year % 4 and year % 100)}')
    # is_leap_year = 'YES' if year % 400 == 0 or year % 4 == 0 and not year % 100 == 0 else 'NO'
    #  is_leap_year = True if bool(not year % 400) or bool(not year % 4 and year % 100) else False
    is_leap_year = 'YES' if bool(not year % 400) or bool(not year % 4 and year % 100) else 'NO'
    print(f'{year} -> {is_leap_year}')

    condition1 = year % 400 == 0
    condition2 = year % 4 == 0 and not year % 100 == 0
    print(f"v2: {year} -> {'YES' if condition1 or condition2 else 'NO'}")

  