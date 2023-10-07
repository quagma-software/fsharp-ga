namespace tech.quagma.ꗃⳆmaths.ꗃⳆgeometry

open tech.quagma.ꗃⳆutils.ꕺⳆuseFSharp
open tech.quagma.ꗃⳆmaths.ꗃⳆnumeric.ꕺⳆuseꓽᎡ

open System
open System.Threading.Tasks

// complex algebra (p=2, q=0)
module ꕺⳆuseꓽᎶꓹ2ꓹ0=

    [<AutoOpen>]
    module private ꕺⳆprivateꓽᎶꓹ2ꓹ0=

        type ᐪᎶ<'t>=
            ᐪᎡ<'t> array

        let Ꮚ= [|
            [| +1; +2; +3; +4 |];
            [| +2; +1; +4; +3 |];
            [| +3; -4; +1; -2 |];
            [| +4; -3; -2; -1 |];
        |]

        let Ꮚᵢⱼ=
            Array2D.init 4 4
                (fun i j -> Ꮚ[i][j])

        let Ꮿᵩ=
            fun (φ: int) ->
                [|0..3|] |> Array.Parallel.map (fun i ->
                    [|0..3|] |> Array.Parallel.map (fun j ->
                        (i, j)
                    )
                )
                |> Array.concat
                |> Array.Parallel.filter
                    (fun (i, j) -> Math.Abs(Ꮚᵢⱼ[i, j]) = φ)
                |> Array.Parallel.map
                    (fun (i, j) -> (i, j, Math.Sign(Ꮚᵢⱼ[i, j])))

        let ``ꕕ``
            (u: ᐪᎶ<'t>)
            (v: ᐪᎶ<'t>)=
                [|1..4|] |> Array.Parallel.map (fun φ ->
                    (Ꮿᵩ φ) |> Array.Parallel.map (fun (i, j, σ) ->
                        u[i] * v[j] * Ꭱᘁ σ
                    ) |> Array.Parallel.sum
                ): ᐪᎶ<'t>

    type ᑉᎶᐣ<'t>= {|
        ``λꓸ``: ᐪᎡ<'t>;
        ``λ₁``: ᐪᎡ<'t>;
        ``λ₂``: ᐪᎡ<'t>;
        ``λ₁₂``: ᐪᎡ<'t>;
        // multi-vector
    |}

    type ``ᑉᎶ₀ᐣ``<'t>= {|
        ``λꓸ``: ᐪᎡ<'t>;
        // blade-0 scalar
    |}

    type ``ᑉᎶ₁ᐣ``<'t>= {|
        ``λ₁``: ᐪᎡ<'t>;
        ``λ₂``: ᐪᎡ<'t>;
        // blade-1 vector
    |}

    type ``ᑉᎶ₂ᐣ``<'t>= {|
        ``λ₁₂``: ᐪᎡ<'t>;
        // blade-2 bi-vector
    |}

    type ``ᑉᎶ꘎ᐣ``<'t>=
        | ``ᑉᎶ꘎ᐣꓹλꓸ`` of ᐪᎡ<'t>
        | ``ᑉᎶ꘎ᐣꓹλ₁`` of ᐪᎡ<'t>
        | ``ᑉᎶ꘎ᐣꓹλ₂`` of ᐪᎡ<'t>
        | ``ᑉᎶ꘎ᐣꓹλ₁₂`` of ᐪᎡ<'t>

    type withꓽᎶꓹ2ꓹ0<'t>()=
            // takes a list of coeffs λ꘎
            // and converts to array-vector Λ
            let ``ꘖ⮐``=
                fun ᐠ1 ->
                    let ``λ꘎``=
                        ᐠ1: ``ᑉᎶ꘎ᐣ``<'t> list

                    let f
                        (Λ: ᐪᎶ<'t>)
                        (λᵢ: ``ᑉᎶ꘎ᐣ``<'t>)=
                                match λᵢ with
                                | ``ᑉᎶ꘎ᐣꓹλꓸ`` λᵢ -> Array.set Λ 0 λᵢ
                                | ``ᑉᎶ꘎ᐣꓹλ₁`` λᵢ -> Array.set Λ 1 λᵢ
                                | ``ᑉᎶ꘎ᐣꓹλ₂`` λᵢ -> Array.set Λ 2 λᵢ
                                | ``ᑉᎶ꘎ᐣꓹλ₁₂`` λᵢ -> Array.set Λ 3 λᵢ
                                Λ

                    let z=
                        [|Ꭱᘁ ᱳ; Ꭱᘁ ᱳ; Ꭱᘁ ᱳ; Ꭱᘁ ᱳ|]

                    let Λ=
                        List.fold f z ``λ꘎``

                    Λ

            let getMultiVector (ᐠ1: ᐪᎶ<'t>): ᑉᎶᐣ<'t>= {|
                ``λꓸ``= ᐠ1[0];
                ``λ₁``= ᐠ1[1];
                ``λ₂``= ᐠ1[2];
                ``λ₁₂``= ᐠ1[3];
            |}

            member _.Yield(())= async {
                let ``Ξ꘎``=
                    []: ᐪᎶ<'t> list

                let ``λ꘎``=
                    []: ``ᑉᎶ꘎ᐣ``<'t> list

                let task=
                    fun () ->
                        let ꕺ=
                            ``Ξ꘎``, ``λ꘎``

                        ꕺ

                let! ꕺ=
                    Task.Run(ꗓ(task))
                    |> Async.AwaitTask

                return
                    ꕺ
            }

            member _.Zero()= async {
                let ``Ξ꘎``=
                    []: ᐪᎶ<'t> list

                let ``λ꘎``=
                    []: ``ᑉᎶ꘎ᐣ``<'t> list

                let task=
                    fun () ->
                        let ꕺ=
                            ``Ξ꘎``, ``λ꘎``

                        ꕺ

                let! ꕺ=
                    Task.Run(ꗓ(task))
                    |> Async.AwaitTask

                return
                    ꕺ
            }

            [<ⵛ("ᐅ")>]
            member _.ᐅ(ᐤ1, ᐠ2)= async {
                let! ᐠ1= ᐤ1

                let (α, β)=
                    ᐠ1: ᐪᎶ<'t> list
                        * ``ᑉᎶ꘎ᐣ``<'t> list

                let ``Ξ꘎``=
                    α

                let ``λ꘎``=
                    β

                let λᵢ=
                    ᐠ2: ``ᑉᎶ꘎ᐣ``<'t>

                let task=
                    fun () ->
                        let ꕺ=
                            ``Ξ꘎``, ``λ꘎`` @ [λᵢ]

                        ꕺ

                let! ꕺ=
                    Task.Run(ꗓ(task))
                    |> Async.AwaitTask

                return
                    ꕺ
            }

            [<ⵛ("ᐃ")>]
            member _.ᐃ(ᐤ1, ᐠ2)= async {
                let! ᐠ1= ᐤ1

                let (α, β)=
                    ᐠ1: ᐪᎶ<'t> list
                        * ``ᑉᎶ꘎ᐣ``<'t> list

                let ``Ξ꘎``=
                    α

                let ``λ꘎``=
                    β

                let λᵢ=
                    ᐠ2: ``ᑉᎶ꘎ᐣ``<'t>

                let task=
                    fun () ->
                        let Λ=
                            ``ꘖ⮐`` (``λ꘎`` @ [λᵢ])

                        let ``Ξᕁ``=
                            ``Ξ꘎`` @ [Λ]

                        let ``λᕁ``=
                            []: ``ᑉᎶ꘎ᐣ``<'t> list

                        let ꕺ=
                            ``Ξᕁ``, ``λᕁ``

                        ꕺ

                let! ꕺ=
                    Task.Run(ꗓ(task))
                    |> Async.AwaitTask

                return
                    ꕺ
            }

            [<ⵛ("ꕕ")>]
            member _.ꕕ(ᐤ1, ᐠ2)= async {
                let! ᐠ1= ᐤ1

                let (α, β)=
                    ᐠ1: ᐪᎶ<'t> list
                        * ``ᑉᎶ꘎ᐣ``<'t> list

                let ``Ξ꘎``=
                    α

                let ``λ꘎``=
                    β

                let λᵢ=
                    ᐠ2: ``ᑉᎶ꘎ᐣ``<'t>

                let task=
                    fun () ->
                        let n=
                            List.length ``Ξ꘎``

                        let u=
                            List.last ``Ξ꘎``

                        let v=
                            ``ꘖ⮐`` (``λ꘎`` @ [λᵢ])

                        let p=
                            ``ꕕ`` u v

                        let ``Ξᕁ``=
                            ``Ξ꘎``[..n-2] @ [p]

                        let ``λᕁ``=
                            []: ``ᑉᎶ꘎ᐣ``<'t> list

                        let ꕺ=
                            ``Ξᕁ``, ``λᕁ``

                        ꕺ

                let! ꕺ=
                    Task.Run(ꗓ(task))
                    |> Async.AwaitTask

                return
                    ꕺ
            }

            [<ⵛ("ᐁ")>]
            member _.ᐁ(ᐤ1, _)= async {
                let! ᐠ1= ᐤ1

                let (α, _)=
                    ᐠ1: ᐪᎶ<'t> list
                        * ``ᑉᎶ꘎ᐣ``<'t> list

                let ``Ξ꘎``=
                    α

                let task=
                    fun () ->
                        let ꕺ=
                            List.last ``Ξ꘎``

                        ꕺ

                let! ꕺ=
                    Task.Run(ꗓ(task))
                    |> Async.AwaitTask

                return
                    getMultiVector ꕺ
            }

    type withꓽᎶꓹ2ꓹ0=
            withꓽᎶꓹ2ꓹ0<unit>