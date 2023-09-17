using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnController : MonoBehaviour
{
    public GameObject circlePrefab;
    public float startDelay;

    public GameObject[] leftSpawnPoints;
    public int leftGapSize;
    public KeyCode[] leftKeys;

    public GameObject[] rightSpawnPoints;
    public int rightGapSize;
    public KeyCode[] rightKeys;

    private float ringDuration;
    private float[] leftTimeGaps;
    private float[] rightTimeGaps;

    private bool leftReady;
    private bool rightReady;

    private Queue<GameObject> leftCircles;
    private Queue<GameObject> rightCircles;

    void Start()
    {
        leftCircles = new Queue<GameObject>();
        rightCircles = new Queue<GameObject>();
        leftTimeGaps = new float[leftGapSize];
        rightTimeGaps = new float[rightGapSize];
        SetTimes(GameManager.Instance.maxDuration, GameManager.Instance.startMinGap, GameManager.Instance.startMaxGap);
        StartCoroutine(DelayStart());
    }

    void Update()
    {
        if (leftCircles.Count > 0)
        {
            leftCircles.Peek().GetComponent<CircleController>().setActive();
        }
        if (rightCircles.Count > 0)
        {
            rightCircles.Peek().GetComponent<CircleController>().setActive();
        }

        if (leftReady)
        {
            leftReady = false;
            StartCoroutine(Spawn(true, leftSpawnPoints, leftTimeGaps, leftKeys, leftCircles));
        }
        if (rightReady)
        {
            rightReady = false;
            StartCoroutine(Spawn(false, rightSpawnPoints, rightTimeGaps, rightKeys, rightCircles));
        }
    }

    IEnumerator DelayStart()
    {
        yield return new WaitForSeconds(startDelay / 2);
        FindObjectOfType<InformationDisplay>().DisplayLevel();
        leftReady = false;
        rightReady = false;
        yield return new WaitForSeconds(startDelay / 2);
        leftReady = true;
        rightReady = true;
    }

    IEnumerator Spawn(bool left, GameObject[] spawnPoints, float[] timeGaps, KeyCode[] keys, Queue<GameObject> circles)
    {
        int randomSpawnIndex = Random.Range(0, spawnPoints.Length);
        int randomTimeIndex = Random.Range(0, timeGaps.Length);
        int randomKey;
        if (randomSpawnIndex < spawnPoints.Length / 2)
        {
            randomKey = 0;
        }
        else
        {
            randomKey = 1;
        }

        GameObject circle = Instantiate(circlePrefab);
        SetCircleColor(circle);
        circle.transform.position = spawnPoints[randomSpawnIndex].transform.position;
        circles.Enqueue(circle);

        CircleController circleController = circle.GetComponent<CircleController>();
        circleController.setKeyCode(keys[randomKey]);
        circleController.setSpawner(this.gameObject);
        circleController.setLeft(left);

        circle.transform.GetChild(0).gameObject.GetComponent<RingController>().time = ringDuration;

        yield return new WaitForSeconds(timeGaps[randomTimeIndex]);

        if (left)
        {
            leftReady = true;
        }
        else
        {
            rightReady = true;
        }
    }

    public void RemoveCircle(bool left)
    {
        if (left)
        {
            leftCircles.Dequeue();
        }
        else
        {
            rightCircles.Dequeue();
        }
    }

    public void SetTimes(float duration, float minTimeGap, float maxTimeGap)
    {
        ringDuration = duration;
        for (int i = 0; i < leftGapSize; i++)
        {
            leftTimeGaps[i] = minTimeGap + (maxTimeGap - minTimeGap) / (leftGapSize - 1) * i;
        }
        for (int i = 0; i < rightGapSize; i++)
        {
            rightTimeGaps[i] = minTimeGap + (maxTimeGap - minTimeGap) / (rightGapSize - 1) * i + 0.1f;
        }
    }

    private void SetCircleColor(GameObject circle)
    {
        Item active = InventoryManager.Instance.allItems[InventoryManager.Instance.activeColor];
        //circle.GetComponent<TextMeshProUGUI>().color = new Color32(active.r, active.g, active.b, 255);

        GameObject ring = circle.transform.GetChild(0).gameObject;
        GameObject baseCircle = circle.transform.GetChild(1).gameObject;

        ring.GetComponent<LineRenderer>().startColor = new Color32(active.r, active.g, active.b, 50);
        ring.GetComponent<LineRenderer>().endColor = new Color32(active.r, active.g, active.b, 50);

        baseCircle.GetComponent<LineRenderer>().startColor = new Color32(active.r, active.g, active.b, 255);
        baseCircle.GetComponent<LineRenderer>().endColor = new Color32(active.r, active.g, active.b, 255);
    }
}
