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

    type ᑉᎶᐣ<'t>=
        | ``ᑉᎶ₀ᐣ``
                of {|
                    ``λꓸ``: ᐪᎡ<'t>;
                    // blade-0
                |}
        | ``ᑉᎶ₁ᐣ``
                of {|
                    ``λ₁``: ᐪᎡ<'t>;
                    ``λ₂``: ᐪᎡ<'t>;
                    // blade-1
                |}
        | ``ᑉᎶ₂ᐣ``
                of {|
                    ``λ₁₂``: ᐪᎡ<'t>;
                    // blade-2
                |}
        | ``ᑉᎶ꘎ᐣ``
                of {|
                    ``λꓸ``: ᐪᎡ<'t>;
                    ``λ₁``: ᐪᎡ<'t>;
                    ``λ₂``: ᐪᎡ<'t>;
                    ``λ₁₂``: ᐪᎡ<'t>;
                    // multi-vector
                |}

    type withꓽᎶꓹ2ꓹ0<'t>()=
            let ꁘ=
                new ConcurrentDictionary<string, ᐪᎶ<'t>>()

            let ᖽᖼ=
                new ConcurrentStack<ᐪᎶ<'t>>()

            member _.Yield(())= async {
                do! Task.CompletedTask
                    |> Async.AwaitTask
            }

            member _.Zero()= async {
                do! Task.CompletedTask
                    |> Async.AwaitTask
            }

            [<ⵛ("ᐅ")>]
            member _.ᐅ(_, ᐠ1)= async {
                let task=
                    fun () ->
                        let item=
                            match ᐠ1 with
                            | ``ᑉᎶ₀ᐣ`` ᑉuᐣ -> [|ᑉuᐣ.``λꓸ``;       Ꭱᘁ ᱳ;      Ꭱᘁ ᱳ;       Ꭱᘁ ᱳ|]
                            | ``ᑉᎶ₁ᐣ`` ᑉuᐣ -> [|     Ꭱᘁ ᱳ; ᑉuᐣ.``λ₁``; ᑉuᐣ.``λ₂``;       Ꭱᘁ ᱳ|]
                            | ``ᑉᎶ₂ᐣ`` ᑉuᐣ -> [|     Ꭱᘁ ᱳ;       Ꭱᘁ ᱳ;      Ꭱᘁ ᱳ; ᑉuᐣ.``λ₁₂``|]
                            | ``ᑉᎶ꘎ᐣ`` ᑉuᐣ -> [|ᑉuᐣ.``λꓸ``; ᑉuᐣ.``λ₁``; ᑉuᐣ.``λ₂``; ᑉuᐣ.``λ₁₂``|]

                        ᖽᖼ.Push(item)

                let action=
                    new Action(task)

                do! Task.Run(action)
                    |> Async.AwaitTask
            }