def isSorted(array):
    #the loop should run for the length of the array -1
    #because accessing a non-existent index throws an error    

    for i in range(0, len(array)-1):
        first = array[i]
        second = array[i+1]

        if first > second:
            return False
    
    #if the loop finishes its execution without problems, it means the array is sorted
    return True

array = [-4, 4, 8, 13, 16, 20, 25, 28, 33]

print(isSorted(array))
