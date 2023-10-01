namespace tech.quagma.ꗃⳆmaths.ꗃⳆgeometry

open tech.quagma.ꗃⳆutils.ꕺⳆuseFSharp
open tech.quagma.ꗃⳆmaths.ꗃⳆnumeric.ꕺⳆuseꓽᎡ
open tech.quagma.ꗃⳆmaths.ꗃⳆgeometry.ꕺⳆuseꓽᎶꓹ2ꓹ0

open Microsoft.VisualStudio.TestTools.UnitTesting

open System

// complex algebra (p=2, q=0)
module ꕺⳆtestꓽᎶꓹ2ꓹ0=

    [<TestClass>]
    type ᐪⳆG1()=

        [<TestMethod>]
        member this.ᐞⳆG1aⳆtestNullProducts()= ⵑⵑ <| async {
            Console.WriteLine($"-- Testing null products --")

            for i in [1..16] do
                let! ᑉuᐣ= withꓽᎶꓹ2ꓹ0<unit>() {
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

                Assert.IsTrue(true)
        }