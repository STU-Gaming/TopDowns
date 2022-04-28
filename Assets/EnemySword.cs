using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySword : MonoBehaviour
{
    private HP HP;

    public bool AttPlayer = true;
    public bool triggered;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        // attacking Player
        if (AttPlayer == true && triggered == true)
        {
            StartCoroutine(Attacking(1f));
            AttPlayer = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HP = collision.GetComponent<HP>();

        triggered = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        triggered = false;
    }
    public IEnumerator Attacking(float t)
    {
        HP.Damage();

        yield return new WaitForSeconds(1f);
        AttPlayer = true;

    }
}
