using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingController : MonoBehaviour
{
    public int resolution;
    public float startRadius;
    public float endRadius;
    public float time;

    private LineRenderer lineRenderer;
    private float currentRadius;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        currentRadius = startRadius;
    }

    void Update()
    {
        lineRenderer.positionCount = resolution + 1;
        for (int i = 0; i < resolution + 1; i++)
        {
            float angle = (360 / resolution) * i;
            Vector3 pointPosition = new Vector3(Mathf.Cos(Mathf.Deg2Rad * angle), 0, Mathf.Sin(Mathf.Deg2Rad * angle));
            lineRenderer.SetPosition(i, transform.position + currentRadius * pointPosition);
        }

        currentRadius -= (startRadius - endRadius) * Time.deltaTime / time;
        if (currentRadius < endRadius)
        {
            GameManager.Instance.DecreaseHealth(200);
            this.gameObject.transform.parent.gameObject.GetComponent<CircleController>().DestroyObject();
        }
    }

    public float GetRatio()
    {
        return Mathf.Abs(currentRadius - endRadius) / (startRadius - endRadius);
    }
}
