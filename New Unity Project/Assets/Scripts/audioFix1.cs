using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioFix1 : MonoBehaviour
{
    public AudioSource audioSource;

    public Gameplay gamePlay;

    public float currentPitch;

    public AudioClip blockplaced;

    public AudioClip spikeHit;

    public AudioClip blockErased;

    public AudioClip damaged;

    public AudioClip noInk;

    public AudioClip jump;

    public AudioClip JumpPad;
    public DamageScript hitMan;

    public UIThings3 things;

    public CharacterController2D jumping;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gamePlay.blockPlaced == true)
        {
            audioSource.PlayOneShot(blockplaced, 0.3f);
        }

        if (hitMan.damaged5 == true)
        {
            audioSource.PlayOneShot(spikeHit, 0.3f);
        }

        if (things.erased == true)
        {
            audioSource.PlayOneShot(blockErased, 0.3f);
        }

        if (hitMan.damaged == true)
        {
            audioSource.PlayOneShot(damaged, 0.4f);
        }

         if (hitMan.damaged3 == true)
        {
            audioSource.PlayOneShot(damaged , 0.4f);
        }

        if(things.gameplaying.shake == true)
        {
            audioSource.PlayOneShot(noInk, 0.5f);
        }

        if (jumping.Jumped == true)
        {
            audioSource.PlayOneShot(jump, 0.3f);
            jumping.Jumped = false;
        }

        if (jumping.jumpHigh == true)
        {
            audioSource.PlayOneShot(JumpPad, 0.3f);
        }
    }

   
}
