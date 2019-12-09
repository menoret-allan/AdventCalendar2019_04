// Learn more about F# at http://fsharp.org

open System
open Core.Pwd

[<EntryPoint>]
let main argv =
    let first = 156218
    let last = 652527

    let possibilities = seq{for x in 0 .. (last-first) do first+x}
    let rest = possibilities |> Seq.choose(isValidPwd)
    printfn "Result: %i" (rest |> Seq.length)
    0 // return an integer exit code
