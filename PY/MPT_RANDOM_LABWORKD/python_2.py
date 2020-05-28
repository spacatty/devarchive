import random
import itertools

def createArraysAndFindNumbers(arraysLength):
    firstArray = [None] * arraysLength
    secondArray = [None] * arraysLength
    for i in range(arraysLength):
        firstArray[i] = random.randint(0, 10)
        secondArray[i] = random.randint(0, 10)
    print('------------ S T 3 P | O N 3 ------------\n-> Созданы массивы:\n', firstArray, '\n', secondArray, '\n------------ S T 3 P | O N 3 ------------\n\n')
    firstCombos = list(itertools.combinations(firstArray, 2))
    secondCombos = list(itertools.combinations(secondArray, 3))
    sumsOfFirstCombos = list(map(sum, firstCombos))
    sumsOfSecondCombos = list(map(sum, secondCombos))
    print('------------ S T 3 P | T W 0 ------------\n-> SUM OF 2 EL OF 1 A:\n', sumsOfFirstCombos, '\n------------ S T 3 P | T W 0 ------------\n\n')
    print('------------ S T 3 P | T H R 3 3 ------------\n-> SUM OF 3 EL OF 2 A:\n', sumsOfSecondCombos, '\n------------ S T 3 P | T H R 3 3 ------------\n\n')
    print('------------ A N S W 3 R ------------\n->Совпадения: ', set(sumsOfFirstCombos).intersection(sumsOfSecondCombos), '\n------------ A N S E 3 R ------------\n\n')

print('Введите размерность массивов:')
createArraysAndFindNumbers(int(input()))

