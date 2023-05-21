using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerScore : MonoBehaviour
{
    public AudioSource scoreAudio;

    void OnTriggerEnter2D(Collider2D collision)
    {

        Score.instance.AddPoint();
        scoreAudio.Play();
    }
}
