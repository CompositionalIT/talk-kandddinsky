#load "Domain.fsx"
open System

type RateLine =
    { /// The name of the Market e.g. Germany.
      Market : string
      /// The type of product offered e.g. "standard", "perishable" etc.
      Product : string
      /// The origin airport.
      Origin : string
      /// The destination airport.
      Destination : string
      /// The rate charged for shipping, in euros per KG.
      Rate : float
      /// The market share compared to other shippers as a percentage.
      MarketShare : int
      /// The total weight that was shipped last year on this route.
      ShippedLastYear : float }

let germany =
    { Id = "Germany"
      BaseAirport = "FRA"
      TransportedLastYear = 5000.
      RevenueEarnedLastYear = 10000. }

let sampleLine =
    { Market = germany.BaseAirport
      Product = "Perisables"
      Origin = "FRA"
      Destination = "LHR"
      Rate = germany.TransportedLastYear / germany.RevenueEarnedLastYear
      MarketShare = 12
      ShippedLastYear = germany.RevenueEarnedLastYear }