#in this solution i don't sort anything but i traverse both array
#i sum up all the values from the first array
#i sum up all the values from the second array
#their difference should be the missing term

def bla(array1, array2):
    sum1 = 0
    sum2 = 0

    for item in array1:
        sum1 += item
    
    for item in array2:
        sum2 += item

    return sum1 - sum2

array1 = [1, 2, 3, 4, 5, 6, 7]
array2 = [3, 7, 2, 1, 4, 6]
print(bla(array1,array2))