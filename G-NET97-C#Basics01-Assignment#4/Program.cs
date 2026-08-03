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

                #region Question 05

            int pages = 400;

            AddBonusPages(pages);

            Console.WriteLine("Q5:");
            Console.WriteLine(pages);

            Console.WriteLine();

            #endregion

                #region Question 06

            double[] prices2 = { 25.5, 40.0 };

            ApplyDiscount(prices2);

            Console.WriteLine("Q6:");
            Console.WriteLine(prices2[0]);

            Console.WriteLine();

            #endregion

                #region Question 07

            int pagesRef = 400;

            AddBonusPagesByRef(ref pagesRef);

            Console.WriteLine("Q7:");
            Console.WriteLine(pagesRef);

            Console.WriteLine();

            #endregion

                #region Question 08

            double[] prices3 = { 25.5, 40.0 };

            ReplaceArray(ref prices3);

            Console.WriteLine("Q8:");
            Console.WriteLine(prices3.Length);

            Console.WriteLine();

            #endregion

                #region Question 09

            Console.WriteLine("Q9:");

            if (TryGetPrice("Clean Code", out double price))
            {
                Console.WriteLine(price);
            }
            else
            {
                Console.WriteLine("Book Not Found");
            }

            Console.WriteLine();

            #endregion

                #region Question 10

            Console.WriteLine("Q10:");

            PrintBookInfo("Clean Code");

            PrintBookInfo("C# in Depth", 900);

            Console.WriteLine();

            #endregion

                #region Question 11

            Console.WriteLine("Q11:");

            PrintBookInfo(pages: 500, title: "ASP.NET Core");

            Console.WriteLine();

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

        #region Question 05 Method

        static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        #endregion

        #region Question 06 Method

        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        #endregion

        #region Question 07 Method

        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

        #endregion

        #region Question 08 Method

        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

        #endregion

        #region Question 09 Method

        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }

            price = 0;
            return false;
        }

        #endregion

        #region Question 10 & Question 11 Method

        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }

        #endregion
    }
}