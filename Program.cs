namespace Assignment_5._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of steps (n): ");
            int n = int.Parse(Console.ReadLine());

            int ways = ClimbStairs(n);
            Console.WriteLine($"There are {ways} distinct ways to climb to the top.");
        }

        static int ClimbStairs(int n)
        {
            if (n <= 1) return 1;

            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }

}
