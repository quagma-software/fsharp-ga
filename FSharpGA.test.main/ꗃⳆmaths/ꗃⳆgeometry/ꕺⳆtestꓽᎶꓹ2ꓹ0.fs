namespace tech.quagma.ꗃⳆmaths.ꗃⳆgeometry

open tech.quagma.ꗃⳆutils.ꕺⳆuseFSharp
open tech.quagma.ꗃⳆmaths.ꗃⳆnumeric.ꕺⳆuseꓽᎡ
open tech.quagma.ꗃⳆmaths.ꗃⳆnumeric.ꕺⳆuseꓽꕥ
open tech.quagma.ꗃⳆmaths.ꗃⳆgeometry.ꕺⳆuseꓽᎶꓹ2ꓹ0

open Microsoft.VisualStudio.TestTools.UnitTesting

open System
open System.Security.Cryptography

// complex algebra (p=2, q=0)
module ꕺⳆtestꓽᎶꓹ2ꓹ0=

    [<TestClass>]
    type ᐪⳆG1()=

        [<TestMethod>]
        member this.ᐞⳆG1aⳆtestNullProducts()= ⵑⵑ <| async {
            Console.WriteLine($"-- Testing null products --")

            for  i in [1..16] do
                do! ᐞⳆwithꓽᎶꓹ2ꓹ0 {
                    ᐅ "" {| ``λꓸ``= 0.0; ``λ₁``= 0.0; ``λ₂``= 0.0; ``λ₁₂``= 0.0 |}
                }
        }