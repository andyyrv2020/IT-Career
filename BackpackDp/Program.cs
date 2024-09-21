int sum = int.Parse(Console.ReadLine());
int[] nominals = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] dp= new int[nominals.Length];
dp[0] = 0;
dp[1] = 1;


for (int i = 2; i <= sum; i++)
{
    int min = int.MaxValue;
    foreach (var nominal in nominals)
    {
        if (i - nominal >= 0)
        {
            if (dp[i - nominal] < min)
            {
                min = dp[i - nominal];
            }
        }
    }
}
