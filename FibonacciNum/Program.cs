using System.Numerics;

int n = int.Parse(Console.ReadLine());
BigInteger[] dp = new BigInteger[n + 1];
dp[0] = 0;
dp[1] = 1;
dp[2] = 1;

for (int i = 3; i <= n; i++)
{
    dp[i] = dp[i - 1] + dp[i - 2];
}
Console.WriteLine(dp[n]);