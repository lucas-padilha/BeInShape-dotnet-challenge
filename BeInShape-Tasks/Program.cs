async Task Task1(CancellationToken cancellationToken)
{
    Console.WriteLine("Task 1 initiated");
    try
    {
        cancellationToken.ThrowIfCancellationRequested();
        await Task.Delay(8000, cancellationToken);
        Console.WriteLine("Task 1 completed");

    }
    catch (OperationCanceledException ex)
    {
        System.Console.WriteLine($"Task 1 was canceled: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Task 1 failed: {ex.Message}");
    }    
}

async Task Task2(CancellationToken cancellationToken)
{
    Console.WriteLine("Task 2 initiated");
    try
    {
        cancellationToken.ThrowIfCancellationRequested();
        await Task.Delay(5000, cancellationToken);
        Console.WriteLine("Task 2 completed");
    }
    catch (OperationCanceledException ex)
    {
        System.Console.WriteLine($"Task 2 was canceled: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Task 2 failed: {ex.Message}");
    }    
}
System.Console.WriteLine("Case 1: Executing tasks");

var cancellationTokenSource = new CancellationTokenSource();

await Task.WhenAll(Task1(cancellationTokenSource.Token), Task2(cancellationTokenSource.Token));

await Task.Delay(500).ContinueWith(_ => { System.Console.WriteLine("Case 2: Executing tasks and canceling them"); });

Task tasks = Task.WhenAll(
    Task1(cancellationTokenSource.Token),
    Task2(cancellationTokenSource.Token)
);

_ = Task.Delay(500).ContinueWith(_ => cancellationTokenSource.Cancel());
Console.ReadKey();