namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"max","glez","lalaine","izza","nina","greta" };

            string[] newname = names;
            Console.WriteLine(newname);


            string sentence = "Who let the dog out aw aw aw";

            Console.WriteLine(sentence.Substring(16,3));
        }
    }
}