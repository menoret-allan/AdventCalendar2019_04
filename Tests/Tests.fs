module Tests

open Xunit
open FsUnit
open Core.Pwd


[<Theory>]
[<InlineData(111111)>]
[<InlineData(122345)>]
[<InlineData(111123)>]
[<InlineData(468899)>]
let ``valid pwd`` (pwd:int) =
    pwd |> isValidPwd |> should equal (Some pwd)


[<Theory>]
[<InlineData(11111)>]
[<InlineData(1111111)>]
[<InlineData(123456)>]
[<InlineData(135679)>]
[<InlineData(223450)>]
[<InlineData(123789)>]
let ``not valid pwd`` (pwd:int) =
    pwd |> isValidPwd |> should equal None


[<Theory>]
[<InlineData(11111)>]
[<InlineData(1111111)>]
[<InlineData(123455346)>]
[<InlineData(139)>]
let ``pwd length not valid`` (pwd:int) =
    pwd |> verifyLenght |> should equal None

[<Theory>]
[<InlineData(111111)>]
[<InlineData(840274)>]
[<InlineData(100280)>]
let ``pwd length valid`` (pwd:int) =
    pwd |> verifyLenght |>  should equal (Some(pwd))

[<Theory>]
[<InlineData(111110)>]
[<InlineData(840274)>]
[<InlineData(123435)>]
let ``pwd increase number not valid`` (pwd:int) =
    pwd |> verifyIncreaseNumber |>  should equal None

[<Theory>]
[<InlineData(111111)>]
[<InlineData(123456)>]
[<InlineData(246899)>]
let ``pwd increase number valid`` (pwd:int) =
    pwd |> verifyIncreaseNumber |>  should equal (Some(pwd))

[<Theory>]
[<InlineData(123456)>]
[<InlineData(987654)>]
[<InlineData(136809)>]
[<InlineData(121212)>]
let ``pwd has a double not valid`` (pwd:int) =
    pwd |> verifyHaveDouble |> should equal None

[<Theory>]
[<InlineData(111111)>]
[<InlineData(124456)>]
[<InlineData(246899)>]
[<InlineData(996899)>]
let ``pwd has a double valid`` (pwd:int) =
    pwd |> verifyHaveDouble |>  should equal (Some(pwd))

// test all validation function