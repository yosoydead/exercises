'''
    Observation: as you process symbols from left to right, the most recent opening parentheses must match
    the next closing symbol. Also, the first opening symbol processed may have to wait until the very last
    symbol for its match. Closing symbols match opening symbols in the reverse order of their appearance;
    they match from the inside out.

    Steps:
        1.start with an empty stack
        2. process the parentheses string from left to right
        3. if a symbol is an opening parenthesis, push it on the stack as a signal that a corresponding closing
            symbol needs to appear later
        4. if, on the other hand, a symbol is a closing parenthesis, pop the stack

    Obs.1. As long as it is possible to pop the stack to match every closing symbol, the parentheses remain balanced.
    Obs.2. If at any time there is no opening symbol on the stack to match a closing symbol, the string is not balanced
    properly. At the end of the string, the stack should be empty.
'''
import stackWithList

def checker(string):
    #step 1 -> create a stack
    stk = stackWithList.Stack()

    #a flag that says if the string is currently balanced
    balanced = True

    #the index in the string
    index = 0

    while index < len(string) and (balanced == True):
        #this is the current item in the input
        symbol = string[index]

        #step 2
        if symbol == '(':
            stk.push(symbol)
        #step 3
        else:
            #obs 2.
            if stk.isEmpty():
                #the string is not balanced and the loop will stop at the next execution
                balanced = False
            #the stack is not empty so the is a opening parenthesis to match this closing one
            else:
                stk.pop()
        
        #move to the next element in string
        index = index +1


    #after the loop is finished. we don't know yet if the string is balanced

    #if the balanced flag is true and the stack is empty at the end of the operation
    if (balanced == True) and (stk.isEmpty() == True):
        return True
    #if not, then the input is not balanced
    else:
        return False

#or an even better solution that doesn't use much space
def checker2(string):
    count = 0
    for item in string:
        if item == '(':
            count += 1
        if item == ')':
            count -= 1
        if count < 0:
            return False
    return count == 0
#true
print(checker2("((()))"))

#false
print(checker2("(()"))



