using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SimpleSpinner : MonoBehaviour
{
    [Header("Rotation")]
    public bool Rotation = false;
    [Range(-10, 10), Tooltip("Value in Hz (revolutions per second).")]
    public float RotationSpeed = 1;
    public AnimationCurve NewRotationSpeed;
    public AnimationCurve RotationAnimationCurve = AnimationCurve.Linear(0, 0, 1, 1);

    [Header("Rainbow")]
    public bool Rainbow = true;
    [Range(-10, 10), Tooltip("Value in Hz (revolutions per second).")]
    public float RainbowSpeed = 0.5f;
    [Range(0, 1)]
    public float RainbowSaturation = 1f;
    public AnimationCurve RainbowAnimationCurve = AnimationCurve.Linear(0, 0, 1, 1);

    [Header("Options")]
    public bool RandomPeriod = true;

    private Image _image;
    private float _period;

    private float t;

    public void Start()
    {
        _image = GetComponent<Image>();
        ResetSpinner();
    }

    public void Update()
    {
        if (Rotation)
        {
            t += Time.deltaTime;
            float newSpeed = NewRotationSpeed.Evaluate(t);
            RotationSpeed = newSpeed;
            transform.localEulerAngles = new Vector3(0, 0, -360 * RotationAnimationCurve.Evaluate((RotationSpeed * t + _period) % 1));
            if (t > 10)
            {
                Rotation = false;
            }
        }

        if (Rainbow)
        {
            _image.color = Color.HSVToRGB(RainbowAnimationCurve.Evaluate((RainbowSpeed * Time.time + _period) % 1), RainbowSaturation, 1);
        }
    }

    public void ResetSpinner()
    {
        _period = RandomPeriod ? Random.Range(0.005f, 0.09f) : 0;
        t = 0;
    }
}