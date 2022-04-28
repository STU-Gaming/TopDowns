using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireBall : MonoBehaviour
{
    private HP HP;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 0.5f);
    }

    // Update is called once per frame
  
    private void OnTriggerEnter2D(Collider2D collision)
    {

        HP = collision.GetComponent<HP>();
        HP.Damage();
        Destroy(this.gameObject);

    }
}
