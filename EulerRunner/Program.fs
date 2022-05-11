module Main

open EulerSolutions

[<EntryPoint>]
let main args =
    Helpers.sieveOfEratosthenes 2_000_000
    |> Array.sumBy bigint
    |> printfn "%A"

    0