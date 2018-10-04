1. [x] 1) Read n as a natural number. Write a program that prints the value of the following equations:
```E1 = 1 + 1/2 + 1/3 + .... + 1/n```
```E2 = (1 + 1/2 + 1/3 + .... + 1/n)^2```
2. [x] 2) Consider the following function:
```
f(x) = (x+1) / (1+x^2), if x [-1, 1]  
        x + 1,         if x (-infinite, -1)  
        6 / (1+x),       if x (1, infinite)  
```     
Read two values a and b. Write a program that prints the bigger value between f(a) and f(b).   

3. [x] 3) Read two integers m and n. Print the greatest common divisor and the least common multiple of the two numbers.
4. [x] 4) Read an array of n elements. Write the greatest common divisor of all the elements in the array.
5. [x] 5) Read two integers > 0 and < 10. It is asked that your program prints a triangle following the rules you deduct from the example:
```
m = 7 
n = 9  
9  
1 2    
3 4 5  
6 7 8 9  
1 2 3 4 5  
6 7 8 9 1 2
3 4 5 6 7 8 9
```

6. [x] 6) Read two integers m < n. You have to print every number that is a palindrome between m and n.
7. [ ] 7) Read a number n <= 9999999. Calculate the sum of cubed digits in the number. Ex: if you read **25**, calculate **2^3 + 5^3 = 133**. Do the same with the result: **1^3 + 3^3 + 3^3 = 55**. Again **5^3 + 5^3 = 250**. Again **2^3 + 5^3 + 0^3 = 133**. Repeat the process until we optain a result that is already in the generated sequence. Print the values of the generated sequence. Ex: **n = 25** -> 25, 133, 55, 250, 133