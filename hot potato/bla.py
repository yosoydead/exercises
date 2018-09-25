#ill use a queue implemented using the internal list in python
import queueWithList

def potato(nameList, num):
    queue = queueWithList.Queue()

    #add all the children from the list in the "circle"
    for item in nameList:
        queue.enqueue(item)

    while queue.size() > 1:
        for i in range(num):
            #move the child at the beginning of the queue to the end
            queue.enqueue(queue.dequeue())
        queue.dequeue()

    return queue.dequeue()


nameList = ["bill", "david", "susan", "jane", "kent", "brad"]
num = 7

print(potato(nameList, num))

    