// ts2fable 0.0.0
module rec #278-typeliterals-return
open System
open Fable.Core
open Fable.Core.JS

let [<Import("TypeLiteralsAsReturnValue","#278-typeliterals-return")>] typeLiteralsAsReturnValue: TypeLiteralsAsReturnValue.IExports = jsNative

module TypeLiteralsAsReturnValue =

    type [<AllowNullLiteral>] IExports =
        abstract Class: ClassStatic

    type [<AllowNullLiteral>] Class =
        /// This should generate two interfaces: 'Class' and 'ClassFooReturn'. The second should have a single property 'i'.
        abstract Foo: unit -> ClassFooReturn

    type [<AllowNullLiteral>] ClassFooReturn =
        abstract i: float with get, set

    type [<AllowNullLiteral>] ClassStatic =
        [<EmitConstructor>] abstract Create: unit -> Class
