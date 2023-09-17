using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    public int resolution;
    public float radius;

    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        lineRenderer.positionCount = resolution + 1;
        for (int i = 0; i < resolution + 1; i++)
        {
            float angle = (360 / resolution) * i;
            Vector3 pointPosition = new Vector3(Mathf.Cos(Mathf.Deg2Rad * angle), 0, Mathf.Sin(Mathf.Deg2Rad * angle));
            lineRenderer.SetPosition(i, transform.position + radius * pointPosition);
        }
    }
}
