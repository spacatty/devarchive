import random

# MODE 1 FUNC START
def mode_1():
    print('---------- M 0 D 3 | O N 3 ----------')
    print('ENT3R TH3 S1Z3:')
    createArrayDynamicly(int(input()))
    print('---------- M 0 D 3 | 0 N 3 ----------')

        # MODE INCLUDES
def createArrayDynamicly(sizeOfArrayLocal):
    localArray = [int] * sizeOfArrayLocal
    print('////////// S 3 T T 1 N G S //////////\nFR0M')
    randomFrom = int(input())
    print('T0:')
    randomTo = int(input())
    print('////////// S 3 T T 1 N G S //////////')
    for i in range(sizeOfArrayLocal):
        localArray[i] = random.randint(randomFrom, randomTo)
    print('G0TCHA: ', localArray)
    print('TA-DAM: ', sorted(localArray))

        # MODE INCLUDES
             
# MODE 1 FUNC START


# MODE 2 FUNC START
def mode_2():
    print('---------- M 0 D 3 | T W 0 ----------')
    print('> JUST A MILLIS3C0ND........')
    mode2_array = [int]*10
    for i in range(10):
        mode2_array[i] = (random.randint(0, 2))
    print('L00K: ', mode2_array)
    print('L00K N0W: ', sorted(mode2_array))
    print('---------- M 0 D 3 | T W 0 ----------')
# MODE 2 FUNC END

# UI

print('---------- H 3 L L 0 ----------')
print('1 - DYNAMIC GENERATION\n2 - STATIC, MEANS ONLY 0-2 WITH 10 RANGE')
print('---------- H 3 L L 0 ----------')
operationgMode = int(input())

if operationgMode == 1:
    print('> SW1TCH3D T0 M0D3 1')
    mode_1()
elif operationgMode == 2:
    print('> SW1TCH3D T0 M0D3 2')
    mode_2()
else:
    print('WHY U D1D 1T?')