namespace global

type Airport = Airport of string
type Market = Market of string
type Product =
    | Perishables
    | Standard
    | Express

[<Measure>] type Kg
[<Measure>] type Euro
[<Measure>] type Percent

type MarketData =
    { Id : string
      BaseAirport : string
      TransportedLastYear : float
      RevenueEarnedLastYear : float }

module Airports =
    let FRA = Airport "FRA"
    let LHR = Airport "LHR"

[<AutoOpen>]
module Helpers =
    let percent (v:int) = v * 1<Percent>