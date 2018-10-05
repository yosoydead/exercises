import math

#the area of a square is the size of one of its sides to the power of 2
def area(length):
    return length * length

#diagonal formula -> www.mathopenref.com/squareperimeter.html
def diagonal(length):
    return length * math.sqrt(2)

#perimeter is just side size times 4
def perimeter(length):
    return 4*length

side = 10
print("area",area(side))
print("diagonal",diagonal(side))
print("perimeter",perimeter(side))
