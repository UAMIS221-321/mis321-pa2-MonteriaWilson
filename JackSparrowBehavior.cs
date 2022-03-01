using mis321_pa2_MonteriaWilson_1.interfaces;
namespace mis321_pa2_MonteriaWilson_1
{
    public class JackSparrowBehavior: IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("You distracted your opponent and won the round");
        }
        
    }
}