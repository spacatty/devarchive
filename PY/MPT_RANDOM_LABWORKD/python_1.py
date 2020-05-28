import random

evensA = 0
oddsA = 0

def evens(arrayToProcess):
    eLocalSum = 0
    for i in range(0, len(arrayToProcess), 2):
        if arrayToProcess[i] > 0:
            eLocalSum += arrayToProcess[i]
            print('Добавляем к сумме ', [i], ' элемент, равный', arrayToProcess[i], '. Сумма = ', eLocalSum)
        else:
            print('Число под номером ', i, ', равное ', arrayToProcess[i], ' отлетает.')
    global evensA
    evensA = eLocalSum
    print('-----------------------\nn = ', eLocalSum, '\n-----------------------')
    
def odds(arrayToProcess):
    comp = 1
    for i in range(1, len(arrayToProcess), 2):
        if arrayToProcess[i] < 0:
            comp *= arrayToProcess[i]
            print('Умножаем ', [i], ' элемент, равный', arrayToProcess[i], '. Произведение = ', comp)
        else:
            print('Число под номером ', i, ', равное ', arrayToProcess[i], ' отлетает.')
    global oddsA
    oddsA = comp
    print('-----------------------\nm = ', comp, '\n-----------------------')

def createArrayAndFindNM(rangeCount):
    n = [None] * rangeCount
    for i in range(rangeCount):
        n[i] = random.randint(rangeCount*100*-1, rangeCount*100)
    print('Создан массив: ', n, '\nСейчас будем искать n и m...')
    evens(n)
    odds(n)



print('Введите размерность массива: ')
createArrayAndFindNM(int(input()))
print('>>>>>>>>>>>>>>> | A N S W 3 R | <<<<<<<<<<<<<<<\nn = ', evensA, '\nm = ', oddsA, '\n>>>>>>>>>>>>>>> | A N S W 3 R | <<<<<<<<<<<<<<<')




