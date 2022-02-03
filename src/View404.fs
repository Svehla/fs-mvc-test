module View.V404

open Giraffe.ViewEngine


let index () =
  Layout.layout [
    h1 [] [ encodedText "404 Page not found" ]

    div [] [
        a [
        _href "/"
      ] [ encodedText "go home"]
    ]
  ]
