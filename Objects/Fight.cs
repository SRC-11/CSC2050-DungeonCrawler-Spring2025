using UnityEngine;

public class Fight
{
    private Inhabitant attacker;
    private Inhabitant defender;

    public Fight()
    {
        int roll = Random.Range(0, 20) + 1;
        if (roll <= 10)
        {
            Debug.Log("Monster goes first");
        }
        else
        {
            Debug.Log("Player goes first");
        }

    }

    public void startFight()
    {
        //should have the attacker and defender fight each until one of them dies.
        //the attacker and defender should alternate between each fight round and
        //the one who goes first was determined in the constructor.
        	Player currentAttacker = this.attacker;
		Player currentDefender = this.defender;
		

		while(true) 
		{
		    this.attacker.display();
		    this.defender.display();
		    
		
		     int d4 = Random.Range(0, 15) + 1;
			if(attackRoll >= currentDefender.getAC())
			{
		
				int damage = d4;
				currentDefender.takeDamage(damage);

				if(currentDefender.isDead())
				{
					System.out.println(currentAttacker.getName() + " has won the fight!");
					break; 
				}
			}
			else
			{
			
				System.out.println(currentAttacker.getName() + " swings and misses");

				if(attackRoll == 1)
				{
					System.out.println("**** Critical Miss **** " + currentAttacker.getName() + " stumbles and stabs themselves in the foot!");
				}
			}

		
			Player temp = currentAttacker;
			currentAttacker = currentDefender;
			currentDefender = temp;
		} 
		
		
		System.out.println("Game Over!!!!");
		
    }
}
