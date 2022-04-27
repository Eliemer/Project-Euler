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

    // ID: 4
    let ``Largest palindrome from product of n-digit numbers`` n =
        let range = [(pown 10 (n-1))..(pown 10 n)-1] |> List.rev
        let products = seq {
            for x in range do
                for y in range do
                    x * y
        }

        products
        |> Seq.map string
        |> Seq.filter (fun nStr -> nStr = reverseString nStr)
        |> Seq.map int
        |> Seq.max
