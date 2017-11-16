class car(object):
    def __init__(self,colour,manufacturer,model,doors):
        self.colour = colour;
        self.manufacturer = manufacturer;
        self.model = model;
        self.doors = doors;
    def __str__(self):
        return car(self.colour, self.manufacturer, self.model, self.doors)
