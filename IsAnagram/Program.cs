namespace Program
{
    static class Program
    {
        static void Main()
        {
            string a = "abcd";
            string b = "bcda";

            var isTrue = IsAnagram(a, b);
            Console.WriteLine($"{isTrue}");
            Console.ReadKey();
        }

        static bool IsAnagram(this string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            if (a == b)
                return true;

            return a.OrderBy(c => c).SequenceEqual(b.OrderBy(c => c));
        }
    }
}

