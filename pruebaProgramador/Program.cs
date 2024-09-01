// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool isEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    return false;
}

int squared(int number)
{
    return (number * number);
}

Dictionary<char, int> fillDictionary(String word)
{
    word = word.ToLower().Replace(" ", "");
    Console.WriteLine(word);
    Dictionary<char, int> map = new Dictionary<char, int>();
    foreach (char c in word)
    {
        if (!map.ContainsKey(c))
        {
            map.Add(c, 1);
        }
        else
        {
            map[c]++;
        }
    }
    return map;
}

bool isAnagram(String word1, String word2)
{
    Dictionary<char, int> map = new Dictionary<char, int>();
    Dictionary<char, int> map2 = new Dictionary<char, int>();

    map = fillDictionary(word1);
    map2 = fillDictionary(word2);
    
    return map.Count == map2.Count && !map.Except(map2).Any();
}
Console.WriteLine(isEven(2));
Console.WriteLine(squared(2));
Console.WriteLine(isAnagram("Fotolitografía  ", "Litofotografía"));