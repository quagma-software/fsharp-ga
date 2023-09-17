namespace tech.quagma.ꗃⳆmaths.ꗃⳆgeometry

open System

// basic euclidean geometry (3d)
module ꕺⳆuseꓽᏋꓹ3=

    type ꔰꓽᏋꓹ3=
        | ꕹcartesian of struct {| x: float; y: float; z: float |}
        | ꕹspherical of struct {| ρ: float; θ: float; φ: float |}

        member this.asCartesian ᑉeᐣ=
            match ᑉeᐣ with

            | ꕹcartesian ᑉνᐣ ->
                ᑉeᐣ

            | ꕹspherical ᑉνᐣ ->
                let x= ᑉνᐣ.ρ * Math.Sin(ᑉνᐣ.θ) * Math.Cos(ᑉνᐣ.φ)
                let y= ᑉνᐣ.ρ * Math.Sin(ᑉνᐣ.θ) * Math.Sin(ᑉνᐣ.φ)
                let z= ᑉνᐣ.ρ * Math.Cos(ᑉνᐣ.θ)

                ꕹcartesian {| x= x; y= y; z= z |}