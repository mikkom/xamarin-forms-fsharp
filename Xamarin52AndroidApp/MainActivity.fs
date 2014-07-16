namespace Xamarin52AndroidApp

open System

open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views

open Xamarin.Forms
open Xamarin.Forms.Platform.Android

type App () =
    static member GetMainPage () =
        new NavigationPage ()

[<Activity (Label = "Xamarin52AndroidApp", MainLauncher = true)>]
type MainActivity () =
    inherit AndroidActivity ()

    override this.OnCreate (bundle) =
        base.OnCreate (bundle)
        Forms.Init (this, bundle)
        this.SetPage <| App.GetMainPage ()
