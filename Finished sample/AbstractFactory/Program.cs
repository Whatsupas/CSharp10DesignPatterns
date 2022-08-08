using AbstractFactory;

var belgiumShoppingCartPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();
var shoppingCartForBelgium = new ShoppingCart(belgiumShoppingCartPurchaseFactory);
shoppingCartForBelgium.CalculateCosts();

var franceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
var shoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);
shoppingCartForFrance.CalculateCosts();

var hybridShoppingCartPurchaseFactory = new HybridShoppingCartPurchaseFactory();
var shoppingCartForHybrid = new ShoppingCart(hybridShoppingCartPurchaseFactory);
shoppingCartForHybrid.CalculateCosts();

Console.ReadKey(); 