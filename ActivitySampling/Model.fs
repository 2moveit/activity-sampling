namespace ActivitySampling

[<AutoOpen>]
module Model =
    type UtcTimeStamp = System.DateTime

module Commands =
    type LogNewActivity =
        { Activity: string
          ExecutedAt: UtcTimeStamp }


module Events =
    type ActivityLogged =
        { Activity: string
          ExecutedAt: UtcTimeStamp }
