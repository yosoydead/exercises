# class Converter():
#     @staticmethod
#     def to_ascii(h):
#         #your code here
#     @staticmethod
#     def to_hex(s):
#         #your code here
#string = "Look mom, no hands"
string = "Javascript is for wannabees"


def convert(string):
    result = ""
    for item in string:
        currentChar = ord(item)
        res = ""
        while currentChar != 0:
            #print(bla%16)
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
            currentChar = currentChar // 16
        #print(res, item)
        result += res
        res = ""
    return result

def splitHexString(hx):
    lst = []
    x = ""
    for item in hx:
        if len(x) == 2:
            #print(x, end = " ")
            lst.append(x)
            x = ""
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