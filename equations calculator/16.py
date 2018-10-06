def prime(n):
    for i in range(2, n):
        if n % i == 0:
            return False
    return True

def show(start,finish):
    for i in range(start, finish+1):
        if prime(i) == True:
            print(i)


show(2, 100)
