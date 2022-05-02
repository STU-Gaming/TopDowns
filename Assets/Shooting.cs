using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bow;

    public GameObject Projectile;

    public Transform shootpoint;

    public float force = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
          GameObject Arrow = Instantiate(Projectile, shootpoint.position, shootpoint.rotation);
            Arrow.GetComponent<Rigidbody2D>().AddForce(transform.up * 1000);
        }
    }
}
