import random as rng

coin = 0.25


def mac():
    lst = []
    helmets = False
    spent = 0
    times = 0

    while helmets != True:
        x = rng.randint(1, 28)

        if x not in lst:
            lst.append(x)
            spent += coin
            times += 1
        else:
            spent += coin
            times += 1
            #print("helm", str(x), "already in list")
        if len(lst) == 28:
            helmets = True
    print("you've spent", str(spent), "dollars and tried", str(times),"times to get all the helmets.")
    return spent

mac()
