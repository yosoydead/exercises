# class Converter():
#     @staticmethod
#     def to_ascii(h):
#         #your code here
#     @staticmethod
#     def to_hex(s):
#         #your code here
#string = "Look mom, no hands"
string = "Javascript is for wannabees"

#converts string to hexa
def convert(string):
    result = ""
    #iterate over every single character in the string
    for item in string:
        #store the current chars ascii value
        currentChar = ord(item)
        #store the inner result
        res = ""
        #do the hexadecimal conversion
        while currentChar != 0:
            #print(bla%16)
            #if the remainder of the division has a certain value, do something
            x = currentChar % 16
            if x == 10:
                res = 'a' + res
            elif x == 11:
                res = 'b' + res
            elif x == 12:
                res = 'c' + res
            elif x == 13:
                res = 'd' + res
            elif x == 14:
                res = 'e' + res
            elif x == 15:
                res = 'f' + res
            else:
                res = str(x) + res
            #update the ascii value of the current character so it will be fully converted to hexa
            currentChar = currentChar // 16
        #print(res, item)
        #add the inner result to the big result
        result += res
        #clear the inner result for the next hexa value
        res = ""
    return result

#a simple method that splits the string byte by byte
#made it for me to be easier to convert from hex back to ascii
def splitHexString(hx):
    #in this list i store every hex value of each character in the string
    lst = []
    #x is the current hex value
    x = ""
    for item in hx:
        #if it contains two characters it means that it has to be stored
        #and reinit it to nothing
        if len(x) == 2:
            #print(x, end = " ")
            lst.append(x)
            x = ""
            #i add the current item so i don't lose it after i reinit x and the next loop starts
            x += item
        else:
            x += item
        #count +=1
    lst.append(x)
    return lst


def fromHexToDecimal(hx):
    powers = len(hx)-1
    result = 0

    for item in hx:
        if item.isdigit():
            result += ( int(item) * pow(16, powers))
            powers -= 1
        else:
            if item == 'a':
                result += (10 * pow(16, powers))
            elif item == 'b':
                result += (11 * pow(16, powers))
            elif item == 'c':
                result += (12 * pow(16, powers))
            elif item == 'd':
                result += (13 * pow(16, powers))
            elif item == 'e':
                result += (14 * pow(16, powers))
            elif item == 'f':
                result += (15 * pow(16, powers))
            powers -= 1
    return result


def textFromHex(hxList):
    result = ""
    #reading every single char from the sliced hex string
    #convert every value to ascii and concat them together
    for item in hxList:
        letter = chr(fromHexToDecimal(item))
        result += letter
        #print(fromHexToDecimal(item))
    return result


bla = convert(string)
print(bla)
a = splitHexString(bla)
print(textFromHex(a))
#print(splitHexString(bla))
# print(bla)
# print(splitHexString(bla))
#textFromHex(splitHexString(bla))

#hex string: 4a61766173637269707420697320666f722077616e6e6162656573
#string output: Javascript is for wannabees