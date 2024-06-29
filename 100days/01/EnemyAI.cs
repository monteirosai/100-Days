using System.Collections;
using System.Collections.Generic;

public class EnemyAI
{
   float health;
   int speed;
   string enemyName;

   EnemyWepon weapon;

   int[] intArray = new int[] { 1,2,3,4,5,6,7,8,9,10 };

   List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9,10 };

   void Movement()
   {

      foreach (int intNunmbers in intArray)

       if(speed >= 0 && health > 0)
       {
          
       }
       for (int i = 0; i < intArray.Length; i++)
       {
            int currentNumber = intArray[i];
       }
       for (int i = 0; i < intList.Count; i++)
       {
         int currentNumber = intList[i];
       }
   }

   void Dead()
   {
    if(health <= 0)
    {

    }
   }

   void Attack()
   {
      weapon.damage = 90;
      weapon.fireRate = 0.4f;
      weapon.Shoot();
   }
}
public class EnemyWepon
{
    public float damage;
    public float fireRate;

    public void Shoot()
    {

    }
}