def findDup(array):
    #first of all, i need to know which is the largest element in the array
    biggestNumber = max(array)

    #create a hashtable with a size of the biggest number found +1
    hashTable = [0] * (biggestNumber+1)

    for i in range(0, len(array)):
        currentNumber = array[i]

        #now, go into the hashtable at the index that would be = to the current number
        #and increment that number by 1
        hashTable[currentNumber] += 1

    #after the first loop is finished, i can loop over the hashtable to see 
    #which elements are repeating
    for i in range(0, len(hashTable)):
        if hashTable[i] > 1:
            print(f"number {i} reoeated {hashTable[i]}")

array = [8,3,6,4,6,5,6,8,2,7]
findDup(array)