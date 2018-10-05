def first(num):
    copy = str(num)

    return copy[0]

def bla(num):
    res = 0
    while num != 0:
        res = num % 10
        num = num // 10
    return res

print(bla(54946516))
print(first(54946516))