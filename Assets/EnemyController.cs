using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform target;

    public Rigidbody2D rb;

    public float rotationspeed;
    public float speed;

    private HP HP;

    public bool AttPlayer = true;
    public bool triggered;
    // Start is called before the first frame update
    void Start()
    {
        // finds target to look towards
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // rotation angle 
        Vector3 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        // smooth rotation towards target
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, angle), rotationspeed * Time.deltaTime);

        rb.AddForce(transform.right * speed);
        // attacking Player
        if(AttPlayer == true && triggered == true)
        {
            StartCoroutine(Attacking(1f));
            AttPlayer = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HP = collision.GetComponent<HP>();
        
        triggered = true;
        AttPlayer = true;


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        triggered = false;
    }
    public IEnumerator Attacking(float t)
    {
        HP.Damage();
        
        yield return new WaitForSeconds(2f);
        AttPlayer = true;

    }
}
