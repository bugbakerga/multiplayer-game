using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandwhichtrigger : MonoBehaviour
{
    public Sandwhichqueston sandwhichlogic;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            sandwhichlogic.Queston();
            Destroy(gameObject);
        }
    }
}
