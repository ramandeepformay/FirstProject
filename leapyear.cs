using System;
namespace FirstProject
{
    public class leapyear
    {   static void leap(){
          System.Console.WriteLine("Enter the year to determine whether the year is a lep year or not");
            int year = Convert.ToInt32(Console.ReadLine());
            string checker = leapYearValidator(year);
            System.Console.WriteLine(checker);
        }
        }

        static string leapYearValidator(int year)
        {
            if (year % 4 == 0 && (year % 400 == 0 || year % 100 != 0))
            {
                return $"{year} is a leap year";
            }
            return $"{year} is not a leap year";
        }

    }
