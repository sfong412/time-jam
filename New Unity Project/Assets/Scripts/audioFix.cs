using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioFix : MonoBehaviour
{
    public AudioSource audioSource;

    public Gameplay gamePlay;

    public float currentPitch;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gamePlay.slowDownThereBuster == true && gamePlay.canSlow == true)
        {
            audioSource.pitch = currentPitch;
        }
        if (gamePlay.canSlow == false || gamePlay.slowDownThereBuster == false)
        {
            audioSource.pitch = 1f;
            currentPitch = 1;
        }
    }

    void FixedUpdate()
    {
        if (gamePlay.slowDownThereBuster == true && gamePlay.canSlow == true)
        {
            if (currentPitch > 0.41f)
            {
                 currentPitch -= 0.04f;
            }
           
        }
    }
}
