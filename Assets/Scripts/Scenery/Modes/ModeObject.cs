using UnityEngine;
using System.Collections;

public class ModeObject : Mode
{
    [SerializeField] Color calmColor, blindColor;

    SpriteRenderer spriteRenderer;

    protected override void Start()
    {
        base.Start();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public override void Toggle()
    {
        if (calmModeOn)
        {
            StartCoroutine(LerpColor(calmColor, blindColor, spriteRenderer));
        }
        else
        {
            StartCoroutine(LerpColor(blindColor, calmColor, spriteRenderer));
        }

        calmModeOn = !calmModeOn;
    }
}
