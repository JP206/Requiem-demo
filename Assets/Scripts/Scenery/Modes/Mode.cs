using System.Collections;
using UnityEngine;

public abstract class Mode : MonoBehaviour
{
    protected bool calmModeOn = true;

    public abstract void Toggle();

    protected virtual void Start()
    {
        FindAnyObjectByType<ModeManager>().Subscribe(this);
    }

    protected IEnumerator LerpColor(Color startColor, Color endColor, SpriteRenderer spriteRenderer)
    {
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime;
            spriteRenderer.color = Color.Lerp(startColor, endColor, t);
            yield return null;
        }

        spriteRenderer.color = endColor;
    }
}
