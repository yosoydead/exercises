* This will be done on a sorted array
* If there is a sequence of the first n natural numbers, meaning each consecutive number is incremented by one, we can use the formula for the first n natural numbers.
    - (n*(n+1))/2 -> n will be equal to the last number in the give sequence
    - by knowing the sum of the elements in the sequence, calculate the sum of the elements from the array. Theyr difference is the missing element
* If the sequence is not the first n natural numbers:
    1. the index for each number could help:
        - take each value at that index and subtract the index
        - when the difference is bigger than the last before it, it means we found the missing number
        - to find the missing number, calculate the difference between value at index 0 and its index (being 0), store the index at which the difference is bigger than the stored one, add the difference and the index
        - ex: [6,7,8,9,10,11,13,14,15]
            - 6-0 = 6 -> **this difference should be the same if there are no missing elements in the array**
            - 7-1 = 6
            - 8-2 = 6 ...
            - 13-6 = 7 -> **store the index of this difference** 
            - add