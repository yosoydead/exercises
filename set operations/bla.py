array1 = [11,18,9,19,2,3,6,1,15,8,10, 13]
array2 = [ 6,11,13,17,14,20,2,19,12,4,16]

array1.sort()
array2.sort()
print("sorted ", array1)
print("sorted", array2)

def union(arr1, arr2):
    i = 0
    j = 0

    result = []

    while i < len(arr1) and j < len(arr2):
        #if the first element is smaller than the second one, copy the first one
        #increment the index
        if arr1[i] < arr2[j]:
            result.append(arr1[i])
            i += 1
        #if the second element is smaller than the first one, copy the second one
        #increment the index
        elif arr2[j] < arr1[i]:
            result.append(arr2[j])
            j += 1
        #if both values are equal, copy one of them and then increment BOTH indeces
        else:
            result.append(arr1[i])
            i += 1
            j += 1

    #after the while loop is finished, one array will have at least 1 uncoppied element
    for x in range(i, len(arr1)):
        result.append(arr1[x])

    for x in range(j, len(arr2)):
        result.append(arr2[x])

    return result

def intersection(arr1, arr2):
    i = 0
    j = 0

    result = []

    #copy only elements that are equal
    while i < len(arr1) and j < len(arr2):
        if arr1[i] < arr2[j]:
            i+=1
        elif arr2[j] < arr1[i]:
            j+=1
        #this means that elements are equal
        else:
            result.append(arr1[i])
            i+=1
            j+=1
    
    return result

def difference(arr1, arr2):
    i = 0
    j = 0

    result = []

    #add only the elements from the first set that are not in the second set
    while i < len(arr1) and j < len(arr2):
        if(arr1[i] < arr2[j]):
            result.append(arr1[i])
            i += 1
        elif arr2[j] < arr1[i]:
            j+=1
        else:
            i += 1
            j += 1

    #copy the remaining elements from the first set if there are any leftovers
    for x in range(i, len(arr1)):
        result.append(arr1[i])

    return result

print(union(array1, array2))
print(intersection(array1, array2))
print(difference(array1, array2))