using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacking : MonoBehaviour
{
    health Health;
    private GameObject[] enemies;

    public bool attacki = true;
    
    public bool isattacking = true;


    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //object finding
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Input 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isattacking = true;
            anim.SetTrigger("attack");
            attacki = false;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            isattacking = false;
        }
        //starting the attack
        if (attacki == false && isattacking == true)
        {
            StartCoroutine(Attacking(1f));
            attacki = true;
        }
    }
    //this is for so the attack doesnt happend multiple times in one click
    public IEnumerator Attacking(float t)
    {
        Health.Damage();

        yield return new WaitForSeconds(2f);
        attacki = false;
    }

    //Enemy collision detection
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
         Health = collision.GetComponent<health>();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Health = null;
    }
}
