using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rigid;

    public Transform child;
    public Transform sword;

    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigid.AddForce(transform.up * speed);
            child.rotation = Quaternion.Euler(0, 0, 0);
            sword.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            rigid.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigid.AddForce(transform.up * -speed);
            child.localRotation = Quaternion.Euler(0, 0, -180);
            sword.localRotation = Quaternion.Euler(0, 0, -180);
        }
        else
        {
            rigid.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigid.AddForce(transform.right * speed);
            child.localRotation = Quaternion.Euler(0, 0, -90);
            sword.localRotation = Quaternion.Euler(0, 0, -90);
        }
        else
        {
            rigid.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddForce(transform.right * -speed);
            child.localRotation = Quaternion.Euler(0, 0, 90);
            sword.localRotation = Quaternion.Euler(0, 0, 90);
        }
        else
        {
            rigid.velocity = new Vector3(0, 0, 0);
        }
    }
}
