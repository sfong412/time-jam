using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerkSystem : MonoBehaviour
{

    UIThings3 ui;
    static public bool inkRegenPerk = false;
    static public float inkRegenRate;
    static public float startingHealth;

    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.Find("Ink Bar").GetComponent<UIThings3>();

        if (inkRegenPerk == true)
        {
            inkRegenRate = 0.2f;
            startingHealth = 80;
        }
        else
        {
            inkRegenRate = 0.1f;
            startingHealth = 100;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
