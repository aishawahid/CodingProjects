import random

print("1. Easy")
print("2. Medium")
print("3. Hard")
difficulty = input("Enter difficulty level 1, 2 or 3: ")
theWords = []
file = open("EnglishWords.txt", "r")
for line in file:
    line = line.rstrip()
    if (len(line) >= 10 and difficulty == "3"):
        theWords.append(line)
    elif (len(line) > 5 and len(line) < 10 and difficulty == "2"):
        theWords.append(line)
    elif (len(line) <= 5 and difficulty == "1"):
        theWords.append(line)
word = random.choice(theWords)
count = 0
win = False
guesses = " "
answer = ""
numberOfChars = len(word)
for i in range(numberOfChars):
    answer += "_"

while (count < 10 and win == False):
    count = count + 1
    guess = input("Enter guess " + str(count))
    guesses = guesses + guess
    tmp = ""
    i = 0
    while(i<len(word)):
        if(word[i] == guess):
            tmp = tmp + guess
        else:
            tmp = tmp + answer[i]
        i = i + 1
    if(answer != tmp):
        print("good guess")
        count = count - 1
        answer = tmp
    else:
        print("not a good guess")
    if(answer == word):
        print("Well done you win!")
        win = True
    print(str(10-count) + "/10 guesses left.")
    print("your guesses: " + guesses)
    print("The word so far: " + answer)
