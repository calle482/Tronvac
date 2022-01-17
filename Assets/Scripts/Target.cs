using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{

    public float health = 10f;
    TargetSpawner targetSpawner;
    public AudioSource source;
    public AudioClip clip;



    void Start()
    {
        targetSpawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<TargetSpawner>();
        source = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
    }


   

    // Gör så att enemyn tas bort när den får noll health och sänker värdet av TargetCount med 1
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Score.scoreValue +=1;
            Destroy(this.gameObject);
            targetSpawner.TargetCount --;
            source.PlayOneShot(clip);
        }
    }

    
}
