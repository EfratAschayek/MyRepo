using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1While
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 786;

            for (int i = 1; i <= 78.6; i++)
            {
                result = result -10;
            }
            Console.WriteLine("result: " + result);

            ////דף מצורף תרגיל 3
            //int num = 1;
            //for (int i = 1; num <= 109; i++)
            //{
            //    for (int j = 1; j <= i && num <= 109; j++)
            //    {
            //        Console.Write(num + "    ");
            //        num += 2;
            //    }
            //    Console.WriteLine();
            //}



            ////דף מצורף תרגיל4

            ////count = סופר את מספר הספרות בכל מספר
            ////firstNumleftDigit = הספרה השמאלית במספר הראשון

            //int num, temp, i, leftDigit, prevNumRightDigit = 0, count = 0, firstNumleftDigit;
            //bool domino = true;
            //Console.WriteLine("Enter a positive number:");//למספר הראשון
            //num = int.Parse(Console.ReadLine());
            //prevNumRightDigit = num % 10;//מציאת האחדות במספר הראשון
            //temp = num;
            //while (temp != 0)//מציאת הספרה השמאלית במספר הראשון
            //{
            //    count++;
            //    temp /= 10;
            //}
            //firstNumleftDigit = num / (int)Math.Pow(10, count - 1);//
            //for (i = 1; i <=19; i++)
            //{
            //    Console.WriteLine("Enter a positive number:");
            //    num = int.Parse(Console.ReadLine());
            //    temp = num;
            //    count = 0;
            //    while (temp != 0)//מציאת הספרה השמאלית של כל מספר (מלבד הראשון
            //    {
            //        count++;//סופרת את מספר הספרות במספר
            //        temp /= 10;
            //    }
            //    leftDigit = num / (int)Math.Pow(10, count - 1);//הספרה השמאלית בכל מספר
            //    if (leftDigit != prevNumRightDigit)
            //    {
            //        i = 5;//הלולאה נעצרת במקרה שהספרה השמאלית של המספר הנוכחי אינה שווה לספרה השמאלית של המספר הקודם
            //        domino = false;
            //    }
            //    else
            //    {
            //        prevNumRightDigit = num % 10;//מציאת האחדות של כל מספר
            //    }
            //}
            //if (firstNumleftDigit == prevNumRightDigit)
            //{
            //    if (domino == true)
            //    {
            //        Console.WriteLine("The seria is a circular domino.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The seria is not a circular domino.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The seria is not a circular domino.");
            //}



            ////////דף מצורף תרגיל6 

            //int i, num, temp, digit, minDigit,mul,newNum, digitOfNewNum,count, repeatNumbers=0;
            //for (i = 1; i <=10; i++)
            //{
            //    Console.WriteLine("Enter positive number:");
            //    num = int.Parse(Console.ReadLine());
            //    temp = num;
            //    minDigit = 10;
            //    digit = 0;
            //    while (num < 0)//מסננת קלט
            //    {
            //        Console.WriteLine("Eror! A negative number!\n Enter a positive number.");
            //        num = int.Parse(Console.ReadLine());
            //    }
            //    while (num != 0)//הלולאה מוצאת את המספר המינימלי
            //    {
            //        digit = num % 10;
            //        if (digit < minDigit)
            //        {
            //            minDigit = digit;
            //        }
            //        num /= 10;
            //    }
            //    mul = 1;
            //    newNum = 0;
            //    digitOfNewNum = 0;
            //    count = 0;
            //    while (temp != 0)
            //    {
            //        digitOfNewNum = temp % 10;
            //         if(digitOfNewNum!= minDigit)
            //        {
            //            newNum = newNum + digitOfNewNum* mul;
            //            mul *= 10;
            //        }
            //        else//ספירת מספר הפעמים שהספרה המינמלית מופיעה במספר
            //        {
            //            count++;
            //        }
            //        temp /= 10;
            //    }
            //    if (count > 1)//המספר חזר על עצמו
            //    {
            //        repeatNumbers++;
            //    }
            //    Console.WriteLine("The new number is: {0}\nThe digit that was erased is: {1}", newNum, minDigit);
            //}
            //Console.WriteLine("The minimal digit reapeated in {0} numbers",repeatNumbers);



            ////////דף מצורף תרגיל8 

            //////dailyTestsNum =מספר הבדיקות שנערכו בכל יום 
            //////prevDayTestNum = שומר את מספר הבדיקות שנערכו ביום הקודם
            //////maxPositive = אחוז המאומתים הגבוה ביותר
            //////iMaxPositive = הים שבו אחוז המאומתים הוא הגבוה ביותר
            //////NumOfPositiveTestsInADay = מספר בדיקות חיוביות ביום
            //////percentsOfPositiveTestsInADay = אחוז מאומתים ביום

            //int i, j, dailyTestsNum = 0, prevDayTestNum = int.MaxValue, sumOfTestsOnCheshvanMonth = 0,
            //    iMaxPositive = 0, NumOfNegativeTestsInADay,
            //    countsEveryGrowingContinutyOfTests, maxGrowingContinuty = int.MinValue, iMaxGrowingContinuty = 0;
            //double NumOfPositiveTestsInADay, percentsOfPositiveTestsInADay, maxPositive = -1,
            //    sumOfPositiveOnCheshvanMonth = 0, NumOfBorderlineTestsInADay,
            //    sumOfBorderlineOnCheshvanMonth = 0;
            //string testResult;
            //bool isExisting = false;
            //for (i = 1; i <= 29; i++)
            //{
            //    Console.WriteLine("Enter daily number of tests:");//סעיף א
            //    dailyTestsNum = int.Parse(Console.ReadLine());
            //    sumOfTestsOnCheshvanMonth += dailyTestsNum;
            //    countsEveryGrowingContinutyOfTests = 1;//סעיף ה
            //    if (prevDayTestNum < dailyTestsNum)
            //    {
            //        countsEveryGrowingContinutyOfTests++;
            //        if (countsEveryGrowingContinutyOfTests > maxGrowingContinuty)
            //        {
            //            maxGrowingContinuty = countsEveryGrowingContinutyOfTests;
            //            iMaxGrowingContinuty = i;
            //        }
            //    }
            //    else
            //    {
            //        countsEveryGrowingContinutyOfTests = 1;
            //    }
            //    prevDayTestNum = dailyTestsNum;//סעיף ה
            //    NumOfPositiveTestsInADay = 0;
            //    percentsOfPositiveTestsInADay = 0;
            //    NumOfBorderlineTestsInADay = 0;
            //    NumOfNegativeTestsInADay = 0;
            //    for (j = 1; j <= dailyTestsNum; j++)
            //    {
            //        Console.WriteLine("Enter the result of the test:");
            //        testResult = Console.ReadLine();
            //        if (testResult == "positive")//סעיפים ב ג
            //        {
            //            NumOfPositiveTestsInADay++;
            //            percentsOfPositiveTestsInADay = (NumOfPositiveTestsInADay / dailyTestsNum) * 100;
            //            if (percentsOfPositiveTestsInADay > maxPositive)
            //            {
            //                maxPositive = percentsOfPositiveTestsInADay;
            //                iMaxPositive = i;
            //            }
            //        }
            //        else
            //        {
            //            if (testResult == "negative")
            //            {
            //                NumOfNegativeTestsInADay++;
            //            }
            //            else//סעיףד
            //            {
            //                NumOfBorderlineTestsInADay++;
            //            }
            //        }
            //        if (NumOfPositiveTestsInADay > NumOfNegativeTestsInADay)//סעיף ו
            //        {
            //            isExisting = true;
            //        }
            //    }
            //    sumOfPositiveOnCheshvanMonth += NumOfPositiveTestsInADay;
            //    sumOfBorderlineOnCheshvanMonth += NumOfBorderlineTestsInADay;
            //}
            //Console.WriteLine("{0} tests were done on Cheshvan month.", sumOfTestsOnCheshvanMonth);//סעיף א
            //Console.WriteLine("The bigger percents of positive tests were in day: {0}", iMaxPositive);//סעיף ב
            //Console.WriteLine("There were {0} verified people on Cheshvan month.", sumOfPositiveOnCheshvanMonth);//סעיף ג
            //Console.WriteLine("The average of borderline in amonth is:{0}", sumOfBorderlineOnCheshvanMonth / 29);//סעיף ד
            //if (maxGrowingContinuty == int.MinValue)//אם  לא היה יום בו מספר הבדיקות גדול מהים הקודם
            //{
            //    Console.WriteLine("Longest continuty of growing num of tests is:0 ");
            //}
            //else
            //{
            //    Console.Write("The longest continuty of days with growing num of tests is:");
            //    for (j = (iMaxGrowingContinuty - maxGrowingContinuty + 1); j <= iMaxGrowingContinuty; j++)//סעיף ה
            //    {
            //        Console.Write("{0}, ", j);
            //    }
            //}
            //if (isExisting = false)//סעיף ו
            //{
            //    Console.WriteLine("No.The number of positive tests was not bigger than the negative tests in any day.");
            //}
            //else
            //{
            //    Console.WriteLine("\nYes.There was a day on which the number of the positive tests was bigger " +
            //        "than the number of the negative tests.");
            //}



            ////page 21 ex.9

            //int num, i, j,n;
            //Console.WriteLine("Enter a one digit positive number");
            //num = int.Parse(Console.ReadLine());
            //for (i = num; i >=1; i--)
            //{
            //    for (j = 1; j <=num-i; j++)
            //    {
            //        Console.Write("  ");//מדפיס שני רווחים
            //    }
            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    for (n = j - 2; n >= 1; n--)
            //    {
            //        Console.Write(n);
            //    }
            //    Console.WriteLine();//בדוגמא היה נראה שיש שורת רווח בין שורה לשורה
            //    Console.WriteLine();
            //}
            //for (i = 2; i<=num; i++)
            //{
            //    for (j = 1; j <= num - i; j++)
            //    {
            //        Console.Write("  ");//מדפיס שני רווחים
            //    }
            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    for (n = j - 2; n >= 1; n--)
            //    {
            //        Console.Write(n);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}



            ////page 22 ex.10

            //int n, k, i, j, s,z;
            //Console.WriteLine("Enter 2 positive numbers");
            //n = int.Parse(Console.ReadLine());//שורות
            //k = int.Parse(Console.ReadLine());//משבצות
            //for (i = 1; i <= n; i++)//מספר המשבצות בשחמט (לאורך הלוח 
            //{
            //    if (i % 2 != 0)//אם מדובר במשבצות האי זוגיות לאורך הלוח
            //    {
            //        for (j = 1; j <= k; j++)//לולאה זו עוברת אורכית על השורות בכל משבצת
            //        {
            //            for (s = 1; s <= n; s++)// הלולאה עוברת רוחבית על המשבצות(בשורות אי זוגיות    
            //            {
            //                if (s % 2 != 0)//אם מדובר במשבצת אי זוגית (משמאל לימין
            //                {
            //                    for (z = 1; z <= k; z++)//הלולאה עוברת רוחבית על כל משבצת ומדפיסה סולמית
            //                    {
            //                        Console.Write("#");
            //                    }
            //                }
            //                else//אם מדובר במשבצת זוגית (משמאל לימין
            //                {
            //                    for (z = 1; z <= k; z++)//הלולאה עוברת רוחבית על כל משבצת ומדפיסה רווח
            //                    {
            //                        Console.Write(" ");
            //                    }
            //                }
            //            }
            //            Console.WriteLine();//הסתיימה שורת משבצות בלוח השחמט 
            //        }
            //    }
            //    else//אם מדובר במשבצות הזוגיות לאורך הלוח
            //    {
            //        for (j = 1; j <= k; j++)//לולאה זו עוברת אורכית על השורות בכל משבצת
            //        {
            //            for (s = 1; s <= n; s++)//הלולאה עוברת רוחבית על המשבצות(בשורות זוגיות
            //            {
            //                if (s % 2 != 0)//אם מדובר במשבצת אי זוגית זוגית (משמאל לימין
            //                {
            //                    for (z = 1; z <= k; z++)//הלולאה עוברת רוחבית על כל משבצת ומדפיסה רווח
            //                    {
            //                        Console.Write(" ");
            //                    }
            //                }
            //                else//אם מדובר במשבצת זוגית (משמאל לימין
            //                {
            //                    for (z = 1; z <= k; z++)//הלולאה עוברת רוחבית על כל משבצת ומדפיסה סולמית
            //                    {
            //                        Console.Write("#");
            //                    }
            //                }
            //            }
            //            Console.WriteLine();//הסתיימה שורת משבצות בלוח השחמט
            //        }
            //    }
            //}








            Console.ReadLine();
        }
    }
}              
