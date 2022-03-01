using System;
using mis321_pa2_MonteriaWilson_1.interfaces;

namespace mis321_pa2_MonteriaWilson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Attack myAttack = new Attack();
            Console.WriteLine("What is player's one name?");
            string playerone = Console.ReadLine();
            Random randomPower = new Random();
            int playeronePower = randomPower.Next(1,100);
            int Health = 100;
            Random randomAttack = new Random();
            int attackStrength = randomAttack.Next(1,playeronePower);
            Random randomDefense = new Random();
            int defensePower = randomDefense.Next(1,playeronePower);
            int playeronepoints =0;
            character myCharacter = new character() {Name= playerone,Power =playeronePower,Health=Health, Strength =attackStrength,Defense=defensePower,Points=playeronepoints};

            Console.WriteLine("What is player's two name?");
            string playertwo = Console.ReadLine();
            Random randomPowertwo = new Random();
            int playertwoPower = randomPower.Next(1,100);
            int HealthTwo = 100;
            Random randomAttackTwo = new Random();
            int attackStrengthTwo = randomAttack.Next(1,playeronePower);
            Random randomDefenseTwo = new Random();
            int defensePowerTwo = randomDefense.Next(1,playeronePower);
            int playertwopoints =0;
            character myCharacterTwo = new character() {Name= playertwo,Power =playertwoPower,Health=HealthTwo, Strength =attackStrengthTwo,Defense=defensePowerTwo,Points=playertwopoints};
            while(Health != 0 || HealthTwo !=0)
            {
            Random attacker = new Random();
            int firstattacker = attacker.Next(1,2);
            while(firstattacker ==1)
            {
            Console.WriteLine("Player One choose your character: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
            int playeronechoice = int.Parse(Console.ReadLine());
            Console.WriteLine("Player Two choose your charcter:\n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
            int playertwochoice = int.Parse(Console.ReadLine());
            if(playeronechoice == 1 && playertwochoice==2)
            {
                myAttack.attackBehavior.Attack();
                double DamageDealt = (playeronePower - defensePowerTwo) * 1.2;
                Console.WriteLine("Damage delt is : " + DamageDealt);
                int playernewhealth = HealthTwo -20;
                HealthTwo=playernewhealth;
                playeronepoints = playeronepoints+10;
                Console.WriteLine("Player two stats: " + myCharacterTwo.Name + myCharacterTwo.Power + myCharacterTwo.Strength +myCharacterTwo.Defense + myCharacterTwo.Health + myCharacterTwo.Points);
                

            }
            else if(playeronechoice == 2 && playertwochoice == 3)
            {
                myAttack.attackBehavior = new WillTurnerBehavior();
                myAttack.attackBehavior.Attack();
                double DamageDealt = (playeronePower - defensePowerTwo) * 1.2;
                Console.WriteLine("Damage delt is : " + DamageDealt);
                int playernewhealth = HealthTwo -20;
                HealthTwo=playernewhealth;
                playeronepoints = playeronepoints+10;
                Console.WriteLine("Player two stats: " + myCharacterTwo.Name + myCharacterTwo.Power + myCharacterTwo.Strength +myCharacterTwo.Defense + myCharacterTwo.Health + myCharacterTwo.Points);
                
                
            }
            else if(playeronechoice == 3 && playertwochoice == 1)
            {
                myAttack.attackBehavior = new DavyJonesBehavior();
                myAttack.attackBehavior.Attack();
                double DamageDealt = (playeronePower - defensePowerTwo) * 1.2;
                Console.WriteLine("Damage delt is : " + DamageDealt);
                int playernewhealth = HealthTwo -20;
                HealthTwo=playernewhealth;
                playeronepoints = playeronepoints+10;
                Console.WriteLine("Player two stats: " + myCharacterTwo.Name + myCharacterTwo.Power + myCharacterTwo.Strength +myCharacterTwo.Defense + myCharacterTwo.Health + myCharacterTwo.Points);
            }
             else if(playeronechoice == 2 && playertwochoice==1)
            {
                myAttack.attackBehavior.Attack();
                double DamageDealt = (playeronePower - defensePowerTwo) * 1;
                Console.WriteLine("Damage delt is : " + DamageDealt);
                int playerhealth = Health -20;
                Health = playerhealth;
                playertwopoints=playertwopoints+10;
               Console.WriteLine("Player two stats: " + myCharacterTwo.Name + myCharacterTwo.Power + myCharacterTwo.Strength +myCharacterTwo.Defense + myCharacterTwo.Health + myCharacterTwo.Points);

            }
            else if(playeronechoice == 3 && playertwochoice == 2)
            {
                myAttack.attackBehavior = new WillTurnerBehavior();
                myAttack.attackBehavior.Attack();
                double DamageDealt = (playeronePower - defensePowerTwo) * 1;
                Console.WriteLine("Damage delt is : " + DamageDealt);
                int playerhealth = Health -20;
                Health = playerhealth;
                playertwopoints=playertwopoints+10;
                Console.WriteLine("Player two stats: " + myCharacterTwo.Name + myCharacterTwo.Power + myCharacterTwo.Strength +myCharacterTwo.Defense + myCharacterTwo.Health + myCharacterTwo.Points);
                
            }
            else if(playeronechoice == 1 && playertwochoice == 3)
            {
                myAttack.attackBehavior = new DavyJonesBehavior();
                myAttack.attackBehavior.Attack();
                double DamageDealt = (playeronePower - defensePowerTwo) * 1;
                Console.WriteLine("Damage delt is : " + DamageDealt);
                int playerhealth = Health -20;
                Health = playerhealth;
                playertwopoints=playertwopoints+10;
                Console.WriteLine("Player two stats: " + myCharacterTwo.Name + myCharacterTwo.Power + myCharacterTwo.Strength +myCharacterTwo.Defense + myCharacterTwo.Health + myCharacterTwo.Points);
            }
            while(firstattacker==2)
            {
            Console.WriteLine("Player One choose your character: \n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
            int playeronechoice2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Player Two choose your character:\n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones");
            int playertwochoice2 = int.Parse(Console.ReadLine());
            if(playeronechoice == 1 && playertwochoice==2)
            {
                myAttack.attackBehavior.Attack();
                double DamageDealt = (playeronePower - defensePowerTwo) * 1;
                Console.WriteLine("Damage delt is : " + DamageDealt);
                int playernewhealth = HealthTwo-20;
                HealthTwo = playernewhealth;
                playeronepoints = playeronepoints+10;
                Console.WriteLine("Player one stats: " + myCharacter.Name + myCharacter.Power + myCharacter.Strength +myCharacter.Defense + myCharacter.Health + myCharacter.Points);

            }
            else if(playeronechoice == 2 && playertwochoice == 3)
            {
                myAttack.attackBehavior = new WillTurnerBehavior();
                myAttack.attackBehavior.Attack();
                double DamageDealt = (playeronePower - defensePowerTwo) * 1;
                Console.WriteLine("Damage delt is : " + DamageDealt);
                int playernewhealth = HealthTwo-20;
                HealthTwo = playernewhealth;
                playeronepoints = playeronepoints+10;
                Console.WriteLine("Player one stats: " + myCharacter.Name + myCharacter.Power + myCharacter.Strength +myCharacter.Defense + myCharacter.Health + myCharacter.Points);
            }
            else if(playeronechoice == 3 && playertwochoice == 1)
            {
                myAttack.attackBehavior = new DavyJonesBehavior();
                myAttack.attackBehavior.Attack();
                double DamageDealt = (playeronePower - defensePowerTwo) * 1;
                Console.WriteLine("Damage delt is : " + DamageDealt);
                int playernewhealth = HealthTwo-20;
                HealthTwo = playernewhealth;
                playeronepoints = playeronepoints+10;
                Console.WriteLine("Player one stats: " + myCharacter.Name + myCharacter.Power + myCharacter.Strength +myCharacter.Defense + myCharacter.Health + myCharacter.Points);
            }
             else if(playeronechoice == 2 && playertwochoice==1)
            {
                myAttack.attackBehavior.Attack();
                double DamageDealt = (playeronePower - defensePowerTwo) * 1.2;
                Console.WriteLine("Damage delt is : " + DamageDealt);
                int playerhealth = Health -20;
                Health = playerhealth;
                playertwopoints=playertwopoints+10;
                Console.WriteLine("Player one stats: " + myCharacter.Name + myCharacter.Power + myCharacter.Strength +myCharacter.Defense + myCharacter.Health + myCharacter.Points);

            }
            else if(playeronechoice == 3 && playertwochoice == 2)
            {
                myAttack.attackBehavior = new WillTurnerBehavior();
                myAttack.attackBehavior.Attack();
                double DamageDealt = (playeronePower - defensePowerTwo) * 1.2;
                Console.WriteLine("Damage delt is : " + DamageDealt);
                int playerhealth = Health -20;
                Health = playerhealth;
                playertwopoints=playertwopoints+10;
                Console.WriteLine("Player one stats: " + myCharacter.Name + myCharacter.Power + myCharacter.Strength +myCharacter.Defense + myCharacter.Health + myCharacter.Points);
                
            }
            else if(playeronechoice == 1 && playertwochoice == 3)
            {
                myAttack.attackBehavior = new DavyJonesBehavior();
                myAttack.attackBehavior.Attack();
                double DamageDealt = (playeronePower - defensePowerTwo) * 1.2;
                Console.WriteLine("Damage delt is : " + DamageDealt);
                int playerhealth = Health -20;
                Health = playerhealth;
                playertwopoints=playertwopoints+10;
                Console.WriteLine("Player one stats: " + myCharacter.Name + myCharacter.Power + myCharacter.Strength +myCharacter.Defense + myCharacter.Health + myCharacter.Points);
            }
            }
            Console.WriteLine("Game over!");
            Console.WriteLine("Player one stats: " + myCharacter.Name + myCharacter.Power + myCharacter.Strength +myCharacter.Defense + myCharacter.Health + myCharacter.Points);
            Console.WriteLine("Player two stats: " + myCharacterTwo.Name + myCharacterTwo.Power + myCharacterTwo.Strength +myCharacterTwo.Defense + myCharacterTwo.Health + myCharacterTwo.Points);


            }
            }


            
            

        }
    }


}
