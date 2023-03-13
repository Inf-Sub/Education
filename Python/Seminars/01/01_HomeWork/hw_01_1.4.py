# #### 1.4[8]. Требуется определить, можно ли от шоколадки размером n × m долек отломить k долек, если разрешается 
# сделать один разлом по прямой между дольками (то есть разломить шоколадку на два прямоугольника).
# 	Примеры/Тесты:
# 	3 2 4 -> yes
# 	3 2 1 -> no

count_piece_width, count_piece_height, count_piece_break = input(f'Введите через пробел длину, ширину шоколада и количество отломленных долек: ').split()
print(f'{"yes" if int(count_piece_break) % int(count_piece_width) == 0 or int(count_piece_break) % int(count_piece_height) == 0 else "no"}')