#this is not the best solution but it gets the job done
#the down side is that i sort both arrays and i traverse the first array
#comparing values with the second array at the given indexes until i find the missing element

def bla(array1, array2):
    array1.sort()
    array2.sort()

    for index in range(0, len(array1) -1):
        if array1[index] != array2[index]:
            return array1[index]

array1 = [1, 2, 3, 4, 5, 6, 7]
array2 = [3, 7, 2, 1, 4, 6]
print(bla(array1,array2))