module Index


open Giraffe.ViewEngine

let index =
    [
        section [_class "hero is-primary"] [
            div [_class "hero-body"] [
                div [_class "container"] [
                    div [_class "columns is-vcentered"] [
                        div [_class "column"] [
                            p [_class "title"] [rawText "Welcome to Saturn!"]
                            p [_class "subtitle"] [rawText "Opinionated, web development framework for F# which implements the server-side, functional MVC pattern"]
                        ]
                    ]
                ]
            ]
        ]
        a [_class "title"; _href "/otherView" ] [rawText "OtherView"]
    ]

let layout =
    App.layout index
