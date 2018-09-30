#string = "SERR PBQR PNZC"
string = "GUR DHVPX OEBJA SBK WHZCF BIRE GUR YNML QBT."
result = ""

for item in string:
    if ord(item) >= 65 and ord(item) <= 77:
        result += chr( ord(item) + 13 )
    elif ord(item) >= 78 and ord(item) <= 90:
        result += chr( ord(item) -13)
    else:
        result += item

print(result)