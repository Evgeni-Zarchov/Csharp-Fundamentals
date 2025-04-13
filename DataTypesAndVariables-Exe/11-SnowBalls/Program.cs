using System.Numerics;

int n = int.Parse(Console.ReadLine());
string bestSnowBall = "";
BigInteger currentBestSnowBall = int.MinValue;

for (int i = 0; i < n; i++)
{
    BigInteger snowBall = BigInteger.Parse(Console.ReadLine());
    BigInteger snowBallTime = BigInteger.Parse(Console.ReadLine());
    int snowBallQuality = int.Parse(Console.ReadLine());

    BigInteger currentSnowBall = snowBall / snowBallTime;
    BigInteger bestSnowBallQuality = BigInteger.Pow(currentSnowBall, snowBallQuality);

    if (bestSnowBallQuality > currentBestSnowBall)
    {
        currentBestSnowBall = bestSnowBallQuality;

        bestSnowBall = ($"{snowBall} : {snowBallTime} = {bestSnowBallQuality} ({snowBallQuality})");
    }

}
Console.WriteLine(bestSnowBall);