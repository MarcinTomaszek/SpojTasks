using System.Text;
int len = int.Parse(Console.ReadLine());
var output = new StringBuilder();
for (int i = 0; i < len; i++)
{
    long n = long.Parse(Console.ReadLine());
    if (n == 1)
    {
        output.AppendLine("0");
        continue;
    }
    long result = (long)Math.Ceiling((-1 + Math.Sqrt(8 * (n - 1))) / 2);
    output.AppendLine(result.ToString());
}
Console.Write(output);