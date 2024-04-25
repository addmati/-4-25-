using System.Security.Cryptography.X509Certificates;
using static ConsoleApp4.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp4
{
    internal class Program
    {


        static void Main(string[] args)
        {



            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2.인벤토리");
            Console.WriteLine("3.상점");

            Console.Write("원하는 행동의 숫자를 입력하세요: ");

            int Number;
            if (int.TryParse(Console.ReadLine(), out Number))
            {
                switch (Number)
                {
                    case 1:
                        StratMenu();
                        break;
                    case 2:
                        Inventory();
                        break;
                    case 3:
                        Console.WriteLine("상점");
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }

            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
        }

       static void StratMenu()
        {


            Chad chad = new Chad ();

            string Name = "Chad";
            string Class = "전사";
            int Level = 01;
            int HP = 100;
            int Gold = 1500;
            int OffensePower = 10;
            int DefensePower = 5;


            Console.WriteLine("상태보기");
            Console.WriteLine($"Lv. { Level}");
            Console.WriteLine($"{ Name} {Class}");
            Console.WriteLine($"공격력: {OffensePower}");
            Console.WriteLine($"방어력: {DefensePower}");
            Console.WriteLine($"체력: {HP}");
            Console.WriteLine($"Gold: {Gold} G");
            Console.WriteLine("나가기 0번");
            int Number;
            if (int.TryParse(Console.ReadLine(), out Number))
            {
                switch (Number)
                {
                    case 0:
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }

            }

        }

        static void Inventory()
        {
            Console.WriteLine("");
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\r\n");
            Console.WriteLine("[아이템 목록]\r\n");
            Console.WriteLine("- [E]무쇠갑옷 | 방어력 + 5 | 무쇠로 만들어져 튼튼한 갑옷입니다.");
            Console.WriteLine("- [E]스파르타의 창 | 공격력 + 7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.");
            Console.WriteLine("- 낡은 검 | 공격력 + 2 | 쉽게 볼 수 있는 낡은 검 입니다.");
            int Number;
            if (int.TryParse(Console.ReadLine(), out Number))
            {
                switch (Number)
                {
                    case 1:

                        break;

                    case 2:
                        break;

                        case 3:
                            break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }

            }

        }

        static void items() {


        }






        public class Chad
        {
            string Name = "Chad";
            string Class = "전사";
            int Level = 01;
            int HP = 100;
            int Gold = 1500;
            int OffensePower = 10;
            int DefensePower = 5;
        }











    }
} 

          


    






    
