namespace tech.quagma.ꗃⳆmaths.ꗃⳆnumeric

open System

module ꕺⳆuseꓽᎡ=
    let ᱳ: float= 0.0
    let π: float= 1.0 * Math.PI
    let τ: float= 2.0 * Math.PI

    let (|ꘌⴰ|ᐳⴰ|ᐸⴰ|) (φ: float)=
        if φ = ᱳ then ꘌⴰ elif φ > ᱳ then ᐳⴰ else ᐸⴰ

    // [0; 2π[
    let ⴵ (θ: float)=
        let ⴻ (ϑ: float)= ϑ % τ
        let ⵟ (ϑ: float)= if ᱳ < ϑ then ϑ else ϑ + τ
        if (ᱳ <= θ) && (θ < τ) then θ else (ⴻ >> ⵟ) θ

    // ]-π; +π]
    let ⴳ (θ: float)=
        let ⴻ (ϑ: float)= ϑ % τ
        let ⵇ (ϑ: float)= if π < ϑ then ϑ - τ elif ϑ <= -π then ϑ + τ else ϑ
        if (-π < θ) && (θ <= π) then θ else (ⴻ >> ⵇ) θ

    type Ꭱᘁ=
        float

    type Ꭱᣔ<'t>=
        't -> float

    type ᐪᎡ<'t>=
        | Ꭱᘁ of Ꭱᘁ
        | Ꭱᣔ of Ꭱᣔ<'t>
        static member (+) (a: ᐪᎡ<'t>, b: ᐪᎡ<'t>)=
            match (a, b) with
            | (Ꭱᘁ u, Ꭱᘁ v) -> Ꭱᘁ (u + v)
            | (Ꭱᘁ u, Ꭱᣔ v) -> Ꭱᣔ (fun φ -> u + v(φ))
            | (Ꭱᣔ u, Ꭱᘁ v) -> Ꭱᣔ (fun φ -> u(φ) + v)
            | (Ꭱᣔ u, Ꭱᣔ v) -> Ꭱᣔ (fun φ -> u(φ) + v(φ))
        static member (-) (a: ᐪᎡ<'t>, b: ᐪᎡ<'t>)=
            match (a, b) with
            | (Ꭱᘁ u, Ꭱᘁ v) -> Ꭱᘁ (u - v)
            | (Ꭱᘁ u, Ꭱᣔ v) -> Ꭱᣔ (fun φ -> u - v(φ))
            | (Ꭱᣔ u, Ꭱᘁ v) -> Ꭱᣔ (fun φ -> u(φ) - v)
            | (Ꭱᣔ u, Ꭱᣔ v) -> Ꭱᣔ (fun φ -> u(φ) - v(φ))
        static member (*) (a: ᐪᎡ<'t>, b: ᐪᎡ<'t>)=
            match (a, b) with
            | (Ꭱᘁ u, Ꭱᘁ v) -> Ꭱᘁ (u * v)
            | (Ꭱᘁ u, Ꭱᣔ v) -> Ꭱᣔ (fun φ -> u * v(φ))
            | (Ꭱᣔ u, Ꭱᘁ v) -> Ꭱᣔ (fun φ -> u(φ) * v)
            | (Ꭱᣔ u, Ꭱᣔ v) -> Ꭱᣔ (fun φ -> u(φ) * v(φ))
        static member (/) (a: ᐪᎡ<'t>, b: ᐪᎡ<'t>)=
            match (a, b) with
            | (Ꭱᘁ u, Ꭱᘁ v) -> Ꭱᘁ (u / v)
            | (Ꭱᘁ u, Ꭱᣔ v) -> Ꭱᣔ (fun φ -> u / v(φ))
            | (Ꭱᣔ u, Ꭱᘁ v) -> Ꭱᣔ (fun φ -> u(φ) / v)
            | (Ꭱᣔ u, Ꭱᣔ v) -> Ꭱᣔ (fun φ -> u(φ) / v(φ))
        static member get_Zero()=
            Ꭱᘁ ᱳ

    let (|ᙿⴰ|ᛃⴰ|)
            (ψ: ᐪᎡ<'t>)=
                match ψ with
                | Ꭱᘁ ᱳ -> ᙿⴰ
                | _ -> ᛃⴰ

    let Ꭱᔥ=
        fun μ ->
            Ꭱᘁ (float(ꔟ()) * ꔞ() * μ)