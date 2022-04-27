using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacking : MonoBehaviour
{
    health Health;
    private GameObject[] enemies;

    public bool attacki = true;
  
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
    }

    // Update is called once per frame
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(attacki == false)
        {
            Health = collision.GetComponent<health>();
            Health.Damage();
        }
        
    }
    public void isattackings()
    {
        attacki = true;

    }

}
