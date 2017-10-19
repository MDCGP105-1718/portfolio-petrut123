def hotel_cost(nights):
    return(70 * nights)

def plane_ticket_cost(city,seat_class):

    if city == "New York":
        return(2000 * seat_class)
    elif city == "Auckland":
        return(790 * seat_class)
    elif city == "Venice":
        return(154 * seat_class)
    elif city =="Glasgow":
        return(65 * seat_class)
    else: "We don't have your destination!"

def rental_car_cost(days):
    daily_cost = 30
    t_cost = days * daily_cost
    if days > 7:
        t_cost-=50
    elif days > 3:
        t_cost-=30
    return(t_cost)
def total_cost(city,days):
    print(hotel_cost(days - 1) + plane_ticket_cost(city, 1.3) + rental_car_cost(days))
total_cost("New York", 10)
