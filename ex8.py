total_cost = float(input("Total cost of the house "))
portion_deposit = 0.20
current_savings = 0.0
r= 0.04
annual_salary = float(input("How much do you earn? "))
portion_saved = float(input("How much do you want to save? "))
monthly_salary = annual_salary/12
m=0
semi_annual_raise=0.1

while current_savings < total_cost*portion_deposit:
    current_savings=current_savings + monthly_salary * portion_saved
    current_savings= current_savings + current_savings*r/12
    m=m+1
    if m % 6 == 0:
        monthly_salary=monthly_salary * semi_annual_raise + monthly_salary
print(f"Numer of months: {m}")
