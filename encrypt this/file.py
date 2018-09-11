
#string = "Hello world this is a sample text"
#string = "A wise old owl lived in an oak"
string = "The more he saw the less he spoke"

def x(string):
    result = ""
    #if the string is empty, return an empty string
    if string == "":
        return ""
    else:
        #split the string into an array containing each word as a separate value
        for item in string.split():
            wordsFirstLetter = ord(item[0])
            #if the word has only 2 letters, concat the first letter with the
            #second one and then append the word to result
            if len(item) == 2:
                currentWord = str(wordsFirstLetter) + item[1]
                print(currentWord)
                result += (currentWord + " ")
            #if the word is a single letter, append that letter to the result
            elif len(item) == 1:
                print(wordsFirstLetter)
                result += (wordsFirstLetter + " ")
            #if it has more than 2 letters, it means i have to store the second letter,
            #store the last one and the substring from the third letter up to the last letter
            #this makes it easy to create a word with the second and last letters swapped
            #and inbetween them to add the rest of the substring
            else:
                secondLetter = item[1]
                lastLetter = item[len(item)-1]
                theRest = item[2:len(item)-1]
                bla = str(wordsFirstLetter) + lastLetter + theRest + secondLetter
                print(bla)
                result += (bla+ " ")
        #i use the strip method to remove any leading or trailing whitespaces
        return result.strip()
        #    print(item)

print(x(string))