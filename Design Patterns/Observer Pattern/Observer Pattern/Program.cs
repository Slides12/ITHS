

using Observer_Pattern.Classes;

var investor1 = new Investors("Daniel");
var investor2 = new Investors("Johan");
var investor3 = new Investors("Sven");


var stock1 = new Stock("Investor AB", 200);
var stock2 = new Stock("Swedensia AB", 700);
var stock3 = new Stock("Iths AB", 500);


stock1.Attach(investor1);
stock2.Attach(investor2);
stock3.Attach(investor3);


stock1.ChangePrice(1);
stock2.ChangePrice(1);
stock3.ChangePrice(1);