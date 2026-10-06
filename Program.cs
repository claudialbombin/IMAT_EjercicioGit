namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string id = "12345678";
            Console.WriteLine(Add(id[0] - '0', id[^1] - '0'));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
