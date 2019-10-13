#copy all the elements from the first array into the second one
def copy(array1, array2):
    for i in range(0, len(array1)):
        array2[i] = array1[i]

#insert number into the array
#what i am doing here is, im taking both the original 
#and the copied array that has 1 more element in size
def insert(array, result, number):
    #index
    i = len(array)-1

    #start a loop from the end of the array
    #when the number at index i from the original array is >= number
        #it means that in the result array, the number at index i
        #should be shifted one position to the right
    while array[i] >= number:
        result[i+1] = array[i]
        i -= 1
    
    result[i+1] = number

#i want to insert a number into this sorted array
array = [4,8,13,16,20,25,28,33]

#this number i want to be inserted into the array
number = 18

#also, i can use a new array so it includes all numbers and the new one
result = [0] * (len(array)+1)
copy(array, result)
insert(array, result, number)

#index i
i = len(array) - 1

print(array)
print(result)