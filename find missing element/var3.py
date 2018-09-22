#this would be a more optimal solution
#i concatinate both array and i use the xor operator

def bla(array1, array2):
    result = 0
    for item in (array1 + array2):
        result ^= item

    return result

array1 = [1, 2, 3, 4, 5, 6, 7]
array2 = [3, 7, 2, 1, 4, 6]
print(bla(array1,array2))