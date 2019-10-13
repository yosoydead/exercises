def perm(array, k):
    a = [0] * len(array)
    res = [0] * len(array)

    def p(array, k):
        if k == len(array):
            print(res)
        else:
            for i in range(0, len(array)):
                if a[i] == 0:
                    res[k] = array[i]
                    a[i] = 1
                    p(array, k+1)
                    a[i] = 0

    p(array, k)

array = ['a', 'b', 'c']
perm(array, 0)