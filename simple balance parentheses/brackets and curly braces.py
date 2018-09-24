'''
    Balanced:
        { { ( [] [] ) } () }
        [ [ { { ( () ) } } ] ]
        [] [] [] () {}
    Unbalanced:
        ( [) ]
        ( ( () ] ) )
        [ { () ]

    Each opening symbol is simply pushed on the stack to wait for the matching closing symbol to appear later in the sequence.
    When a closing symbol does appear, the only difference is that we must check to be sure that it correctly matches the type
        of the opening symbol on the top of the stack. If two symbols don't match, the string is unbalanced.
'''
import stackWithList

#check to see if the index in the opens symbols of the first param is == to the index of the second param in the closes symbols 
def matches(first, second):
    opens = "([{"
    closes = ")]}"
    return opens.index(first) == closes.index(second)

def checker(string):
    stack = stackWithList.Stack()
    balanced = True
    index =0

    while index < len(string) and (balanced == True):
        symbol = string[index]

        #now i check to see if the current symbol is of type ( or { or [
        #push onto the stack if it is
        if symbol in "([{":
            stack.push(symbol)
        #if it is not
        else:
            #you can't pop the stack if it is empty already
            if stack.isEmpty():
                balanced = False
            else:
                #store the top element of the stack
                top = stack.pop()
                if matches(top, symbol) == False:
                    balanced = False
        index += 1
    
    if balanced and stack.isEmpty():
        return True
    else:
        return False
    
print(checker("[{()}]"))

    