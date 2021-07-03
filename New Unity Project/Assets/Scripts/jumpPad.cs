using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPad : MonoBehaviour
{

    public CharacterController2D jump;
    public CquirrelAI jump2;

    public ScopioAI jump3;
    // Start is called before the first frame update
    void Start()
    {
        jump = GameObject.Find("Player").GetComponent<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            jump.jumpHigh = true;
        }
    }
}
