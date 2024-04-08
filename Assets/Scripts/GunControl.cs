
using UnityEngine;

public class GunControl : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public ParticleSystem muzzle;
    public AudioSource sound;
    // Start is called before the first frame update
    
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            sound.Play();
            muzzle.Play();
        }
        
    }
    void Shoot()
    {
        Vector3 origin = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        RaycastHit hit;
        if (Physics.Raycast(origin, direction, out hit, range))
        {
           Enemy enemy = hit.transform.GetComponent<Enemy>();
           if(enemy)
           {
             enemy.TakeDamage(damage);
           }
        }
    }
}
