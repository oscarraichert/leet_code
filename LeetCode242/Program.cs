bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length) return false;
    
    var dict1 = MakeStringDict(s);

    var dict2 = MakeStringDict(t);

    foreach (var entry in dict1)
    {
        if (dict2.ContainsKey(entry.Key) && dict2[entry.Key] == entry.Value)
        {
            continue;
        }
        else return false;
    }
    
    return true;
}

Dictionary<char, int> MakeStringDict(string s1)
{
    return s1.Aggregate(new Dictionary<char, int>(), (x, y) =>
    {
        if (!x.TryAdd(y, 1))
        {
            x[y] += 1;
        }

        return x;
    });
}