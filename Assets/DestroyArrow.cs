using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArrow : MonoBehaviour
{
    health Health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Health = collision.GetComponent<health>();
        Health.Damage();
        Destroy(this.gameObject);

    }
}
