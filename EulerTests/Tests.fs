module Tests

open System
open Xunit
open FsCheck.Xunit
open EulerSolutions.Euler

[<Fact>]
let ``The sum of all multiples of 3 or 5 below 10 is 23`` () =
    Assert.Equal(23, ``Find the sum of all multiples of 3 or 5 below upper`` 10)

[<Fact>]
let ``The sum of all even-valued terms of the first ten terms of the Fibonacci sequence is 44`` () =
    // fib has ten terms below 100
    Assert.Equal(44, ``Find the sum of even-valued terms of the fibonacci sequence`` 100) 

[<Fact>]
let ``The largest prime factor of 13195 is 29`` () =
    Assert.Equal((bigint 29), ``Largest prime factor`` (bigint 13195))

[<Fact>]
let ``The largest palindrome made from the product of two 2-digit numbers is 9009`` () =
    Assert.Equal(9009, ``Largest palindrome from product of n-digit numbers`` 2)

[<Fact>]
let ``2520 is the smallest number that can be divided evenly by all numbers 1 to 10`` () =
    Assert.Equal(2520, ``Smallest positive number that is evenly divisible by all numbers from 1 to n`` 10)

[<Fact>]
let ``The Sum Square difference for the first ten natural numbers is 2640`` () =
    Assert.Equal(2640, ``Sum Square difference for ints up to n`` 10)

[<Fact>]
let ``The first six prime numbers are 2, 3, 5, 7, 11, and 13`` () =

    let expected = [2;3;5;7;11;13]
    let actual = [1..6] |> List.map nthPrime

    Assert.StrictEqual(expected, actual)
    Assert.Equal(104_743, nthPrime 10_001)

[<Fact>]
let ``The largest product of 4 adjacent digits in the series is 5832`` () =

    Assert.Equal(5832L, largestProductInSeries 4 Helpers.``1000-digit number``)
    Assert.Equal(23514624000L, largestProductInSeries 13 Helpers.``1000-digit number``)
    