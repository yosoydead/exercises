#the first solution is to print the duplicate every single time it is found
def findDup(array):
    for i in range(0, len(array) -1):
        if array[i] == array[i+1]:
            print(f"duplicate found is {array[i]}")


#this solution uses a variable to store the last duplicate found
def findDup2(array):
    currentDup = 0

    for i in range(0, len(array) - 1):
        if array[i] == array[i+1]:
            if array[i] != currentDup:
                print(f"duplicate found is {array[i]}")
                currentDup = array[i]

#this solution uses a hashing table
def findDup3(array):
    biggestNumber = max(array) +1

    hashTable = [0] * biggestNumber
    
    #for each item in the array param, i use the value at index i
    #and increment in the hashtable the index at the value of the param array
    #example: array[i] = 3 -> go hashtable[3] ++

    for i in range(0, len(array)):
        currentNumber = array[i]
        hashTable[currentNumber] += 1

    #to see which item is a duplicate and how many it occurs, scap the hashtable and prind
    for i in range(0, len(hashTable)):
        if hashTable[i] > 1:
            print(f"item {hashTable[i]} found {i} times")
    
array = [3,6,8,8,10,12,15,15,15,20]
findDup3(array)