let mutable x = 10
let mutable y = 20
let mutable z = 30

let add x y = x + y

let result1 = add x y
printfn "%d" result1 // Output: 30

x <- 15
y <- 25

let result2 = add x y
printfn "%d" result2 // Output: 40

// This will cause a compiler error because z is mutable and is not used in the add function.
// let result3 = add z y // Compiler error