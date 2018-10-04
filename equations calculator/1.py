#i wont read n. ill give it a hardcoded value
n = 7

#first equation
def E1(n):
    #start with a result value to be returned by the function
    result = 0

    #with a for loop, start from index 1 because 1/1 = 1 and that's the first number from the equation
    #also, go to n+1 so that the loop calculates the value for n
    for i in range(1, n+1):
        result = result + 1/i
    
    return result

#second equation
def E2(n):
    #because i have a function that calculates the first function, it means i can use it to store
    #a value
    x = E1(n)

    #because the second equation is the first equation to the power of 2, i can return a number
    #equal to the stored value of the first function multiplied by itself
    return x * x

print(E1(n))
print(E2(n))



