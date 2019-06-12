array = [1,2,3,4,5,6,8,9,10,11,12]
array2 = [6,7,8,9,10,11,13,14,15,16,17]

def findSum(arr):
    result = 0

    for i in range(0, len(arr)):
        result += arr[i]

    return result

def formula(arr):
    last = arr[len(arr)-1]

    result = (last*(last+1))//2

    return result

#if there is only one missing element in the list, return once it is found
#if there are multiple missing elements in the sequence, store them, then return or print
def findMiss(arr):
    #this is the difference desired for each iteration
    diff = arr[0] - 0

    for i in range(0, len(arr)):
        if arr[i] - i != diff:
            #found the missing element
            return i + diff
    
    return -1
    
totalSum = formula(array)
s = findSum(array)

#print(totalSum-s)
print(findMiss(array2))