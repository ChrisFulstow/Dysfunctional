
// add a list of numbers, imperative style
let sumList list =
    let mutable acc = 0
    for i in list do
        acc <- acc + i
    acc

sumList [1; 2; 3; 4]

// add a list of numbers, functional style
let rec sumListF list =
    match list with
    | [] -> 0
    | h::t -> h + sumListF t

// add a list of numbers, functional style, with matching shorthand
let rec sumListF2 = function
    | [] -> 0
    | h::t -> h + sumListF2 t

sumListF2 [1;2;3;4;5]
