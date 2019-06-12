array = [3,7,4,9,12,6,1,11,2,10]

def create(array):
    big = max(array)

    arr = []
    for i in range(0, big+1):
        arr.append(0)

    return arr

def find(array, dummy):
    for i in range(0, len(array)):
        value = array[i]
        dummy[value] +=1

def missing(array):
    for i in range(0, len(array)):
        if array[i] == 0:
            print("missing number ", i)

dummy = create(array)
print(array)
print(dummy)
find(array,dummy)
print(dummy)
missing(dummy)

