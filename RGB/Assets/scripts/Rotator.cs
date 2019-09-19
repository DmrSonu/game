using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 rotatingAxis;
    public int rotatingSpeed;

    void Update()
    {
        transform.Rotate(rotatingAxis * Time.deltaTime * rotatingSpeed);
    }
}
