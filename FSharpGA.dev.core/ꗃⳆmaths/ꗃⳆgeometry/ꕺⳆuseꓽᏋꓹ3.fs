namespace tech.quagma.ꗃⳆmaths.ꗃⳆgeometry

open tech.quagma.ꗃⳆmaths.ꗃⳆnumeric.ꕺⳆuseꓽᎡ

open System

// basic euclidean geometry (3d)
module ꕺⳆuseꓽᏋꓹ3=

    type ꔰꓽcꓹ3=
            struct
                val x: float
                val y: float
                val z: float
                new(x, y, z)= {x= x; y= y; z= z}
            end

    type private ⵌꓽsꓹ3=
        {|ρ: float; θ: float; φ: float|}

    type ꔰꓽsꓹ3=
            struct
                val ρ: float
                val θ: float
                val φ: float
                new(ρ, θ, φ)=
                    let rec ꔰ(ⵌ: ⵌꓽsꓹ3)=
                                let (ρ, θ, φ)=
                                    (ⵌ.ρ, ⴳ(ⵌ.θ), ⴵ(ⵌ.φ))
                                match (ρ, θ, φ) with
                                | (ꘌⴰ, _, _)  -> {|ρ= ᱳ; θ= ᱳ; φ= ᱳ|}
                                | (ᐳⴰ, ꘌⴰ, _) -> {|ρ= ρ; θ= ᱳ; φ= ᱳ|}
                                | (ᐳⴰ, ᐳⴰ, _) -> {|ρ= ρ; θ= ⴳ(θ); φ= if ⴳ(θ) < π then ⴵ(φ) else ᱳ|}
                                | (ᐳⴰ, ᐸⴰ, _) -> {|ρ= ρ; θ= -ⴳ(θ); φ= ⴵ(φ + π)|}
                                | (ᐸⴰ, _, _)  -> ꔰ {|ρ= -ρ; θ= θ + π; φ= φ + π|}
                    let ⵌ= ꔰ {|ρ= ρ; θ= θ; φ= φ|}
                    {ρ= ⵌ.ρ; θ= ⵌ.θ; φ= ⵌ.φ}
            end

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