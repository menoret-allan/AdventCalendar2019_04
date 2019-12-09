namespace Core

module Pwd =
    let verifyLenght (pwd:int) =
        if string pwd |> String.length = 6 then Some pwd
        else None

    let verifyIncreaseNumber (pwd:int) = 
        if  string pwd |> Seq.pairwise |> Seq.exists (fun (x, y) -> x > y) then None else Some pwd

    let verifyHaveDouble (pwd:int) =
        if  string pwd |> Seq.pairwise |> Seq.exists (fun (x, y) -> x = y) then Some pwd else None

    let isValidPwd pwd =
        pwd |> verifyLenght |> Option.bind verifyIncreaseNumber |> Option.bind verifyHaveDouble

    let verifyHaveDoublePart2 (pwd:int) =
          let strs = string pwd
          let rec loop chars c count =
              match (chars, count) with
              | (x::rest, _) when c = x -> loop rest x (count + 1)
              | (_, 2) -> Some pwd
              | (x::rest, _) -> loop rest x 1
              | _ -> None
          loop (strs |> Seq.skip 1 |> Seq.toList) (strs|> Seq.head) 1

    let isValidPwdPart2 pwd =
        pwd |> verifyLenght |> Option.bind verifyIncreaseNumber |> Option.bind verifyHaveDoublePart2
