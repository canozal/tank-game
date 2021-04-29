using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip playerHitSound, FireSound, enemyDeadSound;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        playerHitSound = Resources.Load<AudioClip>("playerHit");
        FireSound = Resources.Load<AudioClip>("fire");
        enemyDeadSound = Resources.Load<AudioClip>("enemyDead");

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "fire":
                audioSource.PlayOneShot(FireSound);
                break;
            case "playerHit":
                audioSource.PlayOneShot(playerHitSound);
                break;
            case "enemyDead":
                audioSource.PlayOneShot(enemyDeadSound);
                break;
        }
    }
}
