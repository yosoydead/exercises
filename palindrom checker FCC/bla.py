#string = "A man, a plan, a canal. Panama"
#string  = "almostomla"
string = "_eye"
def transform(string):
    result = ""
    for char in string:
        if ord(char) in range(48, 58) or ord(char) in range(65, 91) or ord(char) in range(97, 123):
            result += char.lower()
    return result

print(transform(string))

def check(string):
    lower = 0
    high = len(string) -1

    while lower < high:
        if string[lower] == string[high]:
            #print("lower", string[lower], "high", string[high])
            lower += 1
            high -= 1
        else:
            #print("lower", string[lower], "is not = high", string[high])
            return False
    return True

bla = transform(string)
print(check(bla))