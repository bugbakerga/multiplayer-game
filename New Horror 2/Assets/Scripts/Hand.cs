using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public Animator walkAnimation;

    // Update is called once per frame
    void Update()
    {
        CheckForPlayerInput();
    }

    void CheckForPlayerInput()
    {
        if (Mathf.Abs(Input.GetAxis("Vertical")) > 0||
        Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            walkAnimation.SetBool("moving", true); 
        }

        else
        {
            walkAnimation.SetBool("moving", false);
        }
    }
}
