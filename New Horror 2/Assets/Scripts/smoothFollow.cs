using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    public float smoothspeed = 0.125f;

    void LateUpdate()
    {
        Vector3 desiredpos = target.position + offset;
        Quaternion desiredrot = target.rotation;
        Vector3 smoothpos = Vector3.Lerp(transform.position, desiredpos, smoothspeed);
        Quaternion smoothrot = Quaternion.Lerp(transform.rotation, desiredrot, smoothspeed);

        transform.position = smoothpos;
        transform.rotation = smoothrot;
    }
}
