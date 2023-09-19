namespace tech.quagma.ꗃⳆmaths.ꗃⳆgeometry

open tech.quagma.ꗃⳆmaths.ꗃⳆnumeric.ꕺⳆuseꓽᎡ

open System

// basic euclidean geometry (3d)
module ꕺⳆuseꓽᏋꓹ3=

    type ꔰᣔcꓹ3= // cartesian input form
        {|x: float; y: float; z: float|}

    type ꔰᘁcꓹ3= // cartesian canonical form
        {|x: float; y: float; z: float; ꓼ: char|}

    let ꔰꓽcꓹ3
        (ⵌ: ꔰᣔcꓹ3): ꔰᘁcꓹ3=
            {|x= ⵌ.x; y= ⵌ.y; z= ⵌ.z; ꓼ='!'|}

    type ꔰᣔsꓹ3= // spherical input form
        {|ρ: float; θ: float; φ: float|}

    type ꔰᘁsꓹ3= // spherical canonical form
        {|ρ: float; θ: float; φ: float; ꓼ: char|}

    let rec ꔰꓽsꓹ3
        (ⵌ: ꔰᣔsꓹ3): ꔰᘁsꓹ3=
            let ρ= ⵌ.ρ
            let θ= ⴳ(ⵌ.θ)
            let φ= ⴵ(ⵌ.φ)
            match (ρ, θ, φ) with
            | (ꘌⴰ, _, _)  -> {|ρ= ᱳ; θ= ᱳ; φ= ᱳ; ꓼ='!'|}
            | (ᐳⴰ, ꘌⴰ, _) -> {|ρ= ρ; θ= ᱳ; φ= ᱳ; ꓼ='!'|}
            | (ᐳⴰ, ᐳⴰ, _) -> {|ρ= ρ; θ= ⴳ(θ); φ= (if ⴳ(θ) < π then ⴵ(φ) else ᱳ); ꓼ='!'|}
            | (ᐳⴰ, ᐸⴰ, _) -> {|ρ= ρ; θ= -ⴳ(θ); φ= ⴵ(φ + π); ꓼ='!'|}
            | (ᐸⴰ, _, _)  -> ꔰꓽsꓹ3 {|ρ= -ρ; θ= θ + π; φ= φ + π|}

    type ꔰꓽᏋꓹ3=
        | ꕹcartesian of ꔰᘁcꓹ3
        | ꕹspherical of ꔰᘁsꓹ3

        member this.asCartesian()=
            match this with
            | ꕹcartesian ᑉνᐣ ->
                ᑉνᐣ
            | ꕹspherical ᑉνᐣ ->
                let x= ᑉνᐣ.ρ * Math.Sin(ᑉνᐣ.θ) * Math.Cos(ᑉνᐣ.φ)
                let y= ᑉνᐣ.ρ * Math.Sin(ᑉνᐣ.θ) * Math.Sin(ᑉνᐣ.φ)
                let z= ᑉνᐣ.ρ * Math.Cos(ᑉνᐣ.θ)
                ꔰꓽcꓹ3 {| x= x; y= y; z= z |}

        member this.asSpherical()=
            match this with
            | ꕹspherical ᑉνᐣ ->
                ᑉνᐣ
            | ꕹcartesian ᑉνᐣ ->
                let x= ᑉνᐣ.x
                let y= ᑉνᐣ.y
                let z= ᑉνᐣ.z
                let xᒾ= x * x
                let yᒾ= y * y
                let zᒾ= z * z
                let ς= Math.Sqrt(xᒾ + yᒾ)
                let ρ= Math.Sqrt(xᒾ + yᒾ + zᒾ)
                let θ= if ρ = ᱳ then ᱳ elif z = ᱳ then π/2.0 elif z > ᱳ then Math.Atan(ς/z) else π + Math.Atan(ς/z)
                let φ= if x = ᱳ && y = ᱳ then ᱳ else Math.Atan2(y, x)
                ꔰꓽsꓹ3 {| ρ= ρ; θ= θ; φ= φ |}