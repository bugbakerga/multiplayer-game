using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playrandomsound : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource speaker;

    public void PlaySound()
    {
        int indexsound = Random.Range(0, clips.Length);
        speaker.PlayOneShot(clips[indexsound]);
    }
}
