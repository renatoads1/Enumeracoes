using Enumeracoes.Entities;
using System.Globalization;
using Enumeracoes.Enum;
//EXE2
Console.WriteLine("Entre department name");
string departmentName = Console.ReadLine();
Console.WriteLine("Entre worker name");
string workerName = Console.ReadLine();
Console.WriteLine("Entre worker level");
string workerLevel = Console.ReadLine();
Console.WriteLine("Entre base salary");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Quantos contratos tem esse trabalhador?");
int n = int.Parse(Console.ReadLine());
WorkerLevel level = Enum.Parse<WorkerLevel>(workerLevel);

Department dep = new Department(departmentName);
Worker worker = new Worker(workerName, baseSalary, level, dep);
Console.WriteLine("hou many contracts for this worker? ");
int contracts = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++) {
    Console.WriteLine($"Enter {i} contract");
    Console.WriteLine("Date:(dd/MM/yyyy)");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Value per hour");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Duration Hours");
    int hours = int.Parse(Console.ReadLine());
    HourContract contract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(contract);
}

Console.WriteLine("Entre year and month to calculate income (yyyy-MM)");
string yearAndMonth = Console.ReadLine();
int year = int.Parse(yearAndMonth.Substring(0,2));
int month = int.Parse(yearAndMonth.Substring(3,4));
double income = worker.CalculateIncome(year, month);
Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: " + worker.Department.Name);
Console.WriteLine("Income for " + yearAndMonth + ": " + income.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Contracts: ");
Console.WriteLine( income.ToString("F2", CultureInfo.InvariantCulture));


//EXE1
//Order order = new Order
//{
//    Id = 1,
//    Product = "Laptop",
//    Quantity = 2,
//    Price = 1500.00,
//    Status = OrderStatus.Processing
//};
//Console.WriteLine(order.ToString());

//string st = OrderStatus.PendingPayment.ToString();
//Console.WriteLine(st);

//OrderStatus os = Enum.Parse<OrderStatus>("Shipped");
//Console.WriteLine(os.ToString());