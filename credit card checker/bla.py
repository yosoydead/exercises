def validate(n):
    nr = str(n)
    if len(nr) == 1:
        return False

    total = 0

    if len(nr) % 2 == 0:
        for index in range(0, len(nr)):
            # if index == 0:
            #     total += int(nr[index]) * 2
            #     pass
            
            if index % 2 == 0:
                result = int(nr[index]) * 2
                if result > 10:
                    total += (result-9)
                else:
                    total += result
            else:
                total += int(nr[index])
    elif len(nr) % 2 != 0:
        for index in range(0, len(nr)):
            if index%2 != 0:
                r = int(nr[index]) * 2
                if r > 10:
                    total += r -9
                else:
                    total += r
            else:
                total+= int(nr[index])

    return total % 10 == 0

print(validate(2121))
