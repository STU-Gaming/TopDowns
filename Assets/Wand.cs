using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wand : MonoBehaviour
{
    public GameObject bow;

    public GameObject arrow;

    public Transform shootpoint;

    public bool enemydetec = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemydetec == true && GetComponentInParent<EnemyController>().PlayerDetected == true)
        {
            StartCoroutine(Attacking(1f));
        }
        
    }

    public IEnumerator Attacking(float t)
    {
        GameObject Arrow = Instantiate(arrow, shootpoint.position, shootpoint.rotation);
        Arrow.GetComponent<Rigidbody2D>().AddForce(transform.up * 1000);
        enemydetec = false;
        yield return new WaitForSeconds(0.5f);
        enemydetec = true;

    }
}
