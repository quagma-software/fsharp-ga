namespace tech.quagma.ꗃⳆutils

open FSharp.Control

open System
open System.Threading.Tasks

[<AutoOpen>]
module ꕺⳆuseFParallel=

    type testParallel2()=
        // 'T is Async<'t>
        // M<'T> is AsyncSeq<'t>
            member _.Zero()=
                AsyncSeq.empty

            member _.Yield(``ℯ``)= asyncSeq {
                let! e=
                    ``ℯ``
                yield
                    e
            }

            //member _.YieldFrom(``ℯ꘎``)=
            //    ``ℯ꘎``

            //member _.Bind(``𝓍``, ƒ)= asyncSeq {
            //    let! x=
            //        ``𝓍``

            //    yield!
            //        ƒ x
            //}

            //member _.Return(``𝓍``)= asyncSeq {
            //    yield
            //        ``𝓍``
            //}

            member _.Delay(f)=
                f ()

            //member _.Run(f)=
            //    f()

            member _.Combine(u, v)=
                AsyncSeq.merge u v

            //member _.For(``i꘎``, ƒ)= async {
            //    let task=
            //        fun () ->
            //            Console.WriteLine("--1")

            //            //let f=
            //            //    fun (i) -> async {
            //            //        Console.WriteLine("--2")
            //            //        let! ꕺ=
            //            //            ƒ i

            //            //        ꕺ
            //            //    }

            //            let ꕺ=
            //                ``i꘎``
            //                |> Seq.toArray
            //                |> Array.Parallel.map ƒ
            //                |> Async.Parallel

            //            Console.WriteLine(ꕺ)

            //            ꕺ

            //    let! ꕺ=
            //        Task.Run(ꗓ(task))
            //        |> Async.AwaitTask

            //    ()
            //}

            member _.For(``i꘎``: 'a seq, ƒ: 'a -> Async<'b>)=
                    ``i꘎``
                    |> AsyncSeq.ofSeq
                    |> AsyncSeq.mapAsyncParallel ƒ

            //[<ⵛ("ᘛⵑᘚ", MaintainsVariableSpaceUsingBind= true)>]
            //member _.ᘛⵑᘚ(a, b)= async {
            //    let! _= a

            //    Console.WriteLine(b: string)
                
            //    return
            //        ()
            //}

    type ꘈ()=
            member _.Zero()=
                AsyncSeq.empty

            member _.Yield(_)=
                AsyncSeq.empty

            [<ⵛ("ꘈᐊ")>]
            member _.ꘈᐊ(iꁘ, jꁘ)=
                AsyncSeq.merge iꁘ
                <| AsyncSeq.ofSeq jꁘ

            [<ⵛ("ꘈᐅ")>]
            member _.ꘈᐅ(iꁘ, ƒ)=
                iꁘ |> AsyncSeq.mapAsyncParallel ƒ

            [<ⵛ("ᐁ")>]
            member _.ᐁ(eꁘ, _)=
                eꁘ |> AsyncSeq.iterAsyncParallel (fun (e) -> async {()})