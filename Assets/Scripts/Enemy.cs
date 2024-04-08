
using UnityEngine;

public class Enemy : MonoBehaviour
{

    
    public float health = 20f;
    public bool dead = false; 
    public GameObject enemy; 
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
           Die();
        }
    }
     
    void Die()
    {
        Destroy(gameObject);
        dead = true;
    }
    
    public bool IsDead()
    {
       if(enemy==null)
       {
         dead = true; 
       }
       return dead;
    }
   
    
    
}
