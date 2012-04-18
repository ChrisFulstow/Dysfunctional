
let timesTwo x = x * 2
timesTwo 123
    
// 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10
let rec sumNums nfrom nto =
    if nfrom > nto then 0
    else nfrom + (sumNums (nfrom + 1) nto)

// 1 * 2 * 3 * 4 * 5 * 6 * 7 * 8 * 9 * 10
let rec productNums nfrom nto =
    if nfrom > nto then 1
    else nfrom * (productNums (nfrom + 1) nto)

// general case
let rec aggregate seed fn nfrom nto =
    if nfrom > nto then seed
    else fn nfrom (aggregate seed fn (nfrom + 1) nto)

sumNums 1 10
productNums 1 5

aggregate 0 (+) 1 10
aggregate 0 (fun x y -> x + y) 1 10

aggregate 1 (*) 1 10
aggregate 1 (fun x y -> x * y) 1 10
