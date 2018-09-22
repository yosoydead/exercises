#i think you're freaky and i don't like you alot
#for this solution i use a hash set and i traverse the array only once
#it uses a bit more space because i need to store both the results and values in the hash set
#if i use a list to store the results, this will return duplicates
#if i don't want duplicates, then i would need to use a dictionary
def bla(array, sum):
    result = []
    
    #in the set, i will store some values
    x = set()

    for item in range(0, len(array)-1):
        #compute the difference between the given sum and the current element
        diff = sum - array[item]

        #ex: 1,3,2,2,0,4,-1,5
        #if the difference is not in the set, store it
        #so, diff = 4 - 1 => 3
        #3 is not in set, so add it
        if diff not in x:
            x.add(diff)

        #for the second iteration

        #diff = 4 - 3 => 1
        #so, 1+ 3 = 4
        #the difference 1 is already in the set, so i don't need to add it again
        #i just need to return the current difference + the current value
        #both would add to the given sum
        if diff in x:
            result.append([diff, array[item]])

    return result

#array = [-80, 14, -57, -24, 20, 11, -86, -96, 43, 69, 100, -98, 87, -39, 85, -73, -58, -77, 34, -45]
array = [1,3,2,2,0,4,-1,5]
#print(bla(array, 27))
print(bla(array, 4))
#result [[3, 1], [1, 3], [2, 2], [2, 2], [4, 0], [0, 4], [5, -1]]



