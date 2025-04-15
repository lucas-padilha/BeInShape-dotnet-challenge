namespace BeInShape_Events;

public class BusinessOperation
{
    public BusinessOperation()
    {
        
    }

    public void BillsPayment(string type, decimal value){
        System.Console.WriteLine("Paying bills... {0} | Value: {1}", type, value);
    }        
    public void EmployerPayment(decimal value){
        System.Console.WriteLine("Transferring money... {0}", value);        
    }    
    public void SellerPayment(string sellername, decimal value){
        System.Console.WriteLine("Seller: {0} | Value: {1}",sellername, value);                
    }
    public void ClientsInvoice(string clientname, string typeBill, decimal value){
        System.Console.WriteLine("Client {0} | Type: {1} | Value: {2}",clientname, typeBill, value);
    }
    public void BusinessReport(){
        System.Console.WriteLine("Data reporting...");
    }
}
