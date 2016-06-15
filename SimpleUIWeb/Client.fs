namespace SimpleUIWeb

open WebSharper
open WebSharper.Resources
open WebSharper.JavaScript

module Resources =
    
    type Fontawesome() =
        inherit BaseResource("https://use.fontawesome.com/269e7d57ca.js")

    type Css() =
        inherit BaseResource("SimpleUI.css")
    type Js() =
        inherit BaseResource("SimpleUI.js")

    [<assembly:Require(typeof<Fontawesome>);
      assembly:Require(typeof<Css>);
      assembly:Require(typeof<Js>)>]
    do()

[<JavaScript>]
module Client =
    open WebSharper.UI.Next
    open WebSharper.UI.Next.Html
    open WebSharper.UI.Next.Client
    
    let Main =
        Console.Log "Started"
