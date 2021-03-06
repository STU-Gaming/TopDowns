using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    //Enemy Health Script
    public SpriteRenderer Sprite;

    public float Health = 20;

    
    // Start is called before the first frame update
    void Start()
    {
        Sprite = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void Damage(float dmg)
    {
        Sprite.color = Color.red;
        Health -= dmg;
        StartCoroutine(ChangeColor(1f));
    }
    public IEnumerator ChangeColor(float t)
    {
        yield return new WaitForSeconds(0.05f);
        Sprite.color = Color.white;

    }
}
