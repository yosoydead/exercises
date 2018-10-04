#m = number of rows to print
#n = the number with which to start counting
def show(m, n):
    #this is where the counting starts, IE n = 6, first line = 6, second = 7 8, third = 9 1 2, etc
    current = n
    #the first loop is for rows
    for i in range(0, m):
        #the second is for columns
        for j in range(0, m):
            #as long as the index of the column is < or = to the index of the rows print
            if j <= i:
                #if the counting var is < or = 9, just print it, with a space at the end
                #and increment the counting var
                if current <=9:
                    print(current, end=" ")
                    current += 1
                #if the counting var > 9
                else:
                    #reset its value
                    current = 1
                    #print the new value and the space at the end
                    print(current, end=" ")
                    #increment the value
                    current += 1
        print("")


show(6,1)
# for i in range(0,5):
#     for j in range(0,5):
#         if j <= i:
#             print("#", end='\t')
#     print("")