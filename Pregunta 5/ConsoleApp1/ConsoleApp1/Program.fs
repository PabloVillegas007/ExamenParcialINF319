// Learn more about F# at http://fsharp.org

open System

let suma a b  = a + a
let multi a  b = 
    let mutable aux = 0 
    for i in 1..b do
        aux <- aux + a
    aux   
                   
[<EntryPoint>]
let main argv =
    printf "Ingrese el primer Numero: "
    let var1 = Console.ReadLine()
    printf "Ingrese el segundo Numero: "
    let var2 = Console.ReadLine()
    let vint1  = var1 |> int
    let vint2  = var2 |> int
    
    let res = multi vint1 vint2
    printf "El producto de %i" vint1 
    printf " * %i" vint2 
    printf " = %i" res
    
    Console.ReadKey() |>ignore
    0 // return an integer exit code