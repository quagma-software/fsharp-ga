namespace tech.quagma.ꗃⳆmaths.ꗃⳆnumeric

open System
open System.Security.Cryptography

[<AutoOpen>]
module ꕺⳆuseꓽꕥ=

    [<AutoOpen>]
    module private ꕺⳆprivateꓽꕥ=

        type ᐪꕥ=
            RandomNumberGenerator

    let ꔟ=
        fun () ->
            match ᐪꕥ.GetBytes(1) with
            | [|b|] when b < 128uy -> +1
            | _ -> -1
    
    let ꔞ=
        fun () ->
            let bytes=
                ᐪꕥ.GetBytes(8)

            let di=
                uint64 (1 <<< 11)

            let dd=
                float (1UL <<< 53)

            let ul=
                BitConverter.ToUInt64(bytes, 0)

            float (ul / di) / dd