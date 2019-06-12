* This solution works for an unsorted array with multiple missing elements
* First thing to do, scan through the array and find the biggest number. Using this number, create a new array of that size and initialize its members with 0
* Second, scan through the given array one more time and for each value, go to that index in the newly created array and change its to 1. At the end, indeces that have a value of 0 are the missing elements from the list
