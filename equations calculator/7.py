def calc(n):
    copy = n
    result = 0
    while copy != 0:
        result = result + pow(copy%10,3)
        copy = copy // 10
    return result

def seq(n):
    array = []
    copy = n
    while True:
        if copy not in array:
            array.append(copy)
            current = calc(copy)
            copy = current
        else:
            array.append(copy)
            break
    return array

print(seq(25))