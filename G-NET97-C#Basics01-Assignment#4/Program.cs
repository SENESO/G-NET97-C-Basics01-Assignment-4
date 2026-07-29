namespace G_NET97_C_Basics01_Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                #region Question 01

                double[] prices = { 25.5, 40.0, 33.75 };

                Console.WriteLine("Q1:");
                Console.WriteLine(prices[1]);

                Console.WriteLine();

                #endregion

                #region Question 02

                int[,] shelfCopies =
                {
                {3, 5},
                {1, 4}
            };

                Console.WriteLine("Q2:");
                Console.WriteLine(shelfCopies[1, 0]);

                Console.WriteLine();

                #endregion

                #region Question 03

                Console.WriteLine("Q3:");
                PrintWelcomeMessage();

                Console.WriteLine();

                #endregion

                #region Question 04

                Console.WriteLine("Q4:");
                PrintBookTitle("Clean Code");

                #endregion
            }

            #region Question 03 Method

            static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }

            #endregion

            #region Question 04 Method

            static void PrintBookTitle(string title)
            {
                Console.WriteLine("Book title: " + title);
            }

            #endregion
        }
    }