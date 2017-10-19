from random import randint
x = randint(1,100) #The number you want to find
count = 0
guess = 0
def guessing(guess,count):

    """
    Take a guess!
    It counts how many tries it took to guess the number!
    Just guess!
    """

    while guess != x:
        guess = int(input("Take a guess: "))
        count+=1
        if guess > x:
            print("The number is lower!")
        elif guess < x:
            print("The number is higher!")
        if guess == x:
            print("Congratulations! You found it!")
            print(f"You guessed it in {count} times!")

guessing(guess,count)
