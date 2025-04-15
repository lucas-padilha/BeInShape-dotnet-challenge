using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using BeInShape_Events;

Console.WriteLine("Hello, World!");

BeInShape_Events.BankOperation bankOperation = new BankOperation();
BeInShape_Events.BusinessOperation businessOperation = new BusinessOperation();

// symple call to the methods
System.Console.WriteLine("Simple call to the methods");
bankOperation.GetBalance();
bankOperation.Extract();
bankOperation.Transfer(100);
bankOperation.CashOut(200);
bankOperation.CashIn(300);

System.Console.WriteLine("Delegated call to the methods");
// using delegates to call the methods
DelegatedEvents.ExecuteBankOperation(bankOperation.GetBalance);
DelegatedEvents.ExecuteBankOperation(bankOperation.Transfer, 120);

DelegatedEvents.ExecuteBusinessPayment(businessOperation.BillsPayment, "Water", 100);
DelegatedEvents.ExecuteAllPayments();


