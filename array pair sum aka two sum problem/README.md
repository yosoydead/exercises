The challenge is to find all the pairs of two integers in an unsorted array that sum up to a given S.
For example, if array is [3,5,2,-4,8,11] and the sum is 7, your program should return [11,-4], [2,5] because 11+ -4 = 7 and 2+5 = 7.

array = [1,3,2,2,0,4,-1,5]
brute force -> result [[1, 3], [3, 1], [2, 2], [2, 2], [2, 2], [2, 2], [0, 4], [4, 0], [-1, 5]]
slightly better -> result [[-1, 5], [0, 4], [1, 3], [2, 2]]
weird solution -> result [[3, 1], [1, 3], [2, 2], [2, 2], [4, 0], [0, 4], [5, -1]]
