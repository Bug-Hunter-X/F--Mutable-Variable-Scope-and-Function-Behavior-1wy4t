let x = 10
let y = 20
let z = 30

let add x y = x + y

let result1 = add x y
printfn "%d" result1 // Output: 30

// We create new variables to reflect updates without changing the original values or needing mutability.
let x2 = 15
let y2 = 25

let result2 = add x2 y2
printfn "%d" result2 // Output: 40

// Or avoid mutability altogether if possible, for improved predictability
let result3 = add z y
printfn "%d" result3 //Output: 50