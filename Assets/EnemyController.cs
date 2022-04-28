using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform target;

    public Rigidbody2D rb;

    public float rotationspeed;
    public float speed;
    private float defSpeed;
    public float detectionradius;

    public bool PlayerDetected;

    public LayerMask Playerlayer;

    // Start is called before the first frame update
    void Start()
    {
        // finds target to look towards
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb = this.GetComponent<Rigidbody2D>();
        defSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(this.transform.position, detectionradius, Playerlayer))
        {
            PlayerDetected = true;
        }
        else
        {
            PlayerDetected = false;
        }

        if(PlayerDetected == true)
        {
            // rotation angle 
            Vector3 direction = target.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            // smooth rotation towards target
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, angle), rotationspeed * Time.deltaTime);

            rb.AddForce(transform.right * speed);

            if (this.transform.position.y <= target.position.y + 5 && this.transform.position.x <= target.position.x + 5)
            {
                speed = defSpeed - 2;
            }
            else
            {
                speed = defSpeed;
            }
        }
        
    }
    
}
