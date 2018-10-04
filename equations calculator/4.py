"""
Tips:
    We already know how to calculate the greatest common divisor.
    For an array, first, we calculate the gcd of the first two numbers and store it into a new variable.
    After that, for each element in the array, calculate gcd between the new variable and the
        current element. Update the value of the stored gcd value
"""

#array = [50, 52, 43, 93, 21, 76, 22, 70, 57, 58, 83, 75, 53, 56, 17, 49, 1, 99, 79, 27, 69, 48, 10, 78, 25, 80, 16, 7, 62, 88]
array = [77, 15, 84, 94, 14, 28, 33, 2, 79, 31, 59, 88, 63, 40, 39, 53, 11, 7, 49, 26, 30, 65, 43, 56, 70, 38, 55, 23, 76, 18]
def gcd(a, b):
    if b == 0:
        return a
    else:
        return gcd(b, a % b)

#i assume that the array has more than 2 elements
def final(array):
    first = array[0]
    second = array[1]

    c = gcd(first,second)

    for i in range(2, len(array)):
        current = gcd(c, array[i])
        c = current

    return c

print(final(array))