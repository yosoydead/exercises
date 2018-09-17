def beers(referal, price):
    return referal//price

#print("beers", beers(1500,2))
totalBeers = beers(21,1.5)
print("total beers", totalBeers)
current = 0
rowNumber = 1

while current < totalBeers:
    if rowNumber == 1:
        current += 1
        rowNumber+= 1
    else:
        result = (rowNumber* (2*rowNumber))//2
        if result + current > totalBeers:
            break
        else:
            current += result
            rowNumber += 1
print("randuri",rowNumber-1)
# total = 0
# for item in range(1,17):
#     if item == 1:
#         total += 1
#         #print(item)
#     else:
#         result = (item *(2*item))//2
#         #print(result)
#         total += result
