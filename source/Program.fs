// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open System;

[<EntryPoint>]
let main argv = 

    let fizzMe = [ 1  .. 100 ]

    let fizzbuzz number = 
        match number with 
        | (number) when number % 15 = 0 -> Console.WriteLine(number.ToString() + ": FizzBuzz")
        | (number) when number % 3 = 0 -> Console.WriteLine(number.ToString() + "Fizz")
        | (number) when number % 5 = 0 -> Console.WriteLine(number.ToString() + "Buzz")
        | _ -> Console.WriteLine(number.ToString())

    let fizzbuzz2 number = 
        match number with 
        | (number) when number % 15 = 0 -> printfn "%d : FizzBuzz" number
        | (number) when number % 3 = 0 -> printfn "%d : Fizz" number
        | (number) when number % 5 = 0 -> printfn "%d : Buzz" number
        | _ -> printfn "%d" number
    
    let fizzbuzz3 number = 
        match number with 
        | (number) when number % 15 = 0 -> "FizzBuzz"
        | (number) when number % 3 = 0 -> "Fizz"
        | (number) when number % 5 = 0 -> "Buzz"
        | _ -> number.ToString()

    fizzMe
    |> Seq.map(fizzbuzz2)
    |> Seq.iter ignore

    Console.ReadKey()

    0 // return an integer exit code
