using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    
    public Respawn win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Load()
    {
        Application.LoadLevel("MainGame");
    }
    public void Quit()
    {
        Application.Quit();
    }
    
}
