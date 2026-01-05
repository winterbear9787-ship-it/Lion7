using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age = 20;

            //Console.WriteLine($"{age}");

            //double height = 175.5;
            //string job = "Student";

            //Console.WriteLine($"height : {height}, job : {job}");

            //int kor = 90, eng = 80, math = 100;

            //Console.WriteLine($"KOR : {kor}, ENG : {eng}, MATH : {math}");

            //string message;
            //message = "Welcome to C#";
            //Console.WriteLine($"{message}");

            //char grade = 'A';
            //int isPassed = 100;

            //Console.WriteLine($"{grade}");
            //Console.WriteLine($"{isPassed}");

            //int x, y, z;
            //x = 10;
            //y = 20;
            //z = 30;
            //Console.WriteLine($"{x}");
            //Console.WriteLine($"{y}");
            //Console.WriteLine($"{z}");

            ////string welcome;
            ////Console.WriteLine($"{welcome}");
            ////변수가 초기화되지 않아 콘솔창에 어떤 변수값도 나오지 않는다 → 초기화되지 않은 지역 변수를 사용하려고 하면 컴파일러가 오류를 발생시킨다.

            //string welcome = "Hi";
            //Console.WriteLine($"{welcome}");

            //int a = 100;
            //double b = 3.14;
            //char c = 'B';
            //string d = "babo";

            //Console.WriteLine($"{a}, {b}, {c}, {d}");

            //int score = 10;
            //score = 100;

            //Console.WriteLine($"{score}");

            //int number = 10;
            //number = 3.14;
            ////빌드 오류가 발생한다
            ////정수형 변수에는 실수형 변수인 3.14를 담을 수 없다.
            //Console.WriteLine($"{number}");

            //int hour = 3, minute = 20;
            //string status = "공부 중";

            //Console.WriteLine($"{hour}시 {minute}분 : {status}");

            //int a = 12345;
            //string b = "C# is Fun";
            //double c = 36.5;
            //char d = 'G';

            //int kor = 85, eng = 92, math = 78;
            //math = 80;
            //char grade = 'A';
            //double average = 85.6;
            //string studentName = "홍길동";

            //Console.WriteLine($"[{studentName}] 평균 : {average}, 등급 : {grade} (국: {kor}, 영: {eng}, 수:{math})");

            //double exchangeRate = 1320.5;
            //int dollars = 100;
            //int a = 10, b = 20;
            //int temp;
            //temp = a;
            //a = b;
            //b = temp;

            //Console.WriteLine($"{exchangeRate}, {dollars}, {a}, {b}");

            //char charDigit = '1';
            //int intDigit = 1;
            ////char charDigit = '1'; 은 화면에 그릴 '모양' 데이터이고, int intDigit = 1; 은 계산을 하기 위한 '수치' 데이터로 intDigit + 1은 2가 되지만 charDigit + 1 은 2가 되지 않는다. 

            //Console.WriteLine($"{charDigit},{intDigit}");
            ////출력했을 때 겉보기에 차이는 없다.

            //string top1 = "C#", top2 = "Java", top3 = "Python";
            //top1 = "C# Master";

            //Console.WriteLine($"{top1}, {top2}, {top3}");

            //int emptyBox;
            //console.WriteLine($"{emptyBox}");

            //int level = 5;

            //Console.WriteLine($"{level}");

            //string fruit;
            //fruit = "Apple";

            //Console.WriteLine($"{fruit}");

            //double weight = 70.5;

            //Console.WriteLine($"{weight}");

            //int red = 255, green = 0, blue = 0;

            //Console.WriteLine($"{red}, {green}, {blue}");

            ////string nickname;
            ////Console.WriteLine(nickname);
            ////변수값이 초기화 되지 않아 오류가 발생한다.

            //char gender = 'M';
            //string Cityname = "Seoul";
            //int examScore = 95;

            //int originalNumber = 100;
            //int copyNumber = originalNumber;

            //Console.WriteLine($"{copyNumber}");

            //double a = 3.5, b = 4.2, c = 5.8;

            //Console.WriteLine($"{a}, {b}, {c}");

            //1024 : 정수형 리터럴
            //"C# Programming : 문자열 리터럴
            //0.001 : 실수형 리터럴
            //'Z' : 문자형 리터럴

            //int a = 10; Console.WriteLine(a);
            //int b; b = 20; Console.WriteLine(b);
            //int c; Console.WriteLine(c);
            //오류가 발생하는 코드는 int c 로 변수값이 초기화되지 않았기 때문에 오류가 발생한다.

            //int box = 10;
            //box = 20;
            //box = 5;

            //Console.WriteLine(box); // 출력값은? (   5   )

            //int age = 20;
            //char grade = 'A';

            //Console.WriteLine($"나의 나이는 {age}살이고, 성적은 {grade}입니다.");

            ////A: int a = 3.14;
            ////B: double b = 100;
            ////C: char c = "K";
            ////D: string d = 'Hello';
            ////정답은 A,B 이고, A는 정수형 데이터타입에 실수형 리터럴이 사용되었고 B는 실수형 데이터타입에 정수형 리터럴이 사용되었다. → 정답은 A,C,D 로 실수형 데이터타입에 기입된 정수는 자동적으로 100.0 으로 변환된다. C, D 는 서로 기호가 바뀌었다. 

            //int x = 10, y = 20;
            //x = y; // x에 y의 값을 저장
            //y = 30; // 그 후 y의 값을 30으로 변경

            //Console.WriteLine(x); // x는 얼마가 출력될까요? 30 → 20
            //Console.WriteLine(y); // y는 얼마가 출력될까요? 30
            ////x=y;를 하는 순간 x라는 그릇에는 y가 가지고 있던 값이 복사되어 들어가며 그 이후에 y=30;을 선언하더라도 이미 복사가 끝난 x에는 아무런 영향이 없다. 두 변수는 독립적인 그릇이기 때문이다.

            //int appleCount = 5, grapeCount = 3, orangeCount = 10;

            //Console.WriteLine($"사과의 갯수는 {appleCount}개 이고, 포도의 갯수는 {grapeCount}개 이고, 오렌지의 갯수는 {orangeCount}개 이다.");

            //string cupA = "Coke";
            //string cupB = "Juice";
            //string temp;
            //temp = cupA;
            //cupA = cupB;
            //cupB = temp;

            //Console.WriteLine($"{cupA}, {cupB}");

            //int x = 1, y = 2, z = 3;
            //int temp;
            //temp = z;
            //z = x;
            //x = y;
            //y = temp;

            //Console.WriteLine($"{x}, {y}, {z}");

            //double yesterdayPrice = 10500;
            //double todayPrice = 10500.75;
            //string status = "";
            //double temp;
            //temp = todayPrice;
            //todayPrice = yesterdayPrice;
            //yesterdayPrice = temp;
            //status = ($"어제는 {yesterdayPrice}원 이었고, 오늘은 {todayPrice}원입니다.");
            //Console.WriteLine($"{status}");

            //int count = 2;
            //count = count + 3;

            //Console.WriteLine($"현재 주문하신 총 수량은 {count}잔입니다.");

            //double myExp = 100;
            //double friendPresent = 10;
            //myExp = myExp * 1.5;
            //myExp = myExp + 0.7;

            //Console.WriteLine($"최종 캐릭터 경험치는 {myExp} 이었으나, 친구의 선물로 {myExp + friendPresent} 이 되었습니다");

            //double temp = 26.8;
            //Console.WriteLine($"현재 온도는 {temp}도입니다.");

            //string first = "10";
            //string second = "20";
            //Console.WriteLine(first+second); //1020

            //int pocketMoney = 5000; //처음 가진 돈
            //pocketMoney = pocketMoney + 10000;
            //Console.WriteLine(pocketMoney);

            //int kor = 85, eng = 90;
            //double average = (kor + eng) / 2.0;
            //Console.WriteLine($"평균 점수는 {average}점입니다.");

            //int apple = 5;
            //int grape = 3;
            //string message = "총 과일 갯수:" + apple + grape;
            //Console.WriteLine(message);
            //// 출력값 : 총 과일 갯수:53

            //int a = 10, b = 20, c = 30;
            //int temp;
            //temp = c;
            //c = b;
            //b = a;
            //a = temp;
            //Console.WriteLine($"{a}, {b}, {c}");

            //byte level = 255;
            //level = (byte)(level + 1);
            //Console.WriteLine(level);
            ////출력값 : 0

            //int a = 5;
            //int b = 2;
            //double result = a / b;
            //Console.WriteLine(result);
            ////출력값 : 2, 정수형 데이터타입인 int 를 사용했기 때문에 소수점이 출력이 안되기 때문이다.

            //int u1 = 100, u2 = 200, u3 = 300, u4 = 400;
            //int temp;
            //double gold;
            //temp = u4;
            //u4 = u1;
            //u1 = u2;
            //u2 = u3;
            //u3 = temp;
            //gold = u1 * 0.1 + u2 * 0.1 + u3 * 0.1 + u4 * 0.1;
            //Console.WriteLine($"{gold}");

            //int sword = 1000;
            //int axe = 800;
            //int bow = 600;
            //int spear = 400;
            //int temp;
            //temp = spear;
            //spear = (int)(sword * 0.85);
            //sword = (int)(axe * 0.85);
            //axe = (int)(bow * 0.85);
            //bow = (int)(temp * 0.85);

            //Console.WriteLine(sword);
            //Console.WriteLine(axe);
            //Console.WriteLine(bow);
            //Console.WriteLine(spear);

            //char grade = 'A';
            //int bonus = 5;
            //Console.WriteLine($"내 등급은 {grade}이고 추가 점수는 {bonus}점입니다.");

            //int a = 10;
            //double b = 5.5;
            //double c = a + b;
            //Console.WriteLine(c);

            //int money = 1300;
            //double result = money / 500;
            //Console.WriteLine(result);

            //int minutes = 150;
            //double additionalSeconds = 30.5;
            //double totalSeconds = minutes * 60 + additionalSeconds;
            //Console.WriteLine($"이 선수의 최종 기록은 {totalSeconds}초입니다.");

            //int pay = 10000;
            //int price = 3200;
            //int change = pay - price;
            //int coinCount = change / 500;
            //Console.WriteLine($"거스름돈은 {change}이며, 500원 동전은 총 {coinCount}개입니다.");

            //double radius = 5, height = 10.5, pi = 3.14;
            //double volume = (radius * radius * pi * height);
            //Console.WriteLine(volume);

            //int totalApples = 100, boxSize = 8;
            //Console.WriteLine($"완벽하게 채워진 상자의 개수: {totalApples / boxSize}");
            //Console.WriteLine($"남은 사과의 개수: {totalApples % boxSize}");

            //int a = 100;
            //int b = 200;
            //Console.WriteLine($"합계는 {a + b}입니다.");

            //int americanoPrice = 4500, quatity = 3;
            //double discountRate = 0.1;
            //double totalPrice = americanoPrice * quatity;
            //double finalPrice = totalPrice * (1-0.1);
            //Console.WriteLine($"주문하신 {quatity}잔의 총 금액은 {totalPrice}원이며, 10% 할인된 금액은 {finalPrice}원입니다.");

            //string cupA = "콜라", cupB = "주스";
            //string temp;
            //temp = cupB;
            //cupB = cupA;
            //cupA = temp;
            //Console.WriteLine($"A에는 {cupA}가, B에는 {cupB}가 있습니다.");

            //double kor = 85, eng = 90;
            //double average = (kor + eng) / 2;
            //Console.WriteLine(average);

            //string name = "제미니";
            //int age = 25;
            //double height = 175.5;
            //bool sex = true;
            //Console.WriteLine($"===프로필 카드===\n성함: {name}\n나이: {age}\n키: {height}\n성별: 남성({sex})\n=================");

            //double radius = 5, height = 10.5, pi = 3.14;
            //double volume = radius * radius * pi * height;
            //Console.WriteLine($"윈기둥의 부피는 [{volume}]입니다.");

            //int totalMinutes = 127;
            //Console.WriteLine($"{totalMinutes / 60}시간 {totalMinutes % 60}분");

            //int a = 100, b = 200;
            //Console.WriteLine($"결과는 {a + b}입니다.");

            //int a = 10, b = 20;
            //int temp;
            //temp = b;
            //b = a;
            //a = temp;
            //Console.WriteLine($"교환 후 a:{a}, b:{b}");

            //double kor = 80, eng = 95, math = 90;
            //double average = (kor + eng + math) / 3;
            //Console.WriteLine(average);

            //int pay = 5000;
            //int price = 3200;
            //Console.WriteLine($"500원 동전:{(pay - price) / 500}개, 나머지 잔돈:{(pay-price) % 500}원");

            char A = 'A';
            Console.WriteLine($"{(int)A}");

            float F = 1.0f;
            double D = 3.0;
            Console.WriteLine($"{F}, {D}");

            const int MONTH_IN_YEAR = 12;
            int years = 3;
            Console.WriteLine($"3년은 총 {MONTH_IN_YEAR * years}개월 입니다.");












        }
    }
}
