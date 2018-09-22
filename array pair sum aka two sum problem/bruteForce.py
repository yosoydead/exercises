#this one is simple
#use 2 for loops and compare each element of the second loop with each element of the first loop 
#and see if the sum of the numbers is = param sum
#also, i return a list with all the posible elements
#this solution return duplicates

def bla(array, sum):
    #this will contain all the possible elements
    result = []

    #iterate over the given array up until the second to last element
    #i do this because if there already exists a number that added with the last element of the list
    #is = to the sum, then there is no point in adding it once more but in reverse order
    for i in range(0, len(array)-1):
        for j in range(0, len(array)):
            if array[i] + array[j] == sum:
                result.append([array[i], array[j]])
    
    return result



#array = [-80, 14, -57, -24, 20, 11, -86, -96, 43, 69, 100, -98, 87, -39, 85, -73, -58, -77, 34, -45]
array = [1,3,2,2,0,4,-1,5]
#print(bla(array, 27))
print(bla(array, 4))
#result [[1, 3], [3, 1], [2, 2], [2, 2], [2, 2], [2, 2], [0, 4], [4, 0], [-1, 5]]