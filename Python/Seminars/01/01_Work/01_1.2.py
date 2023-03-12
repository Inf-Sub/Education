# №1.2[3]. В некоторой школе решили набрать три новых математических класса и оборудовать кабинеты для них новыми партами.
# За каждой партой может сидеть два учащихся. Известно количество учащихся в каждом из трех классов.
# Выведите наименьшее число парт, которое нужно приобрести для них.
# Примеры/Тесты:
#     20 21 22(ввод чисел НЕ в одну строку)  -> Общее кол-во парт будет 32
#     21 21 21(ввод чисел НЕ в одну строку)  -> Общее кол-во парт будет 33


classdesks_places = 2
count_class_rooms = 3
sum_of_classdesks = 0

for class_room in range(count_class_rooms):
    count_of_students = int(input(f'Введите количество учащихся в {class_room + 1} классе:'))

    # if count_of_students % classdesks_places:
    #     sum_of_classdesks += count_of_students // classdesks_places + 1
    # else:
    #     sum_of_classdesks += count_of_students // classdesks_places

    sum_of_classdesks += count_of_students // classdesks_places
    sum_of_classdesks += 1 if count_of_students % classdesks_places else 0

print(f'Общее кол-во парт будет {sum_of_classdesks}')
