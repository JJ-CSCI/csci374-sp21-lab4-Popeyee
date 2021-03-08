module Assignment

// Problem 1
let rec prod (lst:int list) =
    // write your solution here
    if lst.IsEmpty
    then 1
    else lst.Head  * prod lst.Tail

// Problem 2
let rec map f (lst:int list) =
    // write your solution here
    []
    // if lst.IsEmpty
    // then 0
    // else f.Head :: map f.Tail lst +1

// Problem 3
let rec odd (lst:int list) =
    // write your solution here
    lst
    // if lst.IsEmpty
    // then 1
    // else if lst.Head / 2 
    // then 1
    // else lst.Head  * odd lst.Tail

// Problem 4
let rec filter f lst =
    // write your solution here
    lst
