using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public bool isattacking = true;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isattacking = true;
            anim.SetTrigger("attack");
            gameObject.GetComponentInChildren<attacking>().attacki = false;
        }

    }
    
}
