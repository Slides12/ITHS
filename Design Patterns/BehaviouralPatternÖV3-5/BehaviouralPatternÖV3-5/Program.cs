using BehaviouralPatternÖV3_5.Classes;

var stock = new StockEvent("AAPL", 150);
var anna = new InvestorEvent("Anna");
var bjorn = new InvestorEvent("Bjorn");


anna.Subscribe(stock);
bjorn.Subscribe(stock);
stock.Price = 155;
stock.Price = 160;
