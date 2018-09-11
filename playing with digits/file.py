#the main function
def bla(number, start):

    #this is the inner function
    #it made it easier for me to execute the calculations
    #this way i don't modify either parameter given
    def inner():
        #for ease of use, i converted the number param into a string to iterate
        #over it one character at a time
        backUp = str(number)
        result = 0
        #this is a way for me to increase the step parameter
        #starting at the value of start and increase its value by 1 every time
        #the loop executes
        step = start

        for item in backUp:
            #print(pow(int(item), step))
            #calculate the result of the current digit to the power of the current step
            result += pow(int(item), step)
            #increase the step variable at each loop execution
            step += 1
            #print(item)
        #just returning the total of each digit of the number param raised to the step added together
        return result

    #save the result returned by the inner function
    item = inner()

    if item % number == 0:
        return item // number
    else:
        return -1


#returns 51
print(bla(46288, 3))