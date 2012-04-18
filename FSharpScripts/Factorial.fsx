
// conditional syntax
let rec fact x =
    if x < 1 then 1
    else x * fact (x - 1)
 
// pattern matching syntax
let rec fact2 = function
    | n when n < 1 -> 1
    | n -> n * fact (n - 1)

printfn "%d" (fact 7)
printfn "%d" (fact2 7)
