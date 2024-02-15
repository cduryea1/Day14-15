//MIS 3033
//LC P 2-14-2-15
//113529005
//Camille Duryea

using b;

Console.WriteLine("DB");

OrderDB db;
db = new OrderDB();

var orders = db.orders.ToList();

for(int i = 0;i<orders.Count; i++)
{
    Console.WriteLine(orders[i]);
}

