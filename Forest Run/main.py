#resolution used is 1280x720
from tkinter import Tk, PhotoImage, Label, Frame, Button, simpledialog, Toplevel, Canvas, DISABLED
import random

#variables
xPos = 4
yPos = 3
wasPreviousMoveDown = False
score = 0
coins = 0
dynamite = 0
gameOver = False
gamePaused = False
bossKeyed = False
dynamiteCode = False
doublePoints = False
doubleCoins = False
userName = ""
characterChosen = 1
reloadFileUsed = False
grid = [
         [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
         [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
         [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
         [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
         [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ']
]

# checks if a move left is possible using check() and if is then performs moveLeft()
def leftKey(event):
    global xPos, yPos, grid,coins
    if(gamePaused == False and bossKeyed == False):
        if (xPos != 0):
            xPos = xPos - 1
            possible = check(xPos, yPos)
            if (possible == 1):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveLeft(xPos, yPos)
            elif (possible == 2):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveLeft(xPos, yPos)
                if (doubleCoins == True):
                    coins = coins + 2
                    checkCoins()
                else:
                    coins = coins + 1
                    checkCoins()
            elif (possible == 3):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveLeft(xPos, yPos)
                if (doubleCoins == True):
                    coins = coins + 6
                    checkCoins()
                else:
                    coins = coins + 3
                    checkCoins()
            else:
                lost()
        labelsAndButtons()
# checks if a move right is possible using check() and if is then performs moveRight()
def rightKey(event):
    global xPos, yPos, grid, coins
    if (gamePaused == False and bossKeyed == False):
        if (xPos != 9):
            xPos = xPos + 1
            possible = check(xPos, yPos)
            if (possible == 1):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveRight(xPos, yPos)
            elif (possible == 2):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveRight(xPos, yPos)
                if (doubleCoins == True):
                    coins = coins + 2
                    checkCoins()
                else:
                    coins = coins + 1
                    checkCoins()
            elif (possible == 3):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveRight(xPos, yPos)
                if (doubleCoins == True):
                    coins = coins + 6
                    checkCoins()
                else:
                    coins = coins + 3
                    checkCoins()
            else:
                lost()
        labelsAndButtons()
# checks if a move up is possible using check() and if is then performs moveUp()
def upKey(event):
    global xPos, yPos, grid, wasPreviousMoveDown, score, coins, gameOver
    if (gamePaused == False and bossKeyed == False):
        if (wasPreviousMoveDown == True):
            yPos = yPos - 1
            possible = check(xPos, yPos)
            if (possible == 1):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveUp(xPos, yPos)
            elif (possible == 2):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveUp(xPos, yPos)
                if (doubleCoins == True):
                    coins = coins + 2
                    checkCoins()
                else:
                    coins = coins + 1
                    checkCoins()
            elif (possible == 3):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveUp(xPos, yPos)
                if (doubleCoins == True):
                    coins = coins + 6
                    checkCoins()
                else:
                    coins = coins + 3
                    checkCoins()
            else:
                lost()
        else:
            possible = check(xPos, yPos - 1)
            if (possible == 1):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveUp(xPos, yPos)
                if(doublePoints == True):
                    score = score + 2
                else:
                 score = score + 1
            elif (possible == 2):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveUp(xPos, yPos)
                if (doublePoints == True):
                    score = score + 2
                else:
                    score = score + 1
                if (doubleCoins == True):
                    coins = coins + 2
                    checkCoins()
                else:
                    coins = coins + 1
                    checkCoins()
            elif (possible == 3):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveUp(xPos, yPos)
                if (doublePoints == True):
                    score = score + 2
                else:
                    score = score + 1
                if (doubleCoins == True):
                    coins = coins + 6
                    checkCoins()
                else:
                    coins = coins + 3
                    checkCoins()
            else:
                lost()
        wasPreviousMoveDown = False
        if (gameOver == False):
            labelsAndButtons()
# checks if a move down is possible using check() and if is then performs moveDown()
def downKey(event):
    global xPos, yPos, grid, wasPreviousMoveDown,coins
    if (gamePaused == False and bossKeyed == False):
        if (yPos != 4):
            yPos = yPos + 1
            possible = check(xPos, yPos)
            if (possible == 1):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveDown(xPos, yPos)
            elif (possible == 2):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveDown(xPos, yPos)
                if (doubleCoins == True):
                    coins = coins + 2
                    checkCoins()
                else:
                    coins = coins + 1
                    checkCoins()
            elif (possible == 3):
                for widgets in frame.winfo_children():
                    widgets.destroy()
                grid = moveDown(xPos, yPos)
                if (doubleCoins == True):
                    coins = coins + 6
                    checkCoins()
                else:
                    coins = coins + 3
                    checkCoins()
            else:
                lost()
            wasPreviousMoveDown = True
        labelsAndButtons()
# checks if a dynamite move up is possible if it is then 'explodes' obstruction above
def wKey(event):
    global xPos,yPos,grid, dynamite
    if (gamePaused == False and bossKeyed == False):
        if (dynamite > 0):
            squareAbove = grid[yPos - 1][xPos]
            if (squareAbove == 1 or squareAbove == 2):
                frame.after(200, ex, xPos, (yPos - 1))
                Label(frame, image=grass_2_ex).place(x=(xPos * 128), y=((yPos - 1) * 144))
                grid[yPos - 1][xPos] = 8
                dynamite = dynamite - 1
            elif (squareAbove == 3 or squareAbove == 4):
                frame.after(200, ex, xPos, (yPos - 1))
                Label(frame, image=grass_3_ex).place(x=(xPos * 128), y=((yPos - 1) * 144))
                grid[yPos - 1][xPos] = 8
                dynamite = dynamite - 1
            elif (squareAbove == 5):
                frame.after(200, ex, xPos, (yPos - 1))
                Label(frame, image=grass_4_ex).place(x=(xPos * 128), y=((yPos - 1) * 144))
                grid[yPos - 1][xPos] = 8
                dynamite = dynamite - 1
        if (dynamite > 0):
            dynamitetxt = "Dynamite:" + str(dynamite)
            Label(frame, text=dynamitetxt).place(x=290, y=30)
# checks if a dynamite move down is possible if it is then 'explodes' obstruction below
def sKey(event):
    global xPos,yPos,grid, dynamite
    if (gamePaused == False and bossKeyed == False):
        if (dynamite > 0):
            squareBelow = grid[yPos + 1][xPos]
            if (squareBelow == 1 or squareBelow == 2):
                frame.after(200, ex, xPos, (yPos + 1))
                Label(frame, image=grass_2_ex).place(x=(xPos * 128), y=((yPos + 1) * 144))
                grid[yPos + 1][xPos] = 8
                dynamite = dynamite - 1
            elif (squareBelow == 3 or squareBelow == 4):
                frame.after(200, ex, xPos, (yPos + 1))
                Label(frame, image=grass_3_ex).place(x=(xPos * 128), y=((yPos + 1) * 144))
                grid[yPos + 1][xPos] = 8
                dynamite = dynamite - 1
            elif (squareBelow == 5):
                frame.after(200, ex, xPos, (yPos + 1))
                Label(frame, image=grass_4_ex).place(x=(xPos * 128), y=((yPos + 1) * 144))
                grid[yPos + 1][xPos] = 8
                dynamite = dynamite - 1
        if (dynamite > 0):
            dynamitetxt = "Dynamite:" + str(dynamite)
            Label(frame, text=dynamitetxt).place(x=290, y=30)
# checks if a dynamite move left is possible if it is then 'explodes' obstruction left
def aKey(event):
    global xPos,yPos,grid, dynamite
    if (gamePaused == False and bossKeyed == False):
        if (dynamite > 0):
            squareLeft = grid[yPos][xPos - 1]
            if (squareLeft == 1 or squareLeft == 2):
                frame.after(200, ex, (xPos - 1), yPos)
                Label(frame, image=grass_2_ex).place(x=((xPos - 1) * 128), y=(yPos * 144))
                grid[yPos][xPos - 1] = 8
                dynamite = dynamite - 1
            elif (squareLeft == 3 or squareLeft == 4):
                frame.after(200, ex, (xPos - 1), yPos)
                Label(frame, image=grass_3_ex).place(x=((xPos - 1) * 128), y=(yPos * 144))
                grid[yPos][xPos - 1] = 8
                dynamite = dynamite - 1
            elif (squareLeft == 5):
                frame.after(200, ex, (xPos - 1), yPos)
                Label(frame, image=grass_4_ex).place(x=((xPos - 1) * 128), y=(yPos * 144))
                grid[yPos][xPos - 1] = 8
                dynamite = dynamite - 1
        if (dynamite > 0):
            dynamitetxt = "Dynamite:" + str(dynamite)
            Label(frame, text=dynamitetxt).place(x=290, y=30)
# checks if a dynamite move right is possible if it is then 'explodes' obstruction right
def dKey(event):
    global xPos,yPos,grid, dynamite
    if (gamePaused == False and bossKeyed == False):
        if (dynamite > 0):
            squareRight = grid[yPos][xPos + 1]
            if (squareRight == 1 or squareRight == 2):
                frame.after(200, ex, (xPos + 1), yPos)
                Label(frame, image=grass_2_ex).place(x=((xPos + 1) * 128), y=(yPos * 144))
                grid[yPos][xPos + 1] = 8
                dynamite = dynamite - 1
            elif (squareRight == 3 or squareRight == 4):
                frame.after(200, ex, (xPos + 1), yPos)
                Label(frame, image=grass_3_ex).place(x=((xPos + 1) * 128), y=(yPos * 144))
                grid[yPos][xPos + 1] = 8
                dynamite = dynamite - 1
            elif (squareRight == 5):
                frame.after(200, ex, (xPos + 1), yPos)
                Label(frame, image=grass_4_ex).place(x=((xPos + 1) * 128), y=(yPos * 144))
                grid[yPos][xPos + 1] = 8
                dynamite = dynamite - 1
        if (dynamite > 0):
            dynamitetxt = "Dynamite:" + str(dynamite)
            Label(frame, text=dynamitetxt).place(x=290, y=30)
# displays boss key image to give illusuion that player is working
def bossKey(event):
    global bossKeyed, bossKeyLabel
    if(bossKeyed == False):
        bossKeyLabel = Label(frame, image=boss)
        bossKeyLabel.pack()
        bossKeyed = True
    else:
        bossKeyLabel.destroy()
        bossKeyed = False
# explosion function required to delay explosion and show 2 frames
def ex(xPos, yPos):
    Label(frame, image=grass_1).place(x=(xPos * 128), y=(yPos  * 144))
# moves Character left using moveChar and redraws grid
def moveLeft(xPos, yPos):
    global grid
    newGrid = [
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ']
    ]
    for h in range(10):
        for i in range(5):
            # change characters position in x and generate new square for old position
            if(h == xPos and i == yPos):
                moveChar(h,i)
                newGrid[yPos][xPos] = "char"
                Label(frame, image=grass_1).place(x=((h+1) * 128), y=(i * 144))
                newGrid[yPos][xPos+1] = 8
            else:
                if (grid[i][h] == 1 or grid[i][h] == 2):
                    Label(frame, image=grass_2).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 2
                elif (grid[i][h] == 3 or grid[i][h] == 4):
                    Label(frame, image=grass_3).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 3
                elif (grid[i][h] == 5):
                    Label(frame, image=grass_4).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 5
                elif (grid[i][h] == 6):
                    Label(frame, image=coin1).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 6
                elif (grid[i][h] == 7):
                    Label(frame, image=coin2).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 7
                else:
                    Label(frame, image=grass_1).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 8
    return newGrid
# moves Character right using moveChar and redraws grid
def moveRight(xPos, yPos):
    global grid
    newGrid = [
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ']
    ]
    for h in range(10):
        for i in range(5):
            # change characters position in x and generate new square for old position
            if(h == xPos and i == yPos):
                moveChar(h,i)
                newGrid[yPos][xPos] = "char"
                Label(frame, image=grass_1).place(x=((h+1) * 128), y=(i * 144))
                newGrid[yPos][xPos-1] = 8
            else:
                if (grid[i][h] == 1 or grid[i][h] == 2):
                    Label(frame, image=grass_2).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 2
                elif (grid[i][h] == 3 or grid[i][h] == 4):
                    Label(frame, image=grass_3).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 3
                elif (grid[i][h] == 5):
                    Label(frame, image=grass_4).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 5
                elif (grid[i][h] == 6):
                    Label(frame, image=coin1).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 6
                elif (grid[i][h] == 7):
                    Label(frame, image=coin2).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 7
                else:
                    Label(frame, image=grass_1).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 8
    return newGrid
# moves Character up using moveChar and redraws grid
def moveUp(xPos, yPos):
    global grid, wasPreviousMoveDown
    newGrid = [
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ']
    ]
    for h in range(10):
        for i in range(5):
            grass = random.randint(1, 20)
            # change characters position in x and generate new square for old position
            if(h == xPos and i == yPos):
                moveChar(h,i)
                newGrid[yPos][xPos] = "char"
                Label(frame, image=grass_1).place(x=((h+1) * 128), y=(i * 144))
                newGrid[yPos+1][xPos] = 1
            elif(wasPreviousMoveDown == True):
                if (grid[i][h] == 1 or grid[i][h] == 2):
                    Label(frame, image=grass_2).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 2
                elif (grid[i][h] == 3 or grid[i][h] == 4):
                    Label(frame, image=grass_3).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 3
                elif (grid[i][h] == 5):
                    Label(frame, image=grass_4).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 5
                elif (grid[i][h] == 6):
                    Label(frame, image=coin1).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 6
                elif (grid[i][h] == 7):
                    Label(frame, image=coin2).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 7
                else:
                    Label(frame, image=grass_1).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 8
            elif (i != 0):
                numOfSquareAbove = grid[i - 1][h]
                if (numOfSquareAbove == 1 or numOfSquareAbove == 2 ):
                    Label(frame, image=grass_2).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 2
                elif (numOfSquareAbove == 3 or numOfSquareAbove == 4):
                    Label(frame, image=grass_3).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 3
                elif (numOfSquareAbove == 5):
                    Label(frame, image=grass_4).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 5
                elif (numOfSquareAbove == 6):
                    Label(frame, image=coin1).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 6
                elif (numOfSquareAbove == 7):
                    Label(frame, image=coin2).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 7
                else:
                    Label(frame, image=grass_1).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 8
            else:
                if (grass == 1 or grass == 2):
                    Label(frame, image=grass_2).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = grass
                elif (grass == 3 or grass == 4):
                    Label(frame, image=grass_3).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = grass
                elif (grass == 5):
                    Label(frame, image=grass_4).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = grass
                elif (grass == 6):
                    Label(frame, image=coin1).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 6
                elif (grass == 7):
                    Label(frame, image=coin2).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 7
                else:
                    Label(frame, image=grass_1).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = grass
    return newGrid
# moves Character left down moveChar and redraws grid
def moveDown(xPos, yPos):
    global grid
    newGrid = [
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '],
        [' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ']
    ]
    for h in range(10):
        for i in range(5):
            # change characters position in x and generate new square for old position
            if (h == xPos and i == yPos):
                moveChar(h,i)
                newGrid[yPos][xPos] = "char"
            else:
                if (grid[i][h] == 1 or grid[i][h] == 2):
                    Label(frame, image=grass_2).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 1
                elif (grid[i][h] == 3 or grid[i][h] == 4):
                    Label(frame, image=grass_3).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 3
                elif (grid[i][h] == 5):
                    Label(frame, image=grass_4).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 5
                elif (grid[i][h] == 6):
                    Label(frame, image=coin1).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 6
                elif (grid[i][h] == 7):
                    Label(frame, image=coin2).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 7
                else:
                    Label(frame, image=grass_1).place(x=(h * 128), y=(i * 144))
                    newGrid[i][h] = 8
    return newGrid
# moves Character position on grid
def moveChar(h, i):
    global characterChosen
    if(characterChosen == 1):
        Label(frame, image=character_1).place(x=(h * 128), y=(i * 144))
    elif(characterChosen == 2):
        Label(frame, image=character2).place(x=(h * 128), y=(i * 144))
    elif(characterChosen == 3):
        Label(frame, image=character3).place(x=(h * 128), y=(i * 144))
    else:
        Label(frame, image=character4).place(x=(h * 128), y=(i * 144))
# checks whether move is possible
def check (xPos, yPos):
    global grid, coins
    possible = 0
    for h in range(10):
        for i in range(5):
            if(grid[yPos][xPos] == 8 or grid[yPos][xPos] == 9 or grid[yPos][xPos] == 10 or grid[yPos][xPos] == 11 or grid[yPos][xPos] == 12 or grid[yPos][xPos] == 13 or grid[yPos][xPos] == 14 or grid[yPos][xPos] == 15 or grid[yPos][xPos] == 16 or grid[yPos][xPos] == 17 or grid[yPos][xPos] == 18 or grid[yPos][xPos] == 19 or grid[yPos][xPos] == 20):
                possible = 1
            elif(grid[yPos][xPos] == 6):
                possible = 2
            elif (grid[yPos][xPos] == 7):
                possible = 3
            else:
                possible = 0
    return possible

window = Tk() # main window
window.title("Forest Run")
window.geometry("1280x720")

frame = Frame(window, width=1280, height=720)

# all images used
grass_1 = PhotoImage(file="grass.png")
grass_2 = PhotoImage(file="tree1.png")
grass_3 = PhotoImage(file="tree2.png")
grass_4 = PhotoImage(file="rock.png")
character_1 = PhotoImage(file="chicken.png")
character2 = PhotoImage(file="chick.png")
character3 = PhotoImage(file="penguin.png")
character4 = PhotoImage(file="duck.png")
coin1 = PhotoImage(file="coin1.png")
coin2 = PhotoImage(file="coin3.png")
grass_2_ex = PhotoImage(file="exTree1.png")
grass_3_ex = PhotoImage(file="exTree2.png")
grass_4_ex = PhotoImage(file="exRock.png")
pause = PhotoImage(file="pause.png")
resume = PhotoImage(file="resume.png")
play = PhotoImage(file="play.png")
boss = PhotoImage(file="bossKey.png")
name100 = PhotoImage(file="name100.png")
name90 = PhotoImage(file="name90.png")
name80 = PhotoImage(file="name80.png")
name70 = PhotoImage(file="name70.png")
name60 = PhotoImage(file="name60.png")
name50 = PhotoImage(file="name50.png")
name40 = PhotoImage(file="name40.png")
name30 = PhotoImage(file="name30.png")
name20 = PhotoImage(file="name20.png")
name10 = PhotoImage(file="name10.png")
name0 = PhotoImage(file="name0.png")
startMenuText = PhotoImage(file="startMenuText.png")
# displays title and start menu using startMenu()
def start():
    frame.after(30, fadeTitle,80)
    Label(frame, image=name100).place(x=0,y=0)
    startMenu()
# displays start menu
def startMenu():
    global startMenuContinue,startMenuStart,startMenuCheat, startMenuLabel, userName, startMenuLeaderboard, startMenuChar, startMenuInstructions, gameOver
    if(gameOver == True):
        quitWindow.destroy()
    else:
        userName = simpledialog.askstring(title="Username", prompt="What is your name?")
        while(userName == ""):
            userName = simpledialog.askstring(title="Username", prompt="What is your name?")
    gameOver = False
    startMenuLabel = Label(window, image= startMenuText)
    startMenuLabel.place(x=0,y=0)
    startMenuStart = Button(window, font="{Andale Mono} 20", text="Start", activebackground="#66d9ff",
           activeforeground="#ffffff", bg="#ffffff", command=startGame, fg="#66d9ff")
    startMenuStart.place(x=575, y=220)
    startMenuContinue = Button(window, font="{Andale Mono} 20", text="Continue Last Game", activebackground="#66d9ff",
                               activeforeground="#ffffff", bg="#ffffff", command=reloadLastGame, fg="#66d9ff")
    reloadPossible()
    startMenuContinue.place(x=500, y=300)
    startMenuCheat = Button(window, font="{Andale Mono} 20", text="Enter Cheat Code", activebackground="#66d9ff",
           activeforeground="#ffffff", bg="#ffffff", command=cheatCodes, fg="#66d9ff")
    startMenuCheat.place(x=510, y=380)
    startMenuLeaderboard = Button(window, font="{Andale Mono} 20", text="Leaderboard", activebackground="#66d9ff",
           activeforeground="#ffffff", bg="#ffffff", fg="#66d9ff", command=displayLeaderboard)
    startMenuLeaderboard.place(x=540, y=460)
    startMenuChar = Button(window, font="{Andale Mono} 20", text="Change Character", activebackground="#66d9ff",
           activeforeground="#ffffff", bg="#ffffff", fg="#66d9ff", command=changeCharacter)
    startMenuChar.place(x=510, y=540)
    startMenuInstructions = Button(window, font="{Andale Mono} 20", text="Instructions", activebackground="#66d9ff",
           activeforeground="#ffffff", bg="#ffffff", fg="#66d9ff", command=instructions)
    startMenuInstructions.place(x=535, y=620)
# fills grid randomly
def startGame():
    global grid, gameOver
    startMenuCheat.destroy()
    startMenuContinue.destroy()
    startMenuStart.destroy()
    startMenuLabel.destroy()
    startMenuLeaderboard.destroy()
    startMenuChar.destroy()
    startMenuInstructions.destroy()
    if(gameOver == True):
        quitWindow.destroy()
        gameOver = False
    for h in range(10):
        for i in range(5):
            grass = random.randint(1, 20)
            if (h == 4 and i == 3):
                moveChar(h,i)
                grid[i][h] = "char"
            elif (grass == 1 or grass == 2):
                Label(frame, image=grass_2).place(x=(h * 128), y=(i * 144))
                grid[i][h] = grass
            elif (grass == 3 or grass == 4):
                Label(frame, image=grass_3).place(x=(h * 128), y=(i * 144))
                grid[i][h] = grass
            elif (grass == 5):
                Label(frame, image=grass_4).place(x=(h * 128), y=(i * 144))
                grid[i][h] = grass
            elif (grass == 6):
                Label(frame, image=coin1).place(x=(h * 128), y=(i * 144))
                grid[i][h] = grass
            elif (grass == 7):
                Label(frame, image=coin2).place(x=(h * 128), y=(i * 144))
                grid[i][h] = grass
            else:
                Label(frame, image=grass_1).place(x=(h * 128), y=(i * 144))
                grid[i][h] = grass

    labelsAndButtons()
# pauses game and shows new screen
def pauseGame():
    global pauseLabel, resumeButton, gamePaused, txtLabel, saveButton
    gamePaused = True
    pauseButton.destroy()
    pauseLabel = Label(frame, image=resume)
    pauseLabel.pack()
    txtLabel = Label(frame, font="{Andale Mono} 60", text="Do you want to resume?", bg="#66d9ff", fg="#000000")
    txtLabel.place(x=240, y=200)
    resumeButton = Button(frame, image=play, command = resumeGame)
    resumeButton.place(x=600, y=350)
    saveButton = Button(frame,font="{Andale Mono} 20", text="Save and Quit", activebackground="#66d9ff",
           activeforeground="#ffffff", bg="#ffffff", fg="#66d9ff", command= saveLastGame)
    saveButton.place(x=532, y=450)
# resumes game
def resumeGame():
    global pauseButton, gamePaused
    gamePaused = False
    pauseLabel.pack_forget()
    resumeButton.destroy()
    txtLabel.destroy()
    saveButton.destroy()
    pauseButton = Button(frame, image=pause, command=pauseGame)
    pauseButton.place(x=1190, y=30)
# called when player loses and opens new quit window menu
def lost():
    addToLeaderboard()
    resetVariables()
    menu()
# resets all varaibles for next game
def resetVariables():
    global xPos, yPos, wasPreviousMoveDown, score, dynamite, gamePaused , gameOver
    xPos = 4
    yPos = 3
    wasPreviousMoveDown = False
    score = 0
    if (dynamiteCode == True):
        dynamite = 3
    gameOver = False
    gamePaused = False
# quit menu window show after user loses
def menu():
    global quitWindow, gameOver
    quitWindow = Tk()  # create window
    quitWindow.title("Forest Run")
    quitWindow.geometry("600x350")
    gameOver = True
    Button(quitWindow, font="{Andale Mono} 20", text="Retry", activebackground="#66d9ff",
           activeforeground="#ffffff", bg="#ffffff", command=startGame, fg="#66d9ff").place(x=250, y=100)
    Button(quitWindow, font="{Andale Mono} 20", text="Quit", activebackground="#66d9ff",
           activeforeground="#ffffff", bg="#ffffff", fg="#66d9ff", command=quitGame).place(x=255, y=150)
    Button(quitWindow, font="{Andale Mono} 20", text="Return to main menu", activebackground="#66d9ff",
           activeforeground="#ffffff", bg="#ffffff", fg="#66d9ff", command=startMenu).place(x=175, y=200)
    quitWindow.config(bg ="#66d9ff")
# ends game and closes all windows
def quitGame():
    window.destroy()
    quitWindow.destroy()
# saves last game data to text file
def saveLastGame():
    if(gameOver == False):
        lastgame = open("saveLog.txt", "w")
        lastgame.write("xPos="+str(xPos)+'\n')
        lastgame.write("yPos=" + str(yPos) + '\n')
        lastgame.write("wasPreviousMoveDown=" + str(wasPreviousMoveDown) + '\n')
        lastgame.write("score=" + str(score) + '\n')
        lastgame.write("coins=" + str(coins) + '\n')
        lastgame.write("dynamite=" + str(dynamite) + '\n')
        lastgame.write("gameOver=" + str(gameOver) + '\n')
        lastgame.write("dynamiteCode=" + str(dynamiteCode) + '\n')
        lastgame.write("doublePoints=" + str(doublePoints) + '\n')
        lastgame.write("doubleCoins=" + str(doubleCoins) + '\n')
        lastgame.write("userName=" + userName.lower() + '\n')
        lastgame.write("characterChosen=" + str(characterChosen) + '\n')
        lastgame.write("grid=" + str(grid) + '\n')
        lastgame.close()
    window.destroy()
# checks if game reload is possible for this user
def reloadPossible():
    global reloadFileUsed
    lastgame = open("saveLog.txt", "r")
    readFile = lastgame.read()
    if("reloadFileUsed=True" in readFile):
        reloadFileUsed = True
    if(userName.lower() not in readFile or reloadFileUsed == True):
        startMenuContinue["state"] = DISABLED
# reloads user's last game data from text file and generates the appropriate grid
def reloadLastGame():
    global xPos, yPos, wasPreviousMoveDown, score, coins, dynamite, dynamiteCode, doublePoints, doubleCoins, userName, characterChosen, grid, reloadFileUsed
    startMenuCheat.destroy()
    startMenuContinue.destroy()
    startMenuStart.destroy()
    startMenuLabel.destroy()
    startMenuLeaderboard.destroy()
    startMenuChar.destroy()
    startMenuInstructions.destroy()
    reloadFileUsed = True
    readSaveLog = open("saveLog.txt")
    readFile = readSaveLog.readlines()
    lengthOfFile = len(readFile)
    for i in range(lengthOfFile):
        currentLine = readFile[i]
        value = currentLine.split("=")
        if(value[0] == "xPos"):
            xPos = int(value[1])
        elif (value[0] == "yPos"):
            yPos = int(value[1])
        elif (value[0] == "wasPreviousMoveDown"):
            if(value[1] == "True"):
                wasPreviousMoveDown = True
        elif (value[0] == "score"):
            score = int(value[1])
        elif (value[0] == "coins"):
            coins = int(value[1])
        elif (value[0] == "dynamite"):
            dynamite = int(value[1])
        elif (value[0] == "dynamiteCode"):
            if (value[1] == "True"):
                dynamiteCode = True
        elif (value[0] == "doublePoints"):
            if (value[1] == "True"):
                doublePoints = True
        elif (value[0] == "doubleCoins"):
            if (value[1] == "True"):
                doubleCoins = True
        elif (value[0] == "userName"):
            userName = value[1].strip()
        elif (value[0] == "characterChosen"):
            characterChosen = int(value[1])
        elif (value[0] == "grid"):
            newGrid = (value[1]).replace('[', '')
            newGrid = (newGrid).replace(']', '')
            newGrid = (newGrid).replace("'", '')
            newGrid = (newGrid).replace(' ', '')
            gridList = newGrid.split(",")
            counter = 0
            for h in range(5):
                for i in range(10):
                    grid[h][i] = gridList[counter]
                    counter = counter + 1

    for h in range(10):
        for i in range(5):
            if (grid[i][h] == "char"):
                moveChar(h,i)
            elif (grid[i][h] == "1" or grid[i][h] == "2"):
                Label(frame, image=grass_2).place(x=(h * 128), y=(i * 144))
                grid[i][h] = 1
            elif (grid[i][h] == "3" or grid[i][h] == "4"):
                Label(frame, image=grass_3).place(x=(h * 128), y=(i * 144))
                grid[i][h] = 3
            elif (grid[i][h] == "5"):
                Label(frame, image=grass_4).place(x=(h * 128), y=(i * 144))
                grid[i][h] = 5
            elif (grid[i][h] == "6"):
                Label(frame, image=coin1).place(x=(h * 128), y=(i * 144))
                grid[i][h] = 6
            elif (grid[i][h] == "7"):
                Label(frame, image=coin2).place(x=(h * 128), y=(i * 144))
                grid[i][h] = 7
            else:
                Label(frame, image=grass_1).place(x=(h * 128), y=(i * 144))
                grid[i][h] = 8
    appendSaveLog = open("saveLog.txt", "a")
    appendSaveLog.write("reloadFileUsed=True")

    labelsAndButtons()
# sets boolean values so user can use cheat codes throughout their gaming session
def cheatCodes():
    global dynamite, dynamiteCode, doublePoints, doubleCoins
    #doublepoints = double points
    #doublecoins = double coins
    #dynamite = gives 3 dynamites
    code = simpledialog.askstring(title="Cheat Code", prompt="Enter cheat code:")
    if (code == "doublepoints"):
        doublePoints = True
    elif (code == "doublecoins"):
        doubleCoins = True
    elif (code == "dynamite"):
        dynamite = 3
        dynamiteCode = True
    startGame()
# add user's score to leaderboard if it is their highest score
def addToLeaderboard():
    readLeaderBoard = open("leaderboard.txt")
    readFile = readLeaderBoard.readlines()
    lengthOfLeaderBoard = len(readFile)
    newList = readFile
    newStr = ""
    newUser = True
    for i in range(lengthOfLeaderBoard):
        currentLine = readFile[i]
        playerScore = currentLine.split("/")
        if (userName.lower() == playerScore[0].lower()):
            if (score > int(playerScore[1])):
                # alert user of new high score
                leaderBoard = open("leaderboard.txt", "w")
                del newList[i]
                newList.append(userName.lower() + "/" + str(score) + '\n')
                for x in range(len(newList)):
                    newStr = newStr + newList[x]
                leaderBoard.write(newStr)
                leaderBoard.close()
            newUser = False

    if (newUser == True):
        leaderBoard = open("leaderboard.txt", "a")
        entry = userName.lower() + "/" + str(score)
        leaderBoard.write(entry + '\n')
        leaderBoard.close()

    readLeaderBoard.close()
# displays leaderboard to new window
def displayLeaderboard():
    global leaderboardWindow
    readLeaderBoard = open("leaderboard.txt")
    readFile = readLeaderBoard.readlines()
    lengthOfLeaderBoard = len(readFile)
    orderedList = readFile
    currentPosition = 0

    #bubble sort
    for x in range(lengthOfLeaderBoard):
        for y in range(lengthOfLeaderBoard-1):
            currentLine = orderedList[y]
            player = currentLine.split("/")
            lineAhead = orderedList[y+1]
            playerAhead = lineAhead.split("/")
            if int(player[1]) < int(playerAhead[1]):
                orderedList[y], orderedList[y+1] = orderedList[y+1],orderedList[y]

    for i in range(lengthOfLeaderBoard):
        currentLine = orderedList[i]
        playerName = currentLine.split("/")
        if(userName.lower() == playerName[0].lower()):
            currentPosition = i+1

    leaderboardWindow = Tk()  # create window
    leaderboardWindow.title("Leaderboard")
    leaderboardWindow.geometry("600x350")

    first = orderedList[0].split("/")
    firstPlace = "1st place is " + first[0] + " with a score of " + first[1]
    second = orderedList[1].split("/")
    secondPlace = "2nd place is " + second[0] + " with a score of " + second[1]
    third = orderedList[2].split("/")
    thirdPlace = "3rd place is " + third[0] + " with a score of " + third[1]
    fourth = orderedList[3].split("/")
    fourthPlace = "4th place is " + fourth[0] + " with a score of " + fourth[1]
    fifth = orderedList[4].split("/")
    fifthPlace = "5th place is " + fifth[0] + " with a score of " + fifth[1]
    currentPosition = "Your highest score is in " + str(currentPosition) + "th place"
    Label(leaderboardWindow, text="Leaderboard", font="{Andale Mono} 30 ", bg="#ffffff", fg="#000000" ).place(x=30, y=10)
    Label(leaderboardWindow, text=firstPlace,font="{Andale Mono} 22 ", bg="#66d9ff", fg="#000000").place(x=30, y=50)
    Label(leaderboardWindow,font="{Andale Mono} 20 ", text=secondPlace, bg="#66d9ff", fg="#000000").place(x=30, y=100)
    Label(leaderboardWindow,font="{Andale Mono} 20 ", text=thirdPlace, bg="#66d9ff", fg="#000000").place(x=30, y=150)
    Label(leaderboardWindow,font="{Andale Mono} 20 ", text=fourthPlace, bg="#66d9ff", fg="#000000").place(x=30, y=200)
    Label(leaderboardWindow,font="{Andale Mono} 20 ", text=fifthPlace, bg="#66d9ff", fg="#000000").place(x=30, y=250)
    Label(leaderboardWindow,font="{Andale Mono} 15 ", text=currentPosition, bg="#66d9ff", fg="#000000").place(x=30, y=300)
    Button(leaderboardWindow, font="{Andale Mono} 20 ", text="Return to menu", activebackground="#66d9ff",
           activeforeground="#ffffff", bg="#ffffff", command= lambda :leaderboardWindow.destroy(), fg="#66d9ff").place(x=385, y=305)
    leaderboardWindow.config(bg="#66d9ff")
# character change window
def changeCharacter():
    global characterWindow, gameOver
    gameOver = False
    characterWindow = Toplevel()
    characterWindow.title("Characters")
    characterWindow.geometry("620x370")

    Button(characterWindow, image=character_1, command = lambda: updateCharacter(1)).place(x=20,y=100)
    Button(characterWindow, image=character2, command = lambda: updateCharacter(2)).place(x=170, y=100)
    Button(characterWindow, image=character3, command = lambda: updateCharacter(3)).place(x=320, y=100)
    Button(characterWindow, image=character4, command = lambda: updateCharacter(4)).place(x=470, y=100)

    Button(characterWindow, font="{Andale Mono} 20 ", text="Return to menu", activebackground="#66d9ff",
           activeforeground="#ffffff", bg="#ffffff", command=lambda :characterWindow.destroy() , fg="#66d9ff").place(x=395, y=315)
    characterWindow.config(bg="#66d9ff")
# changes character by changing value of characterChosen
def updateCharacter(number):
    global characterChosen
    if(number == 1):
        characterChosen = 1
    elif(number == 2):
        characterChosen = 2
    elif(number == 3):
        characterChosen = 3
    else:
        characterChosen = 4
    startGame()
    characterWindow.destroy()
# instruction window
def instructions():
    global instructionWindow, gameOver
    gameOver = False
    instructionWindow = Toplevel()
    instructionWindow.title("Characters")
    instructionWindow.geometry("620x370")

    canvas = Canvas(instructionWindow, bg="#66d9ff", height= 370, width=620)
    instruction1 = "1. Use the up, down, left and right keys to move "
    instruction2 = "2. Do not crash into any obstructions - trees and rocks"
    instruction3 = "3. When you get 100 coins you will get a dynamite"
    instruction4 = "4. To use the dynamite to remove an obstacle use the w, s, a and d keys"
    instruction5 = "5. Points are awarded based on how far you get across the forest before hitting an obstruction"
    instruction6 = "6. Have fun :)"
    Label(canvas, font="{Andale Mono} 10 ", text=instruction1, bg="#66d9ff", fg="#000000").place(x=30, y=50)
    canvas.create_rectangle(245,40,95,77, fill="#ffffff")
    Label(canvas, font="{Andale Mono} 10 ", text=instruction2, bg="#66d9ff", fg="#000000").place(x=30, y=100)
    Label(canvas, font="{Andale Mono} 10 ", text=instruction3, bg="#66d9ff", fg="#000000").place(x=30, y=150)
    canvas.create_oval(120,139,160,179, fill="#ffffff")
    Label(canvas, font="{Andale Mono} 10 ", text=instruction4, bg="#66d9ff", fg="#000000").place(x=30, y=200)
    canvas.create_rectangle(435, 190, 345, 227, fill="#ffffff")
    Label(canvas, font="{Andale Mono} 10 ", text=instruction5, bg="#66d9ff", fg="#000000").place(x=30, y=250)
    Label(canvas, font="{Andale Mono} 10 ", text=instruction6, bg="#66d9ff", fg="#000000").place(x=30, y=300)
    Button(canvas, font="{Andale Mono} 20 ", text="Return to menu", activebackground="#66d9ff",
           activeforeground="#ffffff", bg="#ffffff", command=lambda: instructionWindow.destroy(), fg="#66d9ff").place(
        x=395, y=315)
    canvas.pack()
# makes opening title fade using delay and 10 frames
def fadeTitle(opacity):
    if(opacity == 90):
        Label(frame, image=name90).place(x=0, y=0)
    elif (opacity == 80):
        Label(frame, image=name80).place(x=0, y=0)
    elif (opacity == 70):
        Label(frame, image=name70).place(x=0, y=0)
    elif(opacity == 60):
        Label(frame, image=name60).place(x=0, y=0)
    elif (opacity == 50):
        Label(frame, image=name50).place(x=0, y=0)
    elif(opacity == 40):
        Label(frame, image=name40).place(x=0, y=0)
    elif (opacity == 30):
        Label(frame, image=name30).place(x=0, y=0)
    elif(opacity == 20):
        Label(frame, image=name20).place(x=0, y=0)
    elif (opacity == 10):
        Label(frame, image=name10).place(x=0, y=0)
    else:
        Label(frame, image=name0).place(x=0,y=0)

    if(opacity > 0):
        frame.after(30, fadeTitle, opacity-10)
# updates labels and buttons
def labelsAndButtons():
    global pauseButton
    txt = "Score:" + str(score)
    Label(frame, text=txt).place(x=30, y=30)

    cointxt = "Coin:" + str(coins)
    Label(frame, text=cointxt).place(x=160, y=30)

    if(dynamite > 0):
        dynamitetxt = "Dynamite:" + str(dynamite)
        Label(frame, text=dynamitetxt).place(x=290, y=30)

    pauseButton = Button(frame, image=pause, command=pauseGame)
    pauseButton.place(x=1190, y=30)
# checks if coins > 100 and allocates a dynamite if so
def checkCoins():
    global dynamite, coins
    if(coins > 100):
        dynamite = dynamite + 1
        coins = coins - 100

window.bind("<Left>", leftKey)
window.bind("<Right>", rightKey)
window.bind("<Up>", upKey)
window.bind("<Down>", downKey)
window.bind("<KeyPress-w>", wKey)
window.bind("<KeyPress-a>", aKey)
window.bind("<KeyPress-s>", sKey)
window.bind("<KeyPress-d>", dKey)
window.bind("<KeyPress-b>", bossKey)

frame.pack()
start()
window.mainloop()
