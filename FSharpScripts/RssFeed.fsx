#r "System.Xml.Linq.dll"

open System.Net
open System.Xml.Linq

let feed = "http://feeds.bbci.co.uk/news/uk/rss.xml"

// make this async?
let downloadString (url : string) =
    let webClient = new WebClient()
    let content = webClient.DownloadString url
    content

let xn s = XName.Get s
let getVal (element : XElement) name = element.Element(xn name).Value

let rssXml = downloadString feed |> XDocument.Parse

let items =
    rssXml.Descendants (xn "item")
    |> Seq.map  (fun el -> (getVal el "title", getVal el "description"))

Seq.iter (fun (t, d) -> printfn "%s : %s" t d) items 
