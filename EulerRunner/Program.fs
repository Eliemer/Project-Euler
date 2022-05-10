module Main

open EulerSolutions

[<EntryPoint>]
let main args =
    

    printfn "%A" <| Euler.largestProductInSeries 2 "123456"
    printfn "%A" <| Euler.largestProductInSeries 4 Helpers.``1000-digit number``
    printfn "%A" <| Euler.largestProductInSeries 13 Helpers.``1000-digit number``

    0