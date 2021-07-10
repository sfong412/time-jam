using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioFix1 : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioSource footSteps1;

    public Gameplay gamePlay;
    public AudioClip blockplaced;

    public AudioClip spikeHit;

    public AudioClip blockErased;

    public AudioClip blockErased2;

    public AudioClip blockErased3;

    public AudioClip damaged;

    public AudioClip noInk;

    public AudioClip jump;

    public AudioClip JumpPad;

    public AudioClip blockPlaced2;

    public AudioClip blockPlaced3;

    public AudioClip blockPlaced4;

    public AudioClip moew;

    public AudioClip moew2;

    public AudioClip moew3;

    public AudioClip catHit;

    public AudioClip catHit2;
    public AudioClip scorpionJump;
    public AudioClip spitBall;
    public AudioClip boss1;
    public AudioClip boss2;

    public AudioClip hitBoss;
    public AudioClip hitBoss1;
    public AudioClip hitBoss2;
    public DamageScript hitMan;

    public UIThings3 things;

    public UIThings heyl;

    public CharacterController2D jumping;

    public bool meow2;

    public bool jumps;

    public Boss boss;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        footSteps1 = GameObject.Find("AudioController(3)").GetComponent<AudioSource>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gamePlay.blockPlaced == true)
        {
            var blockPlacedvaration = Random.Range(0, 3);

            switch (blockPlacedvaration)
            {
                case 0:
                audioSource.PlayOneShot(blockplaced, 0.3f);
                break;

                case 1:
                audioSource.PlayOneShot(blockPlaced2, 0.3f);
                break;

                case 2:
                audioSource.PlayOneShot(blockPlaced3, 0.3f);
                break;

                case 3:
                audioSource.PlayOneShot(blockPlaced4, 0.3f);
                break;

            }
            
        }

        if (hitMan.damaged5 == true)
        {
            audioSource.PlayOneShot(spikeHit, 0.3f);
        }

        if (things.erased == true)
        {
            var erasedBlockVaration = Random.Range(0, 2);
            switch (erasedBlockVaration)
            {
                case 0:
                audioSource.PlayOneShot(blockErased, 0.3f);
                break;

                case 1: 
                audioSource.PlayOneShot(blockErased2, 0.3f);
                break;

                case 2: 
                audioSource.PlayOneShot(blockErased3, 0.3f);
                break;
            }
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
            audioSource.PlayOneShot(noInk, 0.8f);
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

        if (jumping.isMoving == true && jumping.Jumped == false)
        {
            if (!footSteps1.isPlaying)
            {
                  footSteps1.Play();
            }
          
        }
        else
        {
            footSteps1.Pause();
        }

        if (meow2 == true)
        {
             var meowVaration = Random.Range(0, 2);
            switch (meowVaration)
            {
                case 0:
                audioSource.PlayOneShot(moew, 0.1f);
                break;

                case 1: 
                audioSource.PlayOneShot(moew2, 0.1f);
                break;

                case 2: 
                audioSource.PlayOneShot(moew3, 0.1f);
                break;
            }
            meow2 = false;
        }

        if (hitMan.triggerDamaged4 == true)
        {
             var catHitVaration = Random.Range(0, 2);
            switch (catHitVaration)
            {
               case 0:
               audioSource.PlayOneShot(catHit, 0.1f);
               break;
               case 1:
               audioSource.PlayOneShot(catHit2, 0.1f); 
               break;

            }
        }

        if (boss.dog == true)
        {
            audioSource.PlayOneShot(spitBall, 0.5f);
            boss.dog = false;
        }

        
        if (boss.dog2 == true)
        {
             var bossSwearVariation = Random.Range(0, 2);
            switch (bossSwearVariation)
            {
               case 0:
               audioSource.PlayOneShot(boss1, 0.5f);
               break;
               case 1:
               audioSource.PlayOneShot(boss2, 0.5f); 
               break;
            }
            boss.dog2 = false;
        }

        if (boss.dog3 == true)
        {
            var hitBossVaration = Random.Range(0,2);
            switch (hitBossVaration)
            {
                case 0:
                audioSource.PlayOneShot(hitBoss, 0.5f);
                break;
                case 1:
                audioSource.PlayOneShot(hitBoss1, 0.5f);
                break;
                case 2: 
                audioSource.PlayOneShot(hitBoss2, 0.5f);
                break;
            }
            boss.dog3 = false;
        }

        if (heyl.stopping == true)
        {
            audioSource.volume = 0;
        }

    }

   
}
