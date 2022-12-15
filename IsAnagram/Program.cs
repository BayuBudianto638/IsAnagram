//namespace Program
//{
//    static class Program
//    {
//        static void Main()
//        {
//            string[] demo = new string[] {
//              "stream", "pigeon", "maters",
//              "enlists", "google", "inlets", "bana  na",
//              "gallery", "ballerina", "regally", "clergy", "largely", "leading",
//              "art", "tar", "rat"
//            };

//            string report = string.Join(Environment.NewLine, FindAnagrams(demo)
//              .Select(group => string.Join(", ", group)));

//            Console.Write(report);

//            //string a = "abcd";
//            //string b = "bcda";

//            //var isTrue = IsAnagram(a, b);
//            //Console.WriteLine($"{isTrue}");
//            //Console.ReadKey();
//        }

//        public static IEnumerable<string[]> FindAnagrams(IEnumerable<string> candidates)
//        {
//            if (null == candidates)
//                throw new ArgumentNullException(nameof(candidates));

//            return candidates
//              .GroupBy(word => string.Concat(word.OrderBy(c => c)))
//              .Where(group => group.Count() > 1)
//              .Select(group => group.OrderBy(word => word).ToArray());
//        }

//        //static bool IsAnagram(this string a, string b)
//        //{
//        //    if (a.Length != b.Length)
//        //        return false;

//        //    if (a == b)
//        //        return true;

//        //    return a.OrderBy(c => c).SequenceEqual(b.OrderBy(c => c));
//        //}
//    }
//}

//namespace Program
//{
//    static class Program
//    {
//        static void Main()
//        {
//            string[] arr = new string[] {
//              "cook", "save", "taste","aves","state","map"
//            };

//            string AnagramList = string.Join(Environment.NewLine, FindAnagrams(arr)
//              .Select(group => string.Join(", ", group)));

//            Console.Write(AnagramList);
//        }

//        public static IEnumerable<string[]> FindAnagrams(IEnumerable<string> arr)
//        {
//            if (null == arr)
//                throw new ArgumentNullException(nameof(arr));

//            return arr
//              .GroupBy(word => string.Concat(word.OrderBy(c => c)))
//              .Where(group => group.Count() > 0)
//              .Select(group => group.OrderBy(word => word).ToArray());
//        }
//    }
//}

class Program
{
    static void Main()
    {
        string[] arr = new string[] {
              "cook", "save", "taste","aves","state","map"
            };

        string[] AnagramList = { };
        int i = 0;
        foreach (var itemArr in arr)
        {
            AnagramList = FindAnagram(itemArr, arr);

            foreach (var itemList in AnagramList)
            {
                Console.WriteLine(itemList);
            }
        }
    }

    public static string[] FindAnagram(string word, string[] arr)
    {
        if (word == null || arr == null)
            return new string[0];

        char[] keyArray = word.ToCharArray();

        Array.Sort(keyArray);

        string key = string.Concat(keyArray);

        List<string> list = new List<string>();

        foreach (string w in arr)
        {
            char[] wArray = w.ToCharArray();

            Array.Sort(wArray);

            string wKey = string.Concat(wArray);

            if (string.Equals(wKey, key, StringComparison.OrdinalIgnoreCase))
                list.Add(w);
        }

        string[] result = new string[list.Count];

        for (int i = 0; i < list.Count; ++i)
            result[i] = list[i];

        return result;
    }
}