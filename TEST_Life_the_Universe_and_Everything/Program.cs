namespace TEST_Life_the_Universe_and_Everything;

class Program
{
    static void Main(string[] args)
    {
        string line;
        string input = "";
        while ( !string.IsNullOrEmpty(line=Console.ReadLine()))
        {
            input += line+"/n";
        }
        var arr = input.Split("/n");
        
        foreach (var s in arr)
        {
            if (s == "42")
                break;
            Console.WriteLine(s);
        }

    }
}