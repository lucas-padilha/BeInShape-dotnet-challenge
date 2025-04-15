namespace BeInShape_Events;

public class BankOperation
{
    private decimal balance;
    private List<ExtractAction> extractActions = new List<ExtractAction>();
    public BankOperation()
    {
        balance = 100;
        extractActions.Add(new ExtractAction { 
            Data = DateTime.Now,
            Description = "Initial Balance", 
            Operation = 0, 
            Value = balance 
        }); 
    }

    public void Extract(){
        System.Console.WriteLine("Extracting money...");
    }        
    public void Transfer(decimal value){
        System.Console.WriteLine("Transferring money... {0}", value);        
    }    
    public void CashOut(decimal value){
        System.Console.WriteLine("Cash out money... {0}", value);                
    }
    public void CashIn(decimal value){
        System.Console.WriteLine("Cash in money... {0}", value);                
    }
    public void GetBalance(){
        System.Console.WriteLine($"Current balance: {balance}");        
    }
}

public class ExtractAction 
{
    public DateTime Data { get; set; }
    public string  Description { get; set; }    
    public int Operation { get; set; }
    public decimal Value { get; set; }
}