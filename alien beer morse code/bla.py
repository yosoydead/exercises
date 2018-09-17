def bla(string):
    #i need a dictionary to hold the value of each morse digit
    myDict = {".----":1 , "..---": 2, "...--":3 , "....-":4 , ".....":5 , "-....": 6, "--...":7, "---..":8 , "----.": 9, "-----": 0}
    if string == "" or string == None:
        return ""

    #this will store 5 morse characters
    current = ""
    #this is a counter to know how many characters are in current
    index = 0

    #this is the final result
    result = ""

    #iterate over the string
    #another idea would have been to iterate through the string with 5 characters at a time
    for item in string:
        #it the index is 5
        if index == 5:
            #reset index
            index = 0
            #store the value of current
            digit = myDict[current]
            #add that value to result
            result =  result+str(digit)
            #reset current
            current = ""
            #add the current character so it doesn't get lost
            current = current + item
            #increase index
            index += 1
        else:
            #add to current
            current = current + item
            index += 1
    #after the loop is over, the last digit remains stored in current and doesn't get accessed
    result += str(myDict[current])
    #the problem wants the result to be an int
    return int(result)
    #print(myDict["....."])

#print(bla("..----------..."))
print(bla("----.--.....---...--"))