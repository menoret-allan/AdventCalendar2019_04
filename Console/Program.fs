// Learn more about F# at http://fsharp.org

open System
open Core.Pwd

[<EntryPoint>]
let main argv =
    let first = 156218
    let last = 652527

    let possibilities = seq{for x in 0 .. (last-first) do first+x}
    printfn "Result part 1: %i" (possibilities |> Seq.choose(isValidPwd) |> Seq.length)
    printfn "Result part 2: %i" (possibilities |> Seq.choose(isValidPwdPart2) |> Seq.length)
    0 // return an integer exit code
