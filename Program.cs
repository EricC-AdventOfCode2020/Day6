namespace Day6;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<char, int> charIndex = new()
        {
            {'a', 0},
            {'b', 1},
            {'c', 2},
            {'d', 3},
            {'e', 4},
            {'f', 5},
            {'g', 6},
            {'h', 7},
            {'i', 8},
            {'j', 9},
            {'k', 10},
            {'l', 11},
            {'m', 12},
            {'n', 13},
            {'o', 14},
            {'p', 15},
            {'q', 16},
            {'r', 17},
            {'s', 18},
            {'t', 19},
            {'u', 20},
            {'v', 21},
            {'w', 22},
            {'x', 23},
            {'y', 24},
            {'z', 25},
        };
        string[] data = File.ReadAllLines(@".\input");

        bool[] present = new bool[26];

        int result = 0;
        string line = "";
        for (int i = 0; i < data.Length; i++)
        {
            for (int j = 0; j < data[i].Length; j++)
            {
                if (!present[charIndex[data[i][j]]])
                    present[charIndex[data[i][j]]] = true;
            }

            if (data[i] == "" || i == data.Length - 1)
            {
                for (int j = 0; j < present.Length; j++)
                {
                    if (present[j])
                        result += 1;
                    
                    present[j] = false;
                }
            }
        }

        Console.WriteLine(result);
    }
}