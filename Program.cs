//variables

using System.ComponentModel.DataAnnotations;

int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;

const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

System.Console.WriteLine("How many sandwiches?");
numberOfSandwiches = int.Parse(Console.ReadLine());

System.Console.WriteLine("How many toppings?");
numberOfToppings = int.Parse(Console.ReadLine());

System.Console.WriteLine("How much would you like to tip?");
tip = double.Parse(Console.ReadLine());

double totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;

double totalToppingCost = COST_OF_TOPPING * numberOfToppings;

double baseCost = totalSandwichCost + totalToppingCost;

double orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);
orderCost = Math.Round (orderCost, 2);

System.Console.WriteLine("Your order cost is $" + orderCost);

