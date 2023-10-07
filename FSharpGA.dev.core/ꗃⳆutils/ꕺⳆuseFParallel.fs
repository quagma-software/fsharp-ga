namespace tech.quagma.ꗃⳆutils

open System
open System.Threading.Tasks

[<AutoOpen>]
module ꕺⳆuseFParallel=

    type testParallel()=
            member _.Zero()= async {
                ()
            }

            member _.Yield(())= async {
                ()
            }

            member _.Bind(``𝓍``, ƒ)= async {
                let! x=
                    ``𝓍``

                return!
                    ƒ x
            }

            //member _.Return(``𝓍``)= async {
            //    return
            //        ``𝓍``
            //}

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

            member _.For(``i꘎``, ƒ)= async {
                let! _=
                    ``i꘎``
                    |> Seq.toArray
                    |> Array.Parallel.map ƒ
                    |> Async.Parallel

                ()
            }

            [<ⵛ("ᘛⵑᘚ")>]
            member _.ᘛⵑᘚ(a, b)= async {
                return
                    ()
            }