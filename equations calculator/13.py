'''
    To to this I need to use the Triangle Inequality Theorem, which states that the sum of
    two side lengths of a triangle is always greater than the third side. If this is true for
    all three combinations of added side lengths, then you will have a triangle.

    Formula:
        a + b > c
        a + c > b
        b + c > a

    Ex: a = 7, b = 10, c = 5
        
        a + b = 7 + 10 => 17 > 5 True
        a + c = 7 + 5 = 12 => 12 > 10 True
        b + c = 10 + 5 = 15 => 15 > 7 True
        They can form a triangle

    Ex: a = 5, b = 8, c = 3

        a + b = 5 + 8 = 13 => 13 > 3 True
        a + c = 5 + 3 = 8 => 8 > 8 False
        They cannot form a triangle
'''

def det(a, b, c):
    if (a+b > c) and (a+c > b) and (b+c > a):
        return 1
    else:
        return 0

print(det(3,8,5))