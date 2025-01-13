using System.Text;

int T = int.Parse(Console.ReadLine());

var testCases = new List<int>();
for (int i = 0; i < T; i++)
{
    testCases.Add(int.Parse(Console.ReadLine()));
}

const int maxN = 1000000;
var isPrime = new bool[maxN + 1];
var primes = new List<int>();

for (int i = 2; i <= maxN; i++) isPrime[i] = true;
for (int i = 2; i * i <= maxN; i++)
{
    if (isPrime[i])
    {
        for (int j = i * i; j <= maxN; j += i)
        {
            isPrime[j] = false;
        }
    }
}

for (int i = 2; i <= maxN; i++)
{
    if (isPrime[i]) primes.Add(i);
}
var output = new StringBuilder();
for (int t = 0; t < T; t++)
{
    int n = testCases[t];
    var factors = new SortedSet<int>();
    foreach (int prime in primes)
    {
        if (prime * prime > n) break;
        if (n % prime == 0)
        {
            factors.Add(prime);
            while (n % prime == 0) n /= prime;
        }
    }
    if (n > 1) factors.Add(n); 
    output.Append($"Case {t + 1}: ");
    output.AppendLine(string.Join(" ", factors));
}
Console.Write(output);