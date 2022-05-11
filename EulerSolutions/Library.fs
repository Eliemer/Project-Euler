namespace EulerSolutions

open System
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

    // ID: 5
    let ``Smallest positive number that is evenly divisible by all numbers from 1 to n`` n =
        let range = [1..n]
        let possible = Seq.initInfinite (fun n -> n + 1)

        possible
        |> Seq.find (fun x -> List.forall (fun m -> x % m = 0) range)

    // ID: 6
    let ``Sum Square difference for ints up to n`` n =
        let range = [1..n]

        let _, sumOfSquares = List.mapFold (fun acc n -> n*n, acc + (n*n)) 0 range
        let squareOfSum = List.reduce (+) range |> (fun n -> n*n)

        squareOfSum - sumOfSquares

    // ID: 7
    let nthPrime n = 
        if n = 1 then
            2
        else 
            let mutable count = 2
            let mutable m = 3

            while count < n do
                m <- m + 2

                if isPrime(m) then
                    count <- count + 1

            m

    // ID: 8
    let largestProductInSeries n (str : string) =
        str
        |> Seq.map (string >> Int64.Parse)
        |> Seq.windowed n
        |> Seq.map (Array.fold (*) 1L)
        |> Seq.max

    // ID: 9
    let ``Find pythagorean triplet whose sum is n`` n =
        seq {
            for i in [1..n] do
                for j in [i+1..n] do
                    for k in [j+1..n] do
                        if isPythagoreanTriple (i,j,k) && i + j + k = n then 
                            (i,j,k) }

                        
