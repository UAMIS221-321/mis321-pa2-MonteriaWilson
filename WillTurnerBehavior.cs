using mis321_pa2_MonteriaWilson_1.interfaces;
namespace mis321_pa2_MonteriaWilson_1
{
    public class WillTurnerBehavior: IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("You used your sword to beat your opponent");
        }
    }
}