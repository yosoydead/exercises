def beeramid(bonus, price):
    #if the bonus is 0 or less it is obvious we can't buy any beer
    if bonus == 0 or bonus < 0:
        return 0
    
    #i use double / because i want the number to be an int not a float
    numberOfBeers = bonus // price

    beersUsed = 0

    #i can't start with row = 0 because that screws up my calculations
    rowNumber = 1

    while beersUsed < numberOfBeers:
        #need to add 1 beer to the piramid because the first row contains only one can of beer
        if rowNumber == 1:
            beersUsed += 1
            rowNumber += 1
        else:
            #i compute the number of beers for the given row
            #i discovered this formula by playing with the numbers on a sheet of paper
            #again, i use // to give me an int
            result = (rowNumber * (2*rowNumber)) // 2

            #i can't add up another row if my current beer count + the result
            #exceeds the number of beer cans i can afford
            # + another row can't be made of a number of cans smaller than the last one
            if result + beersUsed > numberOfBeers:
                #i return rows-1 because i already start with row = 1
                return rowNumber - 1
            else:
                beersUsed += result
                rowNumber += 1

    #i return rows-1 because i already start with row = 1
    return rowNumber-1

print(beeramid(5000, 3))