#this function will take care of putting each item in its correct place
def correctArray(array):
    i = 0
    j = len(array)-1

    while i < j:

        #the first loop checks to see if the number at the given index is positive
        while array[i] < 0:
            i += 1
        
        #the second loop checks to see if the number at the given index is negative
        while array[j] > 0:
            j -= 1

        #the swap should only take place if the first index is smaller than the second index
        if i < j:
            swap(array, i, j)

#this function just swaps two items in the same array
def swap(array, firstIndex, secondIndex):
    temp = array[firstIndex]
    array[firstIndex] = array[secondIndex]
    array[secondIndex] = temp

#in this array, the negative numbers should be on the left side
array = [-6, 3, -8, 10, 5, -7, -9, 12, -4, 2]
print(array)

correctArray(array)
print(array)
