import random

# GAME CONSTANTS
LIGHTERS_COUNT = 37
PLAYER_MAX = 5

# PLAYERS CONSTANTS
firstPlayerScore = 0
secondPlayerScore = 0
firstROW = 0
secondROW = 0
firstPlayerDecision = 0
secondPlayerDecision = 0


# TURN COUNTER
firstPlayersTurnBool = False
secondPlayersTurnBool = False

# GAME COUNTERS
LIGHTERS_LEFT = LIGHTERS_COUNT

# GAME STATUS
GAME = True

# GAME DECISION
STARTING_PLAYER = random.randint(1,2)

#  ----------- SYSTEM FUNCTIONS
def checkTurn():
    global firstPlayersTurnBool, secondPlayersTurnBool
    if firstPlayersTurnBool:
        firstPlayersTurn()
    else:
        if secondPlayersTurnBool:
            secondPlayersTurn()
#  ----------- SYSTEM FUNCTIONS

def firstPlayersTurn():
    # IMPORTING GLOBAL VARS
    global firstPlayerScore, secondPlayerScore, firstPlayerDecision, secondPlayerDecision, secondPlayersTurnBool, firstPlayersTurnBool, LIGHTERS_LEFT, GAME, firstROW, secondROW
    # FIRST SETTINGS
    if firstPlayerScore == 0 and secondPlayerScore == 0:
        firstPlayerDecision = random.randint(1, 5)
        firstROW = firstPlayerDecision
        firstPlayerScore += firstPlayerDecision
        print('~PLAYER 1: GETS ', firstPlayerDecision, ' lighters, ', LIGHTERS_LEFT, ' left')
        firstPlayerDecision = 0
        secondPlayersTurnBool = True
        firstPlayersTurnBool = False
        return
    # ITTERATIONS    
    firstPlayerDecision = 6 - secondROW
    firstROW = firstPlayerDecision
    LIGHTERS_LEFT -= firstPlayerDecision
    firstPlayerScore += firstPlayerDecision
    print('~PLAYER 1: GETS ', firstPlayerDecision, ' lighters, ', LIGHTERS_LEFT, ' left')
    if LIGHTERS_LEFT == 1:
        GAME = False
        print('-------------------- V I C T O R Y --------------------\nPLAYER 1 WON\nGUFFY PLAYER 2 LEFT WITH 1 LIGHTER\n-------------------- V I C T O R Y --------------------')
        return   
    secondROW = 0
    firstPlayerDecision = 0
    secondPlayersTurnBool = True
    firstPlayersTurnBool = False
    
    
def secondPlayersTurn():
    global firstPlayerScore, secondPlayerScore, firstPlayerDecision, secondPlayerDecision, secondPlayersTurnBool, firstPlayersTurnBool, LIGHTERS_LEFT, GAME, firstROW, secondROW

    if firstPlayerScore == 0 and secondPlayerScore == 0:
        secondPlayerDecision = random.randint(1, 5)
        secondROW = secondPlayerDecision
        secondPlayerScore += secondPlayerDecision
        print('~PLAYER 2: GETS ', secondPlayerDecision, ' lighters, ', LIGHTERS_LEFT, ' left')
        secondPlayerDecision = 0
        firstPlayersTurnBool = True
        secondPlayersTurnBool = False
        return
    secondPlayerDecision = 6 - firstROW
    secondROW = secondPlayerDecision
    LIGHTERS_LEFT -= secondPlayerDecision
    secondPlayerScore += secondPlayerDecision
    print('~PLAYER 2: GETS ', secondPlayerDecision, ' lighters, ', LIGHTERS_LEFT, ' left')
    if LIGHTERS_LEFT == 1:
        GAME = False
        print('-------------------- V I C T O R Y --------------------\nPLAYER 2 WON\nGUFFY PLAYER 1 LEFT WITH 1 LIGHTER\n-------------------- V I C T O R Y --------------------')
        return 
    firstROW = 0
    secondPlayerDecision = 0
    firstPlayersTurnBool = True
    secondPlayersTurnBool = False
        
      
if STARTING_PLAYER == 1:
    firstPlayersTurnBool = True
    while GAME:
        checkTurn()
else:
    if STARTING_PLAYER == 2:
        secondPlayersTurnBool = True
        while GAME:
            checkTurn()



#>.DEV. by EXTV//ANX13TY