module Helpers

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
    let mutable res : Rune list = []

    str.EnumerateRunes()
    |> Seq.rev
    |> Seq.toArray
    |> Array.collect (fun rune -> rune.ToString().ToCharArray())
    |> System.String




    