namespace FSharpLibrary

open System

// (TimeSpan wrapper record, used by range comprehension)
type TimeSpanWrapper = { Interval : TimeSpan } with
    static member (+)(dt:DateTime, timeSpanWrapper) = dt + timeSpanWrapper.Interval
    static member Zero = { Interval = TimeSpan(0L) }
    
type DateRange =
    
    new() = { }

    member this.DateRange startDate endDate =
        let oneDay = { Interval = TimeSpan(1, 0, 0, 0) }
        seq { startDate .. oneDay .. endDate }

    member this.Weekends (dates:seq<DateTime>) =
        dates
        |> Seq.filter (fun d ->
            match d.DayOfWeek with 
                | DayOfWeek.Saturday | DayOfWeek.Sunday -> true
                | _ -> false )
