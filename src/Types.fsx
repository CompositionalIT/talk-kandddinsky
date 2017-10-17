namespace global

type Airport = Airport of string
type Market = Market of string
type Product =
    | Perishables
    | Standard
    | Express

type MarketData =
    { Id : string
      BaseAirport : string
      TransportedLastYear : float
      RevenueEarnedLastYear : float }

module Airports =
    let FRA = Airport "FRA"
    let LHR = Airport "LHR"