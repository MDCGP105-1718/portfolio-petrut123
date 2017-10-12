semi_annual_raise = 0.07
r = 0.04
cost_house = 1000000
down_payment = cost_house * 0.25
time = 0  #Months
monthly_salary = float(input("How much do you earn monthly? "))
steps = 0
current_savings = 0
epsilon = 100
low = 0
high= 10000
guess = (high + low) / 2.0
verify = False
while abs(guess - (current_savings - down_payment)) >= epsilon:
    time = 0
    steps+=1
    current_savings = 0
    while current_savings <= down_payment:
        current_savings=current_savings + monthly_salary * guess
        current_savings= current_savings + current_savings*r/12
        time+=1
        if time % 6 == 0:
            monthly_salary=monthly_salary * semi_annual_raise + monthly_salary

    if time <= 36:
        verify = True
        guess = guess / 10000
        print(f"Best saving rate: {guess}")
        print(f"Steps in bisection search: {steps}")
        break
    guess = guess / 2.0
if verify == False:
    print("It is not possible to pay the down payment in three years")
