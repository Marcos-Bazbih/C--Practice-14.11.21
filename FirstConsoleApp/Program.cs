using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //********__1__*********
            //Console.WriteLine("hello there");
            //********__1__*********


            //********__2__*********
            //Console.WriteLine("Marcos");
            //********__2__*********


            //********__3__*********
            //string myName = Console.ReadLine();
            //Console.WriteLine(myName);
            //********__3__*********


            //********__4__*********
            //Console.WriteLine(5);
            //********__4__*********


            //********__5__*********
            //int userNum = int.Parse(Console.ReadLine());
            //Console.WriteLine(userNum);
            //********__5__*********


            //********__6__*********
            //int userNum = int.Parse(Console.ReadLine());
            //if (userNum > 25)
            //{
            //    Console.WriteLine("HI");
            //}
            //else
            //{
            //    Console.WriteLine("BYE");
            //}
            //********__6__*********


            //********__7__*********
            //int userNum = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(userNum);
            //}
            //********__7__*********


            //********__8__*********
            //int userNum = int.Parse(Console.ReadLine());
            //for (int i = 0; i < userNum; i++)
            //{
            //    Console.WriteLine(userNum);
            //}
            //********__8__*********


            //********__9__*********
            //int userNum = int.Parse(Console.ReadLine());
            //string userName = Console.ReadLine();
            //for (int i = 0; i < userNum; i++)
            //{
            //    Console.WriteLine(userName);
            //}
            //********__9__*********


            //********__10__*********
            //int num1 = 2;
            //int num2 = 4;
            //int num3 = 6;
            //int num4 = 8;
            //int avg = (num1 + num2 + num3 + num4)/4;
            //int sum = num1 + num2 + num3 + num4;
            //Console.WriteLine(avg);
            //Console.WriteLine(sum);
            //********__10__*********


            //********__11__*********
            //int width = 20;
            //int height = 10;
            //int total = width * height;
            //Console.WriteLine(total);
            //********__11__*********


            //********__12__*********
            //int num1 = 10;
            //int num2 = 20;
            //int num3 = num1;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //num1 = num2;
            //num2 = num3;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //********__12__*********


            //********__13__*********
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //********__13__*********


            //********__15__*********
            //char a1 = 'a';
            //char a2 = '1';
            //Console.WriteLine(a1);
            //Console.WriteLine(a2);
            //********__15__*********


            //********__16__*********
            //bool a = true;
            //Console.WriteLine(a);
            //********__16__*********


            //********__17__*********
            //int i = 0;
            //int multi = 1;
            //while (i < 3)
            //{
            //    multi *= int.Parse(Console.ReadLine());
            //    i++;
            //}
            //Console.WriteLine(multi);
            //********__17__*********


            //********__18__*********
            //float first = float.Parse(Console.ReadLine());
            //float second = float.Parse(Console.ReadLine());
            //float result = second / first;
            //Console.WriteLine(result);
            //********__18__*********


            //********__19__*********
            //int userNum = int.Parse(Console.ReadLine());
            //userNum++;
            //Console.WriteLine(userNum);
            //********__19__*********


            //********__20__*********
            //int userNum = int.Parse(Console.ReadLine());
            //userNum *= 3;
            //Console.WriteLine(userNum);
            //********__20__*********


            //********__21__*********
            //int radius = int.Parse(Console.ReadLine());
            //double area = (radius * radius) * 3.14;
            //Console.WriteLine(area);

            //double space = (radius * 2) * 3.14;
            //Console.WriteLine(space);
            //********__21__*********


            //********__22__*********
            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //********__22__*********


            //********__23__*********
            //for (int i = 0; i <= 100; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}
            //********__23__*********


            //********__24__*********
            //for (int i = 0; i <= 100; i = i + 3)
            //{
            //    Console.WriteLine(i);
            //}
            //********__24__*********


            //********__25__*********
            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    int userNum = int.Parse(Console.ReadLine());
            //    sum += userNum;
            //}
            //Console.WriteLine(sum);
            //int avg = sum / 5;
            //Console.WriteLine(avg);
            //********__25__*********


            //********__26__*********
            Console.WriteLine("Enter 5 numbers");
            int i = 0;
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            while (i < 5)
            {
                int userNum = int.Parse(Console.ReadLine());
                maxNumber = Math.Max(maxNumber, userNum);
                minNumber = Math.Min(minNumber, userNum);
                i++;
            }
            Console.WriteLine(maxNumber);
            Console.WriteLine(minNumber);


            //********__26__*********


            //********__27__*********
            //int userNum = int.Parse(Console.ReadLine());
            //int sum = 0;
            //while (userNum > 0)
            //{
            //    userNum = int.Parse(Console.ReadLine());
            //    sum += userNum;
            //}
            //Console.WriteLine(sum);
            //********__27__*********


            //********__28__*********
            //int userNum = int.Parse(Console.ReadLine());
            //int module;
            ////int sum = 0;
            //while (userNum > 0)
            //{
            //    module = userNum % 100;
            //    Console.WriteLine(module);
            //    userNum /= 10;
            //}
            //Console.WriteLine(sum);
            //********__28__*********


            //********__29__*********
            //Random random = new Random();
            //int randomNum = random.Next(1, 100);
            //int tries = 0;


            //bool check = false;
            //while (!check)
            //{
            //    tries++;
            //    int userNum = int.Parse(Console.ReadLine());

            //    if (userNum > randomNum)
            //    {
            //Console.WriteLine("your number is bigger then");
            //    }
            //    else if (userNum < randomNum)
            //    {
            //        Console.WriteLine("your number is smaller");
            //    }
            //    else
            //    {
            //        check = true;
            //        Console.WriteLine("good job");
            //    }
            //}
            //Console.WriteLine(tries);
            //********__29__*********


            //********__30__*********
            //int width = int.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());

            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < width; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //********__30__*********


            //********__31__*********


            //********__31__*********



        }
    }
}
