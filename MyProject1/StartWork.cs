using System;

namespace MyProject1
{
    public class StartWork
    {
        public StartWork()
        {
            bool flag = false;
            while (flag==false)
            {
                Console.WriteLine("Select task number from 1 to 4: ");
                try
                {
                    int n = Int32.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.Write("Please, enter your line to check for palindrom: ");
                            string str1 = Console.ReadLine();
                            new PalindromeCheck(str1);
                            break;
                        case 2:
                            Console.Write("Please, enter your line to get statistic: ");
                            string str2 = Console.ReadLine();
                            CharCountStat.getStatisticForChar(str2);
                            break;
                        case 3:
                            Console.Write("Enter your first number: ");
                            int num1 = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter your second number to replace with first one: ");
                            int num2 = Int32.Parse(Console.ReadLine());
                            new ReplaceVariables(num1, num2);
                            break;
                        case 4:
                            Console.Write("Enter size of your array: ");
                           int size = Convert.ToInt32(Console.ReadLine());
                            int[] array= new int[size];
                            for (int i = 0; i < size; i++)
                            {
                                Console.Write("Enter value for [{0}] element: ", i+1);
                                array[i]=Int32.Parse(Console.ReadLine());
                            }

                            new DuplicateElementsInArray().DuplicateToEnd(array);
                            break;
                    }
                    Console.WriteLine("\nDo you want to continue? \n Y   N");
                    char ch = Char.Parse(Console.ReadLine().ToUpper());
                    if (ch == 'N')
                    {
                        flag = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You entered wrong value, please, repeat your try :)");
                }


            }
        }
    }
}