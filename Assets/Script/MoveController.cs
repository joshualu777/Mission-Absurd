using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
    }
}
