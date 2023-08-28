Console.WriteLine("*****************************************************");
Console.WriteLine("             Welcome to Starbucks            ");
Console.WriteLine("             Address: 15 St.RoseMerry Road             ");
Console.WriteLine("             Contact Number: +1 476-974-980             ");
Console.WriteLine("             Store Number: 4968             ");
Console.WriteLine("*****************************************************");



// calling facade method to simplify UI/UX, order is a facade class
Order.GetOrder();

Console.WriteLine("\n >>> Thanks for ordering with Starbucks.\n >>> Please visit again!");