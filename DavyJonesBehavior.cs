using mis321_pa2_MonteriaWilson_1.interfaces;
namespace mis321_pa2_MonteriaWilson_1
{
    public class DavyJonesBehavior: IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("You used cannon fire to beat your opponent");
        }
    }
}