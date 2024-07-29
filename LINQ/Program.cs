namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<string>() { "Fatal Frame", "Mario Cart Racing", "Red Dead Redemption" };

           myList.OrderBy(name => name.Length);

            foreach(var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
