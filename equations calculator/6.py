"""
    another way of checking if the number is a palindrome without converting the number into a string
    this variation modifies the input
    def pal(n):
        copy = n
        result = 0
        while copy != 0:
            result = (result * 10) + (copy % 10)
        
        return result == n

    it returns true if the result number is = input
"""

#test if the number is a palindrome
def pal(n):
    string = str(n)
    low = 0
    high = len(string) -1

    while low < high:
        if string[low] != string[high]:
            return False
        low += 1
        high -=1
    return True

def iter(m, n):
    for i in range(m, n):
        if pal(i) == True:
            print(i, "is a palindrome")

iter(10,203)