using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////실수 데이터 형식: 소수점을 포함한 숫자를 표현
            //float singlePrecision = 3.14f; //단정밀도 실수(4바이트)
            //double doublePrecision = 3.1415926535; //배정밀도 실수 (8바이트)
            //decimal highPrecision = 3.1415926535897932384626433833m; //고정밀도 (16바이트)

            //Console.WriteLine(singlePrecision); //출력: 3.14 
            //Console.WriteLine(doublePrecision); //출력: 3.1415926535 
            //Console.WriteLine(highPrecision); //출력: 3.1415926535897932384626433833

            ////접미사 사용: 숫자의 데이터 형식을 명시
            //int integerValue = 100; //기본 정수형(int)
            //long longValue = 100L; //정수형(long)
            //float floatValue = 3.14f; //실수형(float)
            //double doubleValue = 3.14; //기본 실수형(double)
            //decimal decimalValue = 3.14m; //고정밀도 실수형(decimal)

            //Console.WriteLine(integerValue); //출력: 100
            //Console.WriteLine(longValue); //출력: 100
            //Console.WriteLine(floatValue); //출력: 3.14
            //Console.WriteLine(doubleValue); //출력: 3.14
            //Console.WriteLine(decimalValue); //출력: 3.14

            ////데이터 타입 종류에 따라 바이트가 적은 타입을 사용하면 최적화 측면에서 이득을 볼 수 있다. → 서버 측면에서 의미가 클 수 있음

            ////char 형식: 단일 문자를 표현
            //char letter = 'A'; // 문자 'A' 저장
            //char symbol = '#'; //특수 기호 저장
            //char number = '9'; //숫자 형태의 문자 저장 (문자'9', 숫자 9 아님)

            //Console.WriteLine(letter); //출력: A
            //Console.WriteLine(symbol); //출력: #
            //Console.WriteLine(number); //출력: 9

            //float movingSpeed = 5.5f;
            //double attackSpeed = 1.25;
            //decimal itemPrice = 12.99m;

            //Console.WriteLine($"==== 캐릭터 능력치 ====\n이동속도: {movingSpeed}\n공격속도: {attackSpeed}\n아이템 가격:{itemPrice}");

     


        }
    }
}
