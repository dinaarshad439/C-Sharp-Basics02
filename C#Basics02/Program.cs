using System.Text;

namespace C_Basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region (Q1)  Convert the title to uppercase and store it in a new variable

            Console.WriteLine("Enter the Title : ");

            string Title = Console.ReadLine();

            string UpperTitle = Title.ToUpper();

            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Upper Title : {UpperTitle}");


            #endregion


        }

        
    }
}
