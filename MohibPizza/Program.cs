using System.Text;

int len = int.Parse(Console.ReadLine());
var output = new StringBuilder();
for (int i = 0; i < len; i++)
{
    int n = int.Parse(Console.ReadLine());
    long result = (long)n * (n + 1) / 2 + 1;
    output.AppendLine(result.ToString());
}
Console.Write(output);