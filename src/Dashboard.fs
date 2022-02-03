module View.Dashboard
open Giraffe.ViewEngine

type Message = {
  Text : string
}

let index (model : Message) =
  [
    h1 [] [ encodedText "HTTP app"]
    p [] [ encodedText model.Text ]
    div [] [
      a [
        _href "/hello/a"
      ] [ encodedText "hello a"]
    ]
    div [] [
      a [
        _href "/hello/kuba"
      ] [ encodedText "hello kuba"]
    ]
    div [] [
      a [
        _href "/helllllo/kuba"
      ] [ encodedText "test 404 route"]
    ]
  ] |> Layout.layout
