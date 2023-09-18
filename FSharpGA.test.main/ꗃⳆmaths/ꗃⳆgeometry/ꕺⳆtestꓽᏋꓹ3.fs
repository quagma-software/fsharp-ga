namespace tech.quagma.ꗃⳆmaths.ꗃⳆgeometry

open tech.quagma.ꗃⳆmaths.ꗃⳆnumeric.ꕺⳆuseꓽᎡ
open tech.quagma.ꗃⳆmaths.ꗃⳆgeometry.ꕺⳆuseꓽᏋꓹ3

open Microsoft.VisualStudio.TestTools.UnitTesting

open System

// basic euclidean geometry (3d)
module ꕺⳆtestꓽᏋꓹ3=

    let ꔟ= new Random()
    let ꔞ= new Random(ꔟ.Next())

    [<TestClass>]
    type ᐪⳆG1()=

        [<TestMethod>]
        member this.ᐞⳆG1aⳆtestSphericalCoords()=
            Console.WriteLine($"Testing null coordinates")

            for  i in [1..32] do
                let ρ: float= 0
                let θ: float= ꔞ.NextDouble() * float(ꔞ.Next(-16, 17)) * π
                let φ: float= ꔞ.NextDouble() * float(ꔞ.Next(-16, 17)) * π
                
                let ꔰ= ꔰꓽsꓹ3(ρ, θ, φ)

                Console.WriteLine($"ρ: {ρ}, θ: {θ * 180.0 / π}, φ: {φ * 180.0 / π}")
                Console.WriteLine($"ρ: {ꔰ.ρ}, θ: {ꔰ.θ * 180.0 / π}, φ: {ꔰ.φ * 180.0 / π}")

                Assert.IsTrue(ꔰ.ρ = 0);
                Assert.IsTrue(ꔰ.θ = 0);
                Assert.IsTrue(ꔰ.φ = 0);