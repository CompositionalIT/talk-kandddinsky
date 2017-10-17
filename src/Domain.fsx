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

let sampleLine =
    { Market = ""
      Product = "Perisables"
      Origin = "FRA"
      Destination = "LHR"
      Rate = 0.
      MarketShare = 0
      ShippedLastYear = 0. }

// 1. Let's set the market based on some reference data
type MarketData = { Id : string; BaseAirport : string }
let germany = { Id = "Germany"; BaseAirport = "FRA" }

let setMarket marketData dataRow =
    { dataRow with Market = marketData.BaseAirport }

sampleLine |> setMarket germany