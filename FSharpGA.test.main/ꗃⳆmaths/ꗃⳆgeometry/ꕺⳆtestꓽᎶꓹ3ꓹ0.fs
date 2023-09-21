namespace tech.quagma.ꗃⳆmaths.ꗃⳆgeometry

open tech.quagma.ꗃⳆmaths.ꗃⳆnumeric.ꕺⳆuseꓽᎡ
open tech.quagma.ꗃⳆmaths.ꗃⳆnumeric.ꕺⳆuseꓽꕥ
open tech.quagma.ꗃⳆmaths.ꗃⳆgeometry.ꕺⳆuseꓽᎶꓹ3ꓹ0

open Microsoft.VisualStudio.TestTools.UnitTesting

open System
open System.Security.Cryptography

// quaternion algebra (p=3, q=0)
module ꕺⳆtestꓽᎶꓹ3ꓹ0=

    [<TestClass>]
    type ᐪⳆG1()=

        [<TestMethod>]
        member this.ᐞⳆG1aⳆtestIntProduct()=
            Console.WriteLine($"-- Testing null products --")

            for  i in [1..16] do
                let ᑉuᐣ: ᑉᎶᐣ= {|
                    ``λꓸ``= ꔞ.GetInt32(-15, 16);
                    ``λ₁``= ꔞ.GetInt32(-15, 16);
                    ``λ₂``= ꔞ.GetInt32(-15, 16);
                    ``λ₃``= ꔞ.GetInt32(-15, 16);
                    ``λ₁₂``= ꔞ.GetInt32(-15, 16);
                    ``λ₁₃``= ꔞ.GetInt32(-15, 16);
                    ``λ₂₃``= ꔞ.GetInt32(-15, 16);
                    ``λ₁₂₃``= ꔞ.GetInt32(-15, 16);
                |}

                let ᑉvᐣ: ᑉᎶᐣ= {|
                    ``λꓸ``= 0;
                    ``λ₁``= 0;
                    ``λ₂``= 0;
                    ``λ₃``= 0;
                    ``λ₁₂``= 0;
                    ``λ₁₃``= 0;
                    ``λ₂₃``= 0;
                    ``λ₁₂₃``= 0;
                |}

                let ᑉu꘡vᐣ=
                    ``ꖴ`` ᑉuᐣ ᑉvᐣ

                Assert.IsTrue(ᑉu꘡vᐣ.``λꓸ`` = 0)
                Assert.IsTrue(ᑉu꘡vᐣ.``λ₁`` = 0)
                Assert.IsTrue(ᑉu꘡vᐣ.``λ₂`` = 0)
                Assert.IsTrue(ᑉu꘡vᐣ.``λ₃`` = 0)
                Assert.IsTrue(ᑉu꘡vᐣ.``λ₁₂`` = 0)
                Assert.IsTrue(ᑉu꘡vᐣ.``λ₁₃`` = 0)
                Assert.IsTrue(ᑉu꘡vᐣ.``λ₂₃`` = 0)
                Assert.IsTrue(ᑉu꘡vᐣ.``λ₁₂₃`` = 0)