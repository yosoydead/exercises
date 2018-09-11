
#string = "Hello world this is a sample text"
#string = "A wise old owl lived in an oak"
string = "The more he saw the less he spoke"

def x(string):
    result = ""
    if string == "":
        return ""
    else:
        for item in string.split():
            wordsFirstLetter = ord(item[0])
            if len(item) == 2:
                currentWord = str(wordsFirstLetter) + item[1]
                print(currentWord)
                result += (currentWord + " ")
            elif len(item) == 1:
                print(wordsFirstLetter)
                result += (wordsFirstLetter + " ")
            else:
                secondLetter = item[1]
                lastLetter = item[len(item)-1]
                theRest = item[2:len(item)-1]
                bla = str(wordsFirstLetter) + lastLetter + theRest + secondLetter
                print(bla)
                result += (bla+ " ")
        return result.strip()
        #    print(item)

print(x(string))