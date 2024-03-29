﻿module Helpers

open System.Text
open System.Collections.Immutable

// infinite lazy fibonacci sequence
// O(n)
let fib : int seq =
    Seq.unfold (fun (a, b) -> Some (b + a, (b, b + a))) (0, 1)

let primeFactors (n : bigint) : bigint list =

    let rec getFactor (acc : bigint list) (x : bigint) (y : bigint) =
        if x = y then
            y :: acc
        elif x % y = bigint 0 then
            getFactor (y :: acc) (x / y) y 
        else
            getFactor acc x (y + (bigint 1))

    getFactor [] n (bigint 2) 

let reverseString (str : string) : string =
    str.EnumerateRunes()
    |> Seq.rev
    |> Seq.toArray
    |> Array.collect (fun rune -> rune.ToString().ToCharArray())
    |> System.String


let isPrime n = 
    let mutable isPrimeTest = true
    let upper = sqrt(float n) |> floor |> int

    for i in [2..upper] do
        if n % i = 0 then
            isPrimeTest <- false
            
    isPrimeTest

let ``1000-digit number`` = 
    "73167176531330624919225119674426574742355349194934
    96983520312774506326239578318016984801869478851843
    85861560789112949495459501737958331952853208805511
    12540698747158523863050715693290963295227443043557
    66896648950445244523161731856403098711121722383113
    62229893423380308135336276614282806444486645238749
    30358907296290491560440772390713810515859307960866
    70172427121883998797908792274921901699720888093776
    65727333001053367881220235421809751254540594752243
    52584907711670556013604839586446706324415722155397
    53697817977846174064955149290862569321978468622482
    83972241375657056057490261407972968652414535100474
    82166370484403199890008895243450658541227588666881
    16427171479924442928230863465674813919123162824586
    17866458359124566529476545682848912883142607690042
    24219022671055626321111109370544217506941658960408
    07198403850962455444362981230987879927244284909188
    84580156166097919133875499200524063689912560717606
    05886116467109405077541002256983155200055935729725
    71636269561882670428252483600823257530420752963450"
    |> String.filter (fun c -> "0123456789".Contains c)

let isPythagoreanTriple (a, b, c) =
    if a >= b || a >= c || b >= c then
        false
    else
        (a * a) + (b * b) = (c * c)

let sieveOfEratosthenes n =
    let res = Array.create (n) true
    res.[0] <- false // 1 is not a prime

    let upper = n |> float |> sqrt |> int

    for i in [1..upper] do
        let upperJ = [i*i .. i .. n]
        if res.[i-1] then
            for j in upperJ do
                res.[j-1] <- false

    Array.indexed res
    |> Array.choose (fun (idx, isPrime) -> if isPrime then Some (idx + 1) else None)
    