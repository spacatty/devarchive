def opredelenie(x: float, y: float):
    sent1: float = (x*x*x) + (0.5 * x) + 5.6
    sent2: float = (x*x) + x
    if y == sent1:
        print(y, "=", sent1, " точка принадлежит выражению x^3 + 0.5x + 5.6.")
    elif y == sent2:
        print(y, "≄", sent2, "точка принадлежит выражению x^2 + x.")
    else:
        print('Точка не принадлежит ни одному из выражений.')


print('/////////////// с л а д к о д у н у л /////////////// ')
print('Введите абциссу точки (х): ')
Ax = float(input())
print('Введите ординату точки (у): ')
Ay = float(input())
opredelenie(Ax, Ay)
