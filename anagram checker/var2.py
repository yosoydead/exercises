#this var is also case insensitive
#this time im using a list to store chars from the first string
def anagram(string1, string2):
    string1 = string1.lower().replace(" ", "")
    string2 = string2.lower().replace(" ", "")

    if len(string1) != len(string2):
        return False

    lst = []

    for item in string1:
        lst.append(item)

    for item in string2:
        if item in lst:
            lst.remove(item)

    return len(lst) == 0

#false
print(anagram("Madam Curie", "Radium caeme"))