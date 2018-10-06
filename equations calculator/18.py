def inter(array1, array2):
    first = []
    second = []
    result = []
    if len(array1) > len(array2):
        first = array1
        second = array2
    else:
        first = array2
        second = array1

    i = 0
    j = 0

    while i< len(first) and j < len(second):
        if first[i] > second[j]:
            result.append(first[i])
            i+=1
        else:
            result.append(second[j])
            j+=1
    
    if i < len(first):
        for bla in range(i, len(first)):
            result.append(first[bla])
    else:
        for bla in range(j, len(second)):
            result.append(second[bla])
    return result

b = [95, 86, 23, 16, 7]
a = [85,81,48,33,25,24,15,10]

print(inter(a,b))
        

