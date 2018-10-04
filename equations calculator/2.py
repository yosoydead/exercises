#ill use hardcoded values
a = 6
b = -7
'''
    for intervals, use [ ] when you want to include the end value
    use ( ) when you don't

    ex: (5,12] means from 5 to 12, do NOT include 5, but DO include 12

    this means that:
        [-1, 1] -> INCLUDE both -1 and 1
        (-infinite, -1) -> include everything AFTER -1 because -1 is taken for the first interval
        (1, infinite) -> include everything AFTER 1 because 1 is taken for the first interval
'''

def f(n):
    #if n is less than -1, return n+1
    #interval (-infinite, -1), -1 not included
    if n < -1:
        return n+1
    #if n is bigger than 1
    #interval (1, infinite), 1 not included
    elif n > 1:
        return 6/(n+1)
    #it means that n is between -1 and 1 
    #interval [-1, 1], both -1 and 1 are included
    else:
        return (n+1)/(1+ (n*n))

def bigger(a, b):
    one = f(a)
    two = f(b)

    if one > two:
        return one
    else:
        return two


print(bigger(f(a), f(b)))
