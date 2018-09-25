'''
    A queue is an ordered collection of items where the addition of new items happens at one end, called the "rear",
        and the removal of existing items occurs at the other end, commonly called the "front". 
        As an element enters the queue it starts at the rear and makes its way towards the front,
        waiting until that time when it is the next element to be removed.
    This ordering principle is called FIFO -> first in first out.
    The queue operations are given below:
        queue() -> create a new queue that is empty. It needs no params and returns an empty queue
        enqueue(item) -> adds a new item to the rear of the queue. It needs the item and returns nothing
        dequeue() -> removes the front item from the queue. It needs no params and returns the item. The queue is modified
        isEmpty() -> tests to see whether the queue is empty. It needs no params and returns a bool
        size() -> returns the number of items in the queue. It needs no params and returns an int
    I will use the internal list in python first. I'll implement the linked list version later.
'''

#assume that the rear is at position 0 in the list. It allows the use of insert function on lists
#to add new elements to the rear of the queue. The pop operation can be used to remove the front element(last elem in queue)
#this means that enqueue will be O(n) and dequeue will be O(1)

class Queue:
    #constructor
    def __init__(self):
        self.items = []

    #check if the queue is empty
    def isEmpty(self):
        return self.items == []

    #add an item to the end
    def enqueue(self, item):
        #insert at index 0 an item
        self.items.insert(0, item)

    #dequeue
    def dequeue(self):
        return self.items.pop()

    def size(self):
        return len(self.items)

#checks
# q = Queue()

# q.enqueue("hi")
# q.enqueue("dog")
# q.enqueue(3)
# print(q.dequeue())
# q.enqueue(4)
# print(q.dequeue())
    