// Learn more about F# at http://fsharp.org
open System
[<EntryPoint>]
let main argv =
    
    //introduciendo numeros del 1 al 20 con un for
    let lista = [for i in 0..20 -> i]
    //introduciendo numeros de forma manual
    //let lista = [15;33;28;48;51;3;1;14;52;84;99;75;63]
    
    let mutable lpares = []
    let mutable lipares = []
    for i in lista do
        if (i % 2 = 0) then
            lpares <- List.append lpares [i] 
        else 
            lipares <- List.append lipares [i] 

    printf "Numeros Pares: "
    for i in lpares do
        printf "%i " i
    printfn ""
    printf "Numeros Impares: "
    for i in lipares do
        printf "%i " i
    
    System.Console.ReadKey() |>ignore
    0 // return an integer exit code
