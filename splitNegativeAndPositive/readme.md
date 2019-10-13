* Given an array which has both positive and negative number, make it so that all the negative elements are on the left side of the array and the positive numbers are on the right side of the array
* Pseudo code (kind of):
    * have two variables. One stores the first index in the array. The second one stores the last index in the array
    * run a loop on the first index until the item at that index is positive **(increment the index)**
    * after the first loop, run a second loop until the item at that index is negative **(decrement the index)**
    * after both loops have finished, swap the values between the first and the second index. **The swap should be performed only if the first index is smaller than the second index**
    * this procedure should be repeated until either index passes by the second one