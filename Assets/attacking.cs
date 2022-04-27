using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacking : MonoBehaviour
{
    
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        
    }

    // Update is called once per frame
    void isattackings()
    {
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
            Destroy(collision.gameObject);
        
    }

}
