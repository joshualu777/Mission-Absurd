using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CircleController : MonoBehaviour
{
    private bool isActive;
    private GameObject ring;
    private KeyCode keyCode;
    private bool left;

    private GameObject spawner;
    private TextMeshPro text;

    void Start()
    {
        isActive = false;
        ring = transform.GetChild(0).gameObject;
        text = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        if (text != null)
        {
            text.text = keyCode.ToString();
        }

        if (isActive && Input.GetKeyDown(keyCode))
        {
            float ratio = ring.GetComponent<RingController>().GetRatio();
            if (ratio > 0.7)
            {
                GameManager.Instance.DecreaseHealth(200);
            }
            else
            {
                if (ratio > 0.5)
                {
                    GameManager.Instance.DecreaseHealth(200);
                }
                else if (ratio > 0.3)
                {
                    GameManager.Instance.AddScore(50);
                    GameManager.Instance.IncreaseHealth(5);
                }
                else if (ratio > 0.1)
                {
                    GameManager.Instance.AddScore(100);
                    GameManager.Instance.IncreaseHealth(10);
                }
                else
                {
                    GameManager.Instance.AddScore(300);
                    GameManager.Instance.IncreaseHealth(20);
                }
                DestroyObject();
            }
        }
    }

    public void setKeyCode(KeyCode key)
    {
        keyCode = key;
    }

    public void setActive()
    {
        isActive = true;
    }

    public void setLeft(bool value)
    {
        left = value;
    }

    public void setSpawner(GameObject gameObject)
    {
        spawner = gameObject;
    }

    public void DestroyObject()
    {
        spawner.GetComponent<SpawnController>().RemoveCircle(left);
        Destroy(this.gameObject);
    }
}
