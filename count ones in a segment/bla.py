#this solution may not be the best but it gets the job done. seems to timeout on the site

#convert any decimal number into a binary number
def toBin(number):
    #im returning the binary number as a string for ease of use later down the road
    res = ""
    while number != 0:
        current = number % 2
        #yes. it doesn't return the reversed value.
        #it returns what it should return
        res = str(current) + res
        number = number // 2
    return res

#count the ones from the binary string
def countOnes(bin):
    count = 0
    for item in bin:
        if int(item) == 1:
            count +=1
    return count


def fromRange(left, right):
    result = 0
    for item in range(left, right +1):
        nr = toBin(item)
        result += countOnes(nr)
    return result

print(fromRange(12,29))