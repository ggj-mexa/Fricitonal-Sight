using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsScript : MonoBehaviour
{
    public AudioSource[] foots;
    public AudioClip[] steps;
    public float[] timer;

    private void Update()
    {
        timer[0] -= Time.deltaTime;
        timer[1] -= Time.deltaTime;
        if (timer[0] < 0) { 
            foots[0].clip = steps[Random.Range(0, 3)];
            foots[0].Play();
            timer[0] = 4;
        }
        if (timer[1] < 0) {
            foots[1].clip = steps[Random.Range(4, 7)];
            foots[1].Play();
            timer[1] = 4;
        }

    }
}
