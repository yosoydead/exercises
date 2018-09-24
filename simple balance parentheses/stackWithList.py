'''
    The stack abstract data type is defined by the following structure and operations.
    It is an ordered collection of items where items are added to and removed from the end called the "top".
    Stacks are ordered LIFO -> last in, first out
    Operations:
        Stack() -> creates a new stack that is empty. It needs no params and returns an empty stack
        push(item) -> adds a new item to the top of the stack. It needs the item and returns nothing
        pop() -> remores the top item from the stack. It needs no param and returns the item. The stack is modified.
        peek() -> return the top item from the stack but does not remove it. It needs no param. The stack is not modified.
        isEmpty() -> tests to see wheter the stack is empty. It needs no param and returns a boolean value.
        size() -> returns the number of items on the stack. It needs no params and returns an integer.
    This will be an implementation using the list data structure from python. Later I'll implement the linked list one.
'''

class Stack:
    #constructor
    def __init__(self):
        #create and empty list to store the items
        self.items = []

    def isEmpty(self):
        #chech to see if the stack is empty or not. return a bool
        return self.items == []
    
    '''
        if the top of the stack is at the beginning
        def push(self, item):
            self.items.insert(0, item)
            #inserts at the specified index the item.
    '''
    
    #this method applies only if we choose that the top of the stack is at the end
    def push(self, data):
        #just add an item to the stack. the elements are added one after another
        #ex: 1 -> 2 -> 3 etc
        self.items.append(data)


    '''
        if the top of the stack is at the beginning
        def pop(self):
            return self.items.pop(0)
            #pop at the 0 index
    '''
    #this method applies only if we choose that the top of the stack is at the end
    def pop(self):
        #remove the last element. the default index of the pop function on a list is -1 IE. the last element
        return self.items.pop()
    

    '''
        if the top of the stack is at the beginning
        def peek(self):
            return self.items[0]
    '''
    #this method applies only if we choose that the top of the stack is at the end
    def peek(self):
        #return the last element of the stack
        return self.items[ len(self.items) -1]

    def size(self):
        return len(self.items)



    