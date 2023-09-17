using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    public int speed;

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0); //rotates 50 degrees per second around z axis
    }
}
