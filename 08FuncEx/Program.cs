
class Player
{
    // 접근제한 지정자를 입력하지 않으면
    // 기본값으로로 private
    // private이 일반적이기 때문이다
    // 속성들은
    // 외부에서 접근하지 못하는게 일반적으로 좋다
    // 공격력은 공격력 그 자체만으로 의미가 있지만
    // 그 의미가 명확해지지 않는다
    // 공격력이 증가한다
    private int ATT = 10;
    private int HP = 100;

    // 상태라는건 맴버변수
    // 어떤 상태가 변화하는 순간
    // 각각 증가시키거나
    public void LVUP()
    {
        ATT = 100;
        HP = 1000;
    }

    public void SetHP(int _Hp)
    {
        // 내가 HP가 0이되는 순간만 체크할수도 있고
        // 내가 100이 되는 순간만 체크할수도 있다
        // 가장 큰 핵심은 디버깅이 된다
        HP = _Hp;
    }

    // 함수는 보통 선언과
    // 내용으로 나뉘게 되는데
    // 함수란 보통 클래스 외부와의 소통을 위해서 만든다   

    // void[리턴값] Func[이름 혹은 식별자] ()[인자값]
    public void Func(int _Dmg)
    {

    }

    // (int _Dmg)를 넣는다는 것은 외부에서
    // 한개의 int 값을 넣어서
    // 플레이어에게 전달 해주겠다
    public void Damage1(int _Dmg)
    {
        HP = HP - _Dmg;
    }

    // 두개가 될수도 있다
    // 개수는 신경안써도 될정도
    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }
}

// 플레이어가 어떤 사양과 내용을 가졌다
// 만든건 아니다

namespace _08FuncEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Player NewPlayer = new Player();
            // 그래서 필요한 것이 함수이다

            // 뭔가 증가하는 코드를 추가해줘야 하는데
            // NewPlayer.HP = NewPlayer.HP + 1;
            // NewPlayer.HP = NewPlayer.HP + 1;
            // NewPlayer.ATT = NewPlayer.ATT + 1;
            NewPlayer.LVUP();

            NewPlayer.SetHP(0);

            // 이런식으로 외부의 값을 받아서
            // 객체가 내부의 상태를 변화시키기 위해서
            // 함수를 선언하는 경우가 많다
            NewPlayer.Damage1(10);
            NewPlayer.Damage1(20);
            NewPlayer.Damage2 (10,20);

        }
    }
}