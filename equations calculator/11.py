import math
"""
    The Pythagorean Theorem tells us that the relationship in every right triangle is:
        a^2 + b^2 = c^2 
        where a and b are the sides/legs of the triangle

    ex: a = 4, b = 6
        => c^2 = 4^2 + 6^2
        => c^2 = 36 + 16
        => c^2 = 52
        => c = sqrt(52) = ~7.2
"""

def hyp(side1, side2):
    square1 = pow(side1, 2)
    square2 = pow(side2, 2)
    total = square1 + square2

    hypotenuse = math.sqrt(total)

    return hypotenuse

print(hyp(4, 6))