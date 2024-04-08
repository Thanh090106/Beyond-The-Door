using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    
    
    //public Image healthbar;
    public float healthamount = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(healthamount<=0)
        {
            
            Application.LoadLevel("PlayAgain");
        }
    }
    
    void OnTriggerStay(Collider player)
    {
        if(player.gameObject.CompareTag("Enemy"))
        {
            print("hit");
            TakeDamage(10f);
           
        }
        
    }
    public void TakeDamage(float damage)
    {
        healthamount -= damage;
        

    }
    
}
