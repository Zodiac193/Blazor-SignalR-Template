namespace Blazor_Server_App.Data;

public class DemoProduct 
{
    public int Value1 { get; set; }
    public int Value2 { get; set; }
    public DemoProduct()
    {
        Value1 = Random.Shared.Next(1, 1000);
        Value2 = Random.Shared.Next(1, 1000);
    }
}
