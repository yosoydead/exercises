bla = ord('L')
print(bla)

res = ""
while bla != 0:
    #print(bla%16)
    x = bla % 16
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
    bla = bla // 16

print(res)