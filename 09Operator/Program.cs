
class Player
{
    int HP = 100;

    void Damage(int _HP)
    {
        HP = HP - 10;
    }
}



namespace _09Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            int Left = 7;
            int Right = 3;

            // = 대입연산자
            // 함수에서 리턴된 값이나
            // 혹은 연산이된 값을
            // 리터럴 값일때도 있다
            // 그 값을 받을 수 있는 변수
            // 넣어줘야 한다

            // 산술연산자
            Result = Left + Right; // 덧셈
            Result = Left - Right; // 뺄셈
            Result = Left * Right; // 곱셈
            Result = Left / Right; // 나누기
            Result = Left % Right; // 나머지
        }
    }
}