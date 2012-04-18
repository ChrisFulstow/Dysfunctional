let sqr x = x * x

// procedural version
let sumOfSquaresP nums = 
    let mutable acc = 0
    for x in nums do
        acc <- acc + sqr x
    acc

// recursive version
let rec sumOfSquaresR nums = 
    match nums with
    | []    -> 0
    | h::t  -> sqr h + sumOfSquaresR t

// pipeline version
let sumOfSquaresF nums =
    nums
    |> Seq.map sqr
    |> Seq.sum

// build list
let s = [ 1.. 10 ]

printfn "sumOfSquaresF %A" (sumOfSquaresF s)
printfn "sumOfSquaresP %A" (sumOfSquaresP s)
printfn "sumOfSquaresR %A" (sumOfSquaresR s)
