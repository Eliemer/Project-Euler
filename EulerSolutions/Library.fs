namespace EulerSolutions

open Helpers

module Euler =


    // ID: 1
    let ``Find the sum of all multiples of 3 or 5 below upper`` upper =
        List.filter (fun n -> n % 3 = 0 || n % 5 = 0) [1..upper-1]
        |> List.sum

    // ID: 2
    let ``Find the sum of even-valued terms of the fibonacci sequence`` upper =
        Seq.takeWhile (fun n -> n < upper) fib
        |> Seq.filter (fun n -> n % 2 = 0)
        |> Seq.sum

    // ID: 3
    let ``Largest prime factor`` (n : bigint) =
        primeFactors n
        |> Seq.max