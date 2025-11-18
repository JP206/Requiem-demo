using System.Collections;
using UnityEngine;

public class ModeCamera : Mode
{
    [SerializeField] Color calmColor, blindColor;

    protected override void Start()
    {
        base.Start();
    }

    public override void Toggle()
    {
        if (calmModeOn)
        {
            StartCoroutine(LerpCameraColor(calmColor, blindColor));
        }
        else
        {
            StartCoroutine(LerpCameraColor(blindColor, calmColor));
        }

        calmModeOn = !calmModeOn;
    }

    IEnumerator LerpCameraColor(Color startColor, Color endColor)
    {
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime;
            Camera.main.backgroundColor = Color.Lerp(startColor, endColor, t);
            yield return null;
        }

        Camera.main.backgroundColor = endColor;
    }
}
