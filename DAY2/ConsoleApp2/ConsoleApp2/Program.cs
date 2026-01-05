using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입
            //int intgerNum = 10; //정수 데이터
            //float floatNum = 3.14f; //단정밀도 실수
            //double dobuleNum = 3.14159; //배정밀도 실수

            //Console.WriteLine(intgerNum); //출력: 10
            //Console.WriteLine(floatNum); //출력: 3.14
            //Console.WriteLine(dobuleNum); //출력: 3.14159

            //| 타입 | 크기 | 범위 | 용도 |
            //| ------| ------| ------| ------|
            //| byte | 1바이트 | 0 ~255 | 작은 양수(나이, 레벨) |
            //| sbyte | 1바이트 | -128 ~127 | 작은 정수 |
            //| short | 2바이트 | -32,768 ~32,767 | 작은 정수 |
            //| ushort | 2바이트 | 0 ~65,535 | 작은 양수 |
            //| int | 4바이트 | -21억 ~21억 | 가장 많이 사용 |
            //| uint | 4바이트 | 0 ~42억 | 큰 양수 |
            //| long | 8바이트 | 매우 큰 범위 | 아주 큰 수 |
            //| ulong | 8바이트 | 0 ~아주 큰 수 | 아주 큰 양수


            ////게임 캐릭터 스탯
            //byte level = 50;             //레벨 (0~255면 충분)
            //short attack = 1500;         //공격력
            //int gold = 1234567;          //소지금
            //long experience = 99999999L; //경험치 (L 접미사 필수)

            //Console.WriteLine($"===캐릭터 정보===\n레벨: {level}\n공격력: {attack}\n소지금: {gold:N0}\n경험치: {experience:N0}"); //N0: 천 단위 구분

            ////타입별 최대값 확인
            //Console.WriteLine("\n=== 타입별 최대값 ===");
            //Console.WriteLine($"byte 최대값: {byte.MaxValue}");
            //Console.WriteLine($"short 최대값: {short.MaxValue}");
            //Console.WriteLine($"int 최대값: {int.MaxValue:N0}");
            //Console.WriteLine($"long 최대값: {long.MaxValue:N0}");

            ////정수 데이터 형식: 소수점이 없는 숫자를 표현
            //int intValue = -100; //4바이트 크기의 정수
            //long longValue = 1234567890L; //8바이트 크기의 정수

            //Console.WriteLine(intValue); //출력: -100
            //Console.WriteLine(longValue); //출력 1234567890

            ////부호 있는 정수: 음수와 양수를 모두 표현 가능
            //sbyte signedByte = 50; //1바이트 크기
            //short signedShort = -32000; //2바이트 크기
            //int signedint = -2000000000; //4바이트 크기

            //Console.WriteLine(signedByte); //출력: -50
            //Console.WriteLine(signedShort); //출력: -32000
            //Console.WriteLine(signedint); //출력 -2000000000

            ////부호 없는 정수: 0이상의 정수만 표현 가능
            //byte unsignedByte = 255; //1바이트 크기
            //ushort unsignedShort = 65000; //2바이트 크기
            //uint unsignedInt = 4000000000; //4바이트 크기

            //Console.WriteLine(unsignedByte); //출력:255
            //Console.WriteLine(unsignedShort); //출력: 65000
            //Console.WriteLine(unsignedInt); //출력: 4000000000

           

        }
    }
}
