using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    private GameObject ShortSword;
    private GameObject Sword;
    private GameObject Wand;
    private GameObject Bow;
    // Start is called before the first frame update
    void Start()
    {
        ShortSword = this.gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
        Sword = this.gameObject.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject;
        Wand = this.gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject;
        Bow = this.gameObject.transform.GetChild(1).gameObject.transform.GetChild(3).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            
            ShortSword.SetActive(true);
            Sword.SetActive(false);
            Wand.SetActive(false);
            Bow.SetActive(false);
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            Sword.SetActive(true);
            ShortSword.SetActive(false);
            Wand.SetActive(false);
            Bow.SetActive(false);
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            Sword.SetActive(false);
            ShortSword.SetActive(false);
            Wand.SetActive(true);
            Bow.SetActive(false);
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {

            Sword.SetActive(false);
            ShortSword.SetActive(false);
            Wand.SetActive(false);
            Bow.SetActive(true);
            
        }
    }
}
