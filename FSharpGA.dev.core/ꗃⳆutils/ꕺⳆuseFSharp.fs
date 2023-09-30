namespace tech.quagma.ꗃⳆutils

open System
open System.Threading.Tasks

[<AutoOpen>]
module ꕺⳆuseFSharp=

    type ⵛ=
        CustomOperationAttribute

    let ⵑⵑ
        async=
            async
            |> Async.StartImmediateAsTask
            :> Task

    let ꗓ<'t>
        (f: unit -> 't)=
            new Func<'t>(f)