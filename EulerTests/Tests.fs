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