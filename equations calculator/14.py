#ill use a hardcoded array
array = [272, 190, 304, 200, 195, 169, 265, 112, 66, 489, 19, 399, 25, 321, 286, 264, 208, 267, 14, 73, 325, 298, 223, 269, 236, 46, 442, 10, 365, 255, 188, 247, 118, 283, 18, 155, 69, 214, 355, 44]

def s(array):
    result = 0
    for item in array:
        result = result + item
    print(result%10)
    print(pow(array[0], array[0]+1))

