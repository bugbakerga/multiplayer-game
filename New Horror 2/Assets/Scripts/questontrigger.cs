using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questontrigger : MonoBehaviour
{
    public Sandwhichqueston sandwhichlogic;
    public PlayerFullMovement playercont;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            sandwhichlogic.questonstart();
            playercont.speed = 0f;
        }
    }
}
