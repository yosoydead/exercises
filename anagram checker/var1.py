
#var 1
#in this var im adding the ascii value of every char in each string
#if the sums are equal then the strings are anagram
#also, i made this function case insensitive
def anagram(string1, string2):
    #if the strings are not of the same length after replacing every white space
    #with nothing then return false, they are not anagrams
    if len(string1.lower().replace(" ", "")) != len(string2.lower().replace(" ", "")):
        return False
    
    #storing the sum for each string
    sum1 = 0
    sum2 = 0

    for item in string1.lower():
        if item != " ":
            sum1 += ord(item)

    for item in string2.lower():
        if item != " ":
            sum2 += ord(item)

    return sum1 == sum2

    
#true
print(anagram("Madam Curie", "Radium came"))