using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //이 함수는 1000 = 1초
            //1/1000
            //Console.WriteLine("안");
            //Thread.Sleep(1000); //1초 슬립 (프로그램 멈춤)
            //Console.Clear(); //콘솔내용 한번씩 지움
            //Console.WriteLine("안녕");
            //Thread.Sleep(1000);
            //Console.Clear(); //콘솔내용 한번씩 지움
            //Console.WriteLine("안녕하");
            //Thread.Sleep(1000);
            //Console.Clear(); //콘솔내용 한번씩 지움
            //Console.WriteLine("안녕하세");
            //Thread.Sleep(1000);
            //Console.Clear(); //콘솔내용 한번씩 지움
            //Console.WriteLine("안녕하세요");
            //Thread.Sleep(1000);

            //Console.Write("안");
            //Thread.Sleep(1000);
            //Console.Write("녕");
            //Thread.Sleep(1000);
            //Console.Write("하");
            //Thread.Sleep(1000);
            //Console.Write("세");
            //Thread.Sleep(1000);
            //Console.Write("요");
            //Thread.Sleep(1000);

            //과제 
            //저번시간 만들었던 UI 하나정해서 
            //비주얼하게 만들어보세요.
            //자유롭게 만들어보세요.

            int friends = 3;
            int cardpacks = 11;
            int gold = 120;

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Thread.Sleep(1000); 
            Console.WriteLine("┃                                                                  ┃");
            Thread.Sleep(1000); 
            Console.WriteLine("┃                                                                  ┃");
            Thread.Sleep(1000); 
            Console.WriteLine("┃                       ┏━━━━━━━━━━━━━━━━━━┓                       ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                       ┃       Play       ┃                       ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                       ┗━━━━━━━━━━━━━━━━━━┛                       ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                                                                  ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                                                                  ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                       ┏━━━━━━━━━━━━━━━━━━┓                       ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                       ┃  Solo Adventures ┃                       ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                       ┗━━━━━━━━━━━━━━━━━━┛                       ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                                                                  ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                                                                  ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                       ┏━━━━━━━━━━━━━━━━━━┓                       ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                       ┃    The Arena     ┃                       ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                       ┗━━━━━━━━━━━━━━━━━━┛                       ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                                                                  ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                                                                  ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                       ┏━━━━━━━━━━━━━━━━━━┓                       ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                       ┃   Travel Brawl   ┃                       ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                       ┗━━━━━━━━━━━━━━━━━━┛                       ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                                                                  ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┃                                                                  ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Thread.Sleep(1000);
            Console.WriteLine("                 ┏━━━━━━━━━━━┓┏━━━━━━━━━━━━━━━━━━┓");
            Thread.Sleep(1000);
            Console.WriteLine("                 ┃           ┃┃                  ┃");
            Thread.Sleep(1000);
            Console.WriteLine("                 ┃   Open    ┃┃                  ┃");
            Thread.Sleep(1000);
            Console.WriteLine("                 ┃           ┃┃  My Collection   ┃");
            Thread.Sleep(1000);
            Console.WriteLine("                 ┃   Packs   ┃┃                  ┃");
            Thread.Sleep(1000);
            Console.WriteLine("                 ┃           ┃┃                  ┃");
            Thread.Sleep(1000);
            Console.WriteLine($"                 ┗━━━━{cardpacks}━━━━━┛┗━━━━━━━━━━━━━━━━━━┛");
            Thread.Sleep(1000);
            Console.WriteLine("┏━━━┓                                                      ┏━━━━━━━┓ ");
            Thread.Sleep(1000);
            Console.WriteLine($"┃ {friends} ┃                                                      ┃   {gold} ┃");
            Thread.Sleep(1000);
            Console.WriteLine("┗━━━┛                                                      ┗━━━━━━━┛");



        }
    }
}
