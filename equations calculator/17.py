def sumDigit(n):
    res = 0
    while n != 0:
        res = res + (n%10)
        n = n //10
    return res

def afis(start, finish):
    for i in range(start, finish +1):
        if i % sumDigit(i) == 0:
            print(i)

afis(1, 30)