using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject gun;
    public GameObject Enemy; 
    // Start is called before the first frame update
    void Start()
    {
        gun.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
        
            if(Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                gun.SetActive(true);
                Enemy.SetActive(true);
            }
        }
    }
   
}
