namespace tech.quagma.ꗃⳆmaths.ꗃⳆgeometry

open tech.quagma.ꗃⳆutils.ꕺⳆuseFSharp

open System
open System.Collections.Concurrent
open System.Threading.Tasks

// complex algebra (p=2, q=0)
module ꕺⳆuseꓽᎶꓹ2ꓹ0=

    [<AutoOpen>]
    module private ꕺⳆprivateꓽᎶꓹ2ꓹ0=
        type ᐪᎶ=
            float array

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
            (u: ᐪᎶ)
            (v: ᐪᎶ)=
                [|1..4|] |> Array.Parallel.map (fun φ ->
                    (Ꮿᵩ φ) |> Array.Parallel.map (fun (i, j, σ) ->
                        u[i] * v[j] * float σ
                    ) |> Array.Parallel.sum
                ): ᐪᎶ

        let ꁘ=
            new ConcurrentDictionary<string, ᐪᎶ>()

// multi-vector in Ꮆ(2, 0)
    type ᑉᎶᐣ= {|
            ``λꓸ``: float; // ᑉeꓸᐣ
            ``λ₁``: float; // ᑉe₁ᐣ
            ``λ₂``: float; // ᑉe₂ᐣ
            ``λ₁₂``: float; // ᑉe₁₂ᐣ
    |}

    type ᐪⳆwithꓽᎶꓹ2ꓹ0()=
            member _.Yield(())= async {
                do! Task.CompletedTask
                    |> Async.AwaitTask
            }

            member _.Zero()= async {
                do! Task.CompletedTask
                    |> Async.AwaitTask
            }

            [<ⵛ("ᐅ")>]
            member _.ᐅ(_, ᐠ1, ᐠ2)= async {
                let name: string= ᐠ1
                let element: ᑉᎶᐣ= ᐠ2

                ꁘ[name] <- [|
                    element.``λꓸ``;
                    element.``λ₁``;
                    element.``λ₂``;
                    element.``λ₁₂``;
                |]

                do! Task.CompletedTask
                    |> Async.AwaitTask
            }

    let ᐞⳆwithꓽᎶꓹ2ꓹ0=
        ᐪⳆwithꓽᎶꓹ2ꓹ0()