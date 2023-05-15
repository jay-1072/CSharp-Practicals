public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
                
        try
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"\nValue at index {i} is {arr[i]}");
            }
        }
        catch( IndexOutOfRangeException e )
        {
            Console.WriteLine($"\n{e.Message}");
        }
        finally
        {
            Console.WriteLine($"\nThis is finally block");
        }          
    }
}