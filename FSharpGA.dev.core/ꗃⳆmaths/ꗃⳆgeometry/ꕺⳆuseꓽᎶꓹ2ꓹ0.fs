namespace tech.quagma.ꗃⳆmaths.ꗃⳆgeometry

open tech.quagma.ꗃⳆutils.ꕺⳆuseFSharp
open tech.quagma.ꗃⳆmaths.ꗃⳆnumeric.ꕺⳆuseꓽᎡ

open System
open System.Collections.Concurrent
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
            let ``ꖹ⭎⭏``=
                new ConcurrentStack<ᐪᎶ<'t>>()

            let mutable ``ꘖ🢕``: ᐪᎶ<'t>=
                [|Ꭱᘁ ᱳ; Ꭱᘁ ᱳ; Ꭱᘁ ᱳ; Ꭱᘁ ᱳ|]

            let ``ꘖ꘎``=
                [|Ꭱᘁ ᱳ; Ꭱᘁ ᱳ; Ꭱᘁ ᱳ; Ꭱᘁ ᱳ|]

            let ``ꘖ₀``=
                fun () ->
                    do ``ꘖ꘎``[0] <- Ꭱᘁ ᱳ
                    do ``ꘖ꘎``[1] <- Ꭱᘁ ᱳ
                    do ``ꘖ꘎``[2] <- Ꭱᘁ ᱳ
                    do ``ꘖ꘎``[3] <- Ꭱᘁ ᱳ

            let ``ꘖ⮐``
                (φ: ``ᑉᎶ꘎ᐣ``<'t>)=
                        match φ with
                        | ``ᑉᎶ꘎ᐣꓹλꓸ`` λ -> do ``ꘖ꘎``[0] <- λ
                        | ``ᑉᎶ꘎ᐣꓹλ₁`` λ -> do ``ꘖ꘎``[1] <- λ
                        | ``ᑉᎶ꘎ᐣꓹλ₂`` λ -> do ``ꘖ꘎``[2] <- λ
                        | ``ᑉᎶ꘎ᐣꓹλ₁₂`` λ -> do ``ꘖ꘎``[3] <- λ

            member _.Yield(())= async {
                do! Task.CompletedTask
                    |> Async.AwaitTask
            }

            member _.Zero()= async {
                do! Task.CompletedTask
                    |> Async.AwaitTask
            }

            [<ⵛ("ᐅ")>]
            member _.ᐅ(_, φ)= async {
                let task=
                    fun () ->
                        do ``ꘖ⮐`` φ

                let action=
                    new Action(task)

                do! Task.Run(action)
                    |> Async.AwaitTask
            }

            [<ⵛ("ᐃ")>]
            member _.ᐃ(_, φ)= async {
                let task=
                    fun () ->
                        do ``ꘖ⮐`` φ
                        ``ꖹ⭎⭏``.Push(``ꘖ꘎``)

                        do ``ꘖ₀`` ()

                let action=
                    new Action(task)

                do! Task.Run(action)
                    |> Async.AwaitTask
            }

            [<ⵛ("ꕕ")>]
            member _.ꕕ(_, φ)= async {
                let task=
                    fun () ->
                        do ``ꘖ⮐`` φ

                        do ``ꖹ⭎⭏``.TryPop(&``ꘖ🢕``)
                        |> ignore

                        let ψ=
                            ``ꕕ`` ``ꘖ🢕`` ``ꘖ꘎``

                        ``ꖹ⭎⭏``.Push(ψ)

                        do ``ꘖ₀`` ()

                let action=
                    new Action(task)

                do! Task.Run(action)
                    |> Async.AwaitTask
            }