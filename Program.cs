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

        Dictionary<int, char> indexChar = new()
        {
            {0,'a'},
            {1,'b'},
            {2,'c'},
            {3,'d'},
            {4,'e'},
            {5,'f'},
            {6,'g'},
            {7,'h'},
            {8,'i'},
            {9,'j'},
            {10,'k'},
            {11,'l'},
            {12,'m'},
            {13,'n'},
            {14,'o'},
            {15,'p'},
            {16,'q'},
            {17,'r'},
            {18,'s'},
            {19,'t'},
            {20,'u'},
            {21,'v'},
            {22,'w'},
            {23,'x'},
            {24,'y'},
            {25,'z'},
        };
        string[] data = File.ReadAllLines(@".\input");

        bool[] present = new bool[26];

        int result = 0;
        List<string> lines = new();
        for (int i = 0; i < data.Length; i++)
        {
            for (int j = 0; j < data[i].Length; j++)
            {
                if ((i != 0 && data[i - 1] == "") || i == 0)
                {
                    if (!present[charIndex[data[i][j]]])
                        present[charIndex[data[i][j]]] = true;
                }
                else
                {
                    for (int k = 0; k < present.Length; k++)
                    {
                        if (present[k])
                        {
                            if (!data[i].Contains(indexChar[k]))
                                present[k] = false;
                        }
                    }
                }
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