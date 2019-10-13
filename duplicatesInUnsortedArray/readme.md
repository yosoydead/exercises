* Given an unsorted array, find the duplicate values
* One solution would be to search the entire array for each item at a given index. For each duplicate found, set its value to -1 so it wont be counted again later. This is **bad** because it takes **O(n^2)** time
* Another solution would be to use a hashtable (frequency counter)