namespace tech.quagma.ꗃⳆmaths.ꗃⳆgeometry

open tech.quagma.ꗃⳆutils

open tech.quagma.ꗃⳆmaths.ꗃⳆnumeric.ꕺⳆuseꓽᎡ
open tech.quagma.ꗃⳆmaths.ꗃⳆgeometry.ꕺⳆuseꓽᎶꓹ2ꓹ0

open Microsoft.VisualStudio.TestTools.UnitTesting

open System

open FSharp.Control

// complex algebra (p=2, q=0)
module ꕺⳆtestꓽᎶꓹ2ꓹ0=

    [<TestClass>]
    type ᐪⳆG1()=

        [<TestMethod>]
        member this.ᐞⳆG1aⳆtestNullProducts()= ⵑⵑ <| async {
            Console.WriteLine($"-- Testing null products --")

            let r= new Random()

            do! ꘈ() {
                ꘈᐊ [1..16]
                ꘈᐅ (fun i -> async {
                    let! ᑉuᐣ= withꓽᎶꓹ2ꓹ0() {
                        ᐅ (``ᑉᎶ꘎ᐣꓹλꓸ`` <| Ꭱᘁ ᱳ)
                        ᐅ (``ᑉᎶ꘎ᐣꓹλ₁`` <| Ꭱᘁ ᱳ)
                        ᐅ (``ᑉᎶ꘎ᐣꓹλ₂`` <| Ꭱᘁ ᱳ)
                        ᐃ (``ᑉᎶ꘎ᐣꓹλ₁₂`` <| Ꭱᘁ ᱳ)

                        ᐅ (``ᑉᎶ꘎ᐣꓹλꓸ`` <| Ꭱᔥ 100.0)
                        ᐅ (``ᑉᎶ꘎ᐣꓹλ₁`` <| Ꭱᔥ 100.0)
                        ᐅ (``ᑉᎶ꘎ᐣꓹλ₂`` <| Ꭱᔥ 100.0)
                        ꕕ (``ᑉᎶ꘎ᐣꓹλ₁₂`` <| Ꭱᔥ 100.0)

                        ᐁ ()
                    }

                    do! Async.Sleep (1000 * r.Next(1, 4))
                    Console.WriteLine($"{DateTime.Now:HHmmss}")
                    Console.WriteLine(ᑉuᐣ)

                    return
                        ᑉuᐣ
                })

                ᐁ ()
            }

            Console.WriteLine("--end--")
        }