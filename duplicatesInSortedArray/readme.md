* This algorithm should take a **sorted** array as a parameter and establish how many duplicates are in the given array
* One solution would be to compare the current item with the item next to it. This solution would print everytime a duplicate is found
* Another solution is to have a variable that keeps track of the last duplicate value found. If an item found is equal to the duplicate more than one time, the program should print the duplicate value only once
* A third solution would be to use a hashtable (or a frequency counter). That hashtable should be an array of size: the biggest number in the array + 1. Every item in the hashtable should be 0 at first
