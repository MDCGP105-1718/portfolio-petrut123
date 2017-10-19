x=0
y=0

def FizzBuzz(x,y):
 """
 Input the range you want to search!
 Return Fizz Buzz
 """
 x = int(input("Minimum value: "))
 y = int(input("Maximum value: "))

 for i in range(x,y+1):
    if (i % 3 == 0) and (i % 5 == 0):
        print("FizzBuzz")
    elif i % 5 == 0:
        print("Buzz")
    elif i % 3 == 0:
        print("Fizz")
    else: print(i)

FizzBuzz(x,y)
