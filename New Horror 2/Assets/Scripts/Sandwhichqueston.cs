using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Sandwhichqueston : MonoBehaviour
{
    public GameObject sandwhich;
    public NavMeshAgent agent;
    public PlayerFullMovement playercont;

    public bool ispursuing;

    public int rng;

    public Transform thePlayer;
    public Transform origonalpos;

    //ui stuff
    public RawImage display;
    public Texture2D[] textures;
    public Text theField;
    public string[] answers;
    public GameObject displayParent;

    //anim & audio
    public AudioSource speaker;
    public AudioClip[] clips;
    public Animator animplayer;

    public void questonstart()
    {
        ispursuing = false;
        displayParent.SetActive(true);
        rng = Random.Range(0, textures.Length);
        display.texture = textures[rng];
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        speaker.PlayOneShot(clips[0]);
        agent.isStopped = true;
        animplayer.SetBool("moving", false);
    }

    void Update()
    {  
        if(ispursuing == true)
        {
            agent.SetDestination(thePlayer.position);
            animplayer.SetBool("moving", true);
        }
    }

    public void Queston()
    {
        sandwhich.SetActive(true);
        ispursuing = true;
    }

    public void Answer()
    {
        if(theField.text == answers[rng])
        {
            sandwhich.transform.position = origonalpos.position;
            sandwhich.SetActive(false);
            displayParent.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            playercont.speed = 5;
        }
        else
        {
            theField.text = "";
            speaker.PlayOneShot(clips[1]);
        }
    }
}
