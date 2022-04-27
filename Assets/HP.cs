using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    //Player Health Script
    public SpriteRenderer Sprite;

    public float Health = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
    }
    public void Damage()
    {
        Sprite.color = Color.red;
        Health -= 2;
        StartCoroutine(ChangeColor(1f));
    }
    public IEnumerator ChangeColor(float t)
    {
        yield return new WaitForSeconds(0.05f);
        Sprite.color = Color.white;

    }
}
