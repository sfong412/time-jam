using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerkSystem : MonoBehaviour
{
    
    UIThings3 ui;
    static public bool inkRegenPerk = true;

    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.Find("Ink Bar").GetComponent<UIThings3>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
