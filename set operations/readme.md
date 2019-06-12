* Theory: https://en.wikipedia.org/wiki/Union_(set_theory)
* By performing union on two arrays, a third one will be created and will store **all** the elements from the two sets. Duplicates will **not** be added.
    - If the sets are not sorted and after adding all the elements from the first set we have to perform a search on every element of the second set to see if it is or it is not in the result set.
    - By searching for every element from the second set into the resulting set, the time complexity of the operation could become **O(n^2)**.
    - If the two sets are sorted we can use the merging procedure. This means that we compare one index from the two sets and we add the smallest one into the resulting set. If the two indeces are equal, add its value only one time and increment both indeces further. At the end of the first loop, one of the sets will still have some elements that were not added.
    - Using the merging operation, the time complexity would become **O(m+n)**

* Theory: https://en.wikipedia.org/wiki/Intersection_(set_theory)
* We have to take **common** elements from the two sets and copy them into a new set.
    - We could apply the same solutions as for the union.

* Theory: https://en.wikipedia.org/wiki/Complement_(set_theory)
* We want all the elements from the first set copied that are **not** in the second set.
    - The same solutions could be applied from the union set.

* **In C like programming languages, a certain length for the resulting set should be calculated.**