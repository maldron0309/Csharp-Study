
// 객체지향 프로그래밍에서는
// 가장 처음으로 해야할 일이
// 내가 뭘 만들고 싶다.
// class Dragon
// {
//    int ATT; // 맴버변수
//    int HP; // 맴버 변수
//    // 맴버함수
//    void Damage()
//   {
//    HP = HP - 10;
//   }
// }


class Player
{
    // 맴버변수 -> 클래스 내부에 있다고 해서 맴버변수
    int Att;
    int Hp;

    void Fight()
    {
        // 선언되는순간 지역변수는 메모리화
        int Damage = 0;

        Console.WriteLine("플레이어가 싸운다.");
    }
} // 게임에서 사용하기 위해서 여기까지 설계했다.

namespace Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 클래스안에 있으면 맴버변수
            

            // 함수안에 있다면 지역변수
            // 지역변수 규칙 1
            //{
            //  내부에서 만 사용가능
            //}
            int ATT = 0;
            ATT = 50;

            // 객체화라고 하는 굉장히 중요한 작업
            // 클래스는 무엇인가??
            // 설계도.
            // Player의 설계대로 플레이어를 만드는데
            // 그 이름을 NewPlayer라고 해서

            //Player NewPlayer1 = new Player();
            //Player NewPlayer2 = new Player();

            // Console.WriteLine("Hello, World!");
        }
    }
}