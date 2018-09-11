def happyNumbers(number):

    #helper function to calculate the sum of each squared digit from the number param
    def h(nr):
        copy = str(nr)
        final = 0
        for item in copy:
            final += pow(int(item), 2)
            #print(pow(int(item), 2))

        return final

    #this is the list of all the numbers already calculated
    lstOfNumbers = []

    #this is the list with the happy numbers
    finalList = []
    for index in range(1, number+1):
        #calling the helper function
        result = h(index)

        #if the result is not 1
        while result != 1:
            #check to see if the current result is already in the list
            if result in lstOfNumbers:
                #if it is, clear the list and the current index is not a happy number
                #and break the execution of the while loop
                print("not a happy number", index)
                lstOfNumbers = []
                break
            #append the current result to the list of already calculated numbers
            lstOfNumbers.append(result)
            #recall the helper function with a new parameter
            result = h(result)
        
        #if the result is 1, then that index is a happy number
        if result == 1:
            #lstOfNumbers.append(index)
            print("happy number", index)
            lstOfNumbers = []
            finalList.append(index)
    return finalList

print(happyNumbers(50))
