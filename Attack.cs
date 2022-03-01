using mis321_pa2_MonteriaWilson_1.interfaces;
namespace mis321_pa2_MonteriaWilson_1
{
    public class Attack
    {
        public IAttack attackBehavior{get;set;}

        public Attack()
        {
            attackBehavior = new JackSparrowBehavior();
        }
        
    }
}