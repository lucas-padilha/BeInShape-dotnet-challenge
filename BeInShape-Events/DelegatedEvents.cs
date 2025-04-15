
namespace BeInShape_Events
{
    public delegate void BankGetOperationDelegate();
    public delegate void BankActOperationDelegate(decimal act);

    public delegate void BusinessOperationPayment(string arg1, decimal arg2);
    public delegate void BusinessOperationInvoice (string arg1, string arg2, decimal arg3);
   
    public class DelegatedEvents
    {
        public static void ExecuteBankOperation(BankGetOperationDelegate getOperation)
        {
            getOperation();  
        }
        public static void ExecuteBankOperation(BankActOperationDelegate actOperation, decimal value)
        {
            actOperation(value);
        }        

        public static void ExecuteBusinessPayment(BusinessOperationPayment businessPayment, string typeBill, decimal value)
        {
            businessPayment(typeBill, value);
        }
        public static void ExecuteBusinessInvoice(BusinessOperationInvoice businessInvoice, string clientname, string typeBill, decimal value)
        {
            businessInvoice(clientname, typeBill, value);
        }

        public static void ExecuteAllPayments()
        {
            System.Console.WriteLine("Executing all payments...");
            BusinessOperation businessOperationInstance = new BusinessOperation();
            BusinessOperationPayment payments = (seller, value) => { businessOperationInstance.SellerPayment("Seller", value);};
            payments += businessOperationInstance.BillsPayment;
            payments += (arg, value) => { businessOperationInstance.EmployerPayment(value); };
            payments += delegate (string arg, decimal value) { businessOperationInstance.ClientsInvoice(arg, "Client Billing", value); };
            
            payments("Energy", 100);            
        }

    }
}