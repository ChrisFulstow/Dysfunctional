
let add x y = x + y

let sign n =
    if n > 0 then "positive"
    elif n < 0 then "negative"
    else "zero"

printfn "Hello, string literal."
printfn "Print anything %A %A %A" 1 "string" true
printfn "Format as hex %X" 927
printfn "Format intergers %i %d" -99 99
printfn "Format function result 6 + 7 = %d" (add 6 7)
printfn "Signs %s %s %s" (sign 1) (sign 0) (sign -1)

