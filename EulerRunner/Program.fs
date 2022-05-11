module Main

open EulerSolutions

[<EntryPoint>]
let main args =
    printfn "%A" <| Helpers.isPythagoreanTriple (3,4,5)
    printfn "%A" <| Helpers.isPythagoreanTriple (4,5,3)

    Euler.``Find pythagorean triplet whose sum is n`` 1000
    |> (fun triplet -> printfn "%A" triplet; triplet)
    |> Seq.map (fun (i,j,k) -> i * j * k)
    |> printfn "%A"

    0