namespace tech.quagma.ꗃⳆmaths.ꗃⳆnumeric

open System.Security.Cryptography

module ꕺⳆuseꓽꕥ=

    [<AutoOpen>]
    module private ꕺⳆprivateꓽꕥ=

        type ᐪꔞ=
            RandomNumberGenerator

    let ꔞ=
        fun min max ->
            ᐪꔞ.GetInt32(min, max + 1)