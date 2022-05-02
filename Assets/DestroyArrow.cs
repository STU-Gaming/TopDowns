using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArrow : MonoBehaviour
{
    health Health;

    public float range = 1;

    public float  dmg;

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, range);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Health = collision.GetComponent<health>();
        Health.Damage(dmg);
        Destroy(this.gameObject);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
