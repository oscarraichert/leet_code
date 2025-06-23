public class AtoI
{
    public static int Atoi(string s)
    {
        var trimmed = s.Trim();

        if (string.IsNullOrEmpty(trimmed))
        {
            return 0;
        }

        var validNum = new List<long>();

        for (int i = 0; i < trimmed.Length; i++)
        {
            if (i == 0 && (trimmed[i] == '-' || trimmed[i] == '+'))
            {
                continue;
            }

            if (trimmed[i] < '0' || trimmed[i] > '9')
            {
                break;
            }

            validNum.Add(trimmed[i] - '0');
        }

        for (int i = 0; i < validNum.Count; i++)
        {
            validNum[validNum.Count - i - 1] *= (int)MathF.Pow(10, i);
        }

        var result = validNum.Sum();

        if (trimmed[0] == '-')
        {
            result *= -1;
        }

        if (result > int.MaxValue)
        {
            return int.MaxValue;
        }

        if (result < int.MinValue)
        {
            return int.MinValue;
        }

        return (int)result;
    }
}