"""
    or gcd(a,b):
        while(a != b):
            if m > n:
                m -= n
            else:
                n -=m
        return m

    The least common multiple of two numbers can be determined by multiplying the two numbers together
    and dividing the resulting number by the GCD of the two numbers
"""
def gcd(a, b):
    if b == 0:
        return a
    else:
        return gcd(b, a % b)

def lcm(a,b):
    mul = a * b
    divisor = gcd(a,b)

    return mul // divisor

print(gcd(18, 48))
print(lcm(18,48))