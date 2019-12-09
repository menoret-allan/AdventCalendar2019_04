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
