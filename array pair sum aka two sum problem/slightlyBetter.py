#this solution runs in n logn
#for this solution to work i need to sort the array. if the problem requests that the array must not be altered
#i can use a copy array and sort it
#if the problem states that i need to return the indexes of the numbers that can make the given sum,
#then this solution is invalid
#this solution returns duplicates only if the array contains duplicate values

def bla(array, sum):
    copy = array.copy()
    #sort the copy array so the param doesn't change
    copy.sort()

    result = []

    #now, because the array is sorted, i can traverse it from 2 points
    #one index is at the start, the other is at the end of the array
    low = 0 
    high = len(copy) -1

    while low < high:
        current = copy[low] + copy[high]

        #if the current indexes add to the given sum, they can be added to the final result list
        #then, both the low and high index need to move one position so the algorithm continues
        if current == sum:
            result.append([copy[low], copy[high]])
            low += 1
            high -= 1
        #if the current sum is bigger than the given sum, this means that the higher index needs to
        #move one position so that the current sum can have a lower value
        elif current > sum:
            high -= 1
        #if the current sum is lower than the given sum, this means that the number at the low index
        #is too small, so the low index needs to move so that the next number can be == or bigger than
        #the given sum
        elif current < sum:
            low += 1
    return result

#array = [-80, 14, -57, -24, 20, 11, -86, -96, 43, 69, 100, -98, 87, -39, 85, -73, -58, -77, 34, -45]
array = [1,3,2,2,0,4,-1,5]
#print(bla(array, 27))
print(bla(array, 4))
#result [[-1, 5], [0, 4], [1, 3], [2, 2]]
