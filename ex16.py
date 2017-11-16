class Fraction(object):
    def __init__(self,num,denom):
        self.num = num;
        self.denom = denom;

    def __add__(self,other):
        return Fraction(self.num + other.denom)
    def __sub__(self,other):
        return Fraction(self.num - other.denom)
    def mult(self,other):
        return Fraction(self.num * other.denom)
    def div(self,other):
        return Fraction(self.num / other.denom)
    def inverse(self):
        self.num, self.denom = self.denom, self.num
        return Fraction(self.num, self.denom)
