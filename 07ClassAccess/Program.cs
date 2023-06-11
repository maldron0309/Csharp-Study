
class Player
{ // -> 클래스의 내부


    // 객체지향의 캡슐화 은닉화를 대표하는 문법
    // 접근제한 지정자
    // 세가지 접근제한 지정자가 존재한다

    public int HP; // 외부에도 공개
    protected int ATT; // 자식에게만 공개
    private int DEF; // 내부에만 공개

    public void Fight()
    {
        Console.WriteLine("싸운다");
    }
} // -> 클래스의 끝

// -> 클래스이 외부


namespace _07ClassAccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            // 만들어진 객체의 내용을 사용하기 위해서는
            // 객체의 이름. 을 사용한다.
            // 접근제한 지정자라는 문법을 사용하지 않아서
            // 외부에 공개하지 않기로 했다
            
            // 잘못쓰기도 힘들게 만들어놔라
            NewPlayer.HP = 0;
            NewPlayer.Fight();
        }
    }
}