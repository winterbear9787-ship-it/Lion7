using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4   
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////string 형식: 여러 문자를 저장
            //string greeting = "Hello, World!"; //문자열 저장
            //string name = "Alice"; //이름 저장

            //Console.WriteLine(greeting); //출력: Hello, World!
            //Console.WriteLine(name); //출력: Alice

            //char grade = 'A';
            //char symbol = '★';
            //char number = '9';
            //string playerName = "홍길동";
            //string welcomeMessage = "게임에 오신 것을 환영합니다!";
            //string emptyString = "";

            //Console.WriteLine($"=== RPG 게임 === \n플레이어: {playerName}\n등급: {grade}등급 {symbol}\n{welcomeMessage}");

            //int number = 9; //숫자 9 (정수타입)
            //char character = '9'; //문자 '9' (char 타입)

            //Console.WriteLine("===숫자 VS 문자 비교===");
            //Console.WriteLine($"숫자 9: {number}");
            //Console.WriteLine($"문자 9: {character}");

            //int a;
            //a = character;
            //Console.WriteLine(a);

            //char c1 = 'A';      // ✅ 문자 하나
            //char c2 = 'AB';     // ❌ 오류! 문자는 하나만 가능
            //string s1 = "A";    // ✅ 문자열 (문자 하나도 가능)
            //string s2 = "AB";   // ✅ 문자열
            //string s3 = "";     // ✅ 빈 문자열 가능

            ////bool 형식: 참(True) 또는 거짓(False)
            //bool isRunning = true;   //프로그램 실행 상태   //1
            //bool isFinished = false; //프로그램 종료 상태   //0

            //Console.WriteLine(isRunning); //출력: True
            //Console.WriteLine(isFinished); //출력: False

            //bool gameStart = true, purse = false, haveKey = false, openDoor = false, playerAlive = true, health = true, danger = false;
            //int hp = 80;

            //Console.WriteLine($"=== 게임 상태 ===\n게임 실행 중: {gameStart}\n일시정지: {purse}\n열쇠 소지: {haveKey}\n문 열림: {openDoor}\n플레이어 생존: {playerAlive}\n\n=== 캐릭터 상태 ===\n체력: {hp}\n건강 상태:{health}\n위험 상태: {danger}");

            ////닷넷 형식: 기본 형식의 닷넷 표현
            //System.Int32 number = 123; //int의 닷넷 형식
            //System.String text = "Hello"; //string의 닷넷 형식
            //System.Boolean flag = true; //bool의 닷넷 형식

            //Console.WriteLine(number); //출력: 123
            //Console.WriteLine(text); //출력: Hello
            //Console.WriteLine(flag); //출력: True

            ////int 래퍼 형식의 메서드 활용
            //int number = 123;
            //string nuberAsString = number.ToString(); //정수를 문자열로 변환

            ////bool 래퍼 형식의 메서드 활용
            //bool flag = true;
            //string flagAsString = flag.ToString(); //논리값을 문자열로 변환

            //Console.WriteLine(nuberAsString); //"123"
            //Console.WriteLine(flagAsString); //"true"


        }
    }
}
