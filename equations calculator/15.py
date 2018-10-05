import random as rng
#ill create a function that returns a 2D array. i dont want to bother with input validation

def create(m, n):
    result = []

    for i in range(0, m):
        current = []
        for j in range(0, n):
            number = rng.randint(1,300)
            current.append(number)
        result.append(current)
        current = []

    return result

def printMatrix(array):
    for i in range(0, len(array)):
        for j in range(0, len(array[i])):
            print(array[i][j], end=" ")
        print("")

def adding(array1, array2):
    result = []
    for i in range(0, len(array1)):
        current = []
        for j in range(0, len(array1[i])):
            nr = array1[i][j] + array2[i][j]
            current.append(nr)
        result.append(current)
        current= []
    return result

m = 3
n = 5
array = create(m, n)
array2 = create(m, n)
added = adding(array, array2)
printMatrix(array)
print("--------------------------------------------------------")
printMatrix(array2)
print("--------------------------------------------------------")
printMatrix(added)
print("--------------------------------------------------------")