* Given a sorted array, insert a number into its correct position in that array
* When the place of that given number is found, every number after it should be shifted one place to the right
    * Because we know we need to shift elements, a good idea would be to start a loop from the **END** of the array and start shifting from there. It can also reduce the number of shifts needed
* Steps should be the following:
    * initialize a variable with the size of the given array -1
    * start a loop from the end of the given array and compare the element at position *i* with the element i want to insert
    * if the current number is creater than my number, shift it's position IE at *i+1*
* Ex:
    * array = [4,8,13,16,20,25,28,33]
    * number = 18
