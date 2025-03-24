using System;
using UnityEngine;

public class fightSceneManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Fight f = new Fight();
        f.startFight();
        public GameObject monsterHP;
        public GameObject playerHP;
        
    }

    // Update is called once per frame
    void Update()
    {
      public void startFight()
    {
        
        	Player currentAttacker = this.attacker;
		Player currentDefender = this.defender;
		

		while(true) 
		{
		       Thread.sleep(10000);
		     int d4 = Random.Range(0, 15) + 1;
				int damage = d4;
				currentDefender.currHP = currHP - damage;
                monsterHP.text = "Monster's HP:" + monster.getCurrHP.ToString();
        playerHP.text = "Player's HP:" + player.getCurrHP.ToString();

				if(currentDefender.currHP = 0())
				{
					System.out.println(currentAttacker.getName() + " has won the fight!");
					break; 
				}
		if(d4 == currentDefender.currHP)
			{
				System.out.println(currentAttacker.getName() + " swings and misses");

				if(d4 == 1)
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
}
