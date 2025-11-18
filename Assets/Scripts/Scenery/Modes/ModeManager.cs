using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour
{
    List<Mode> modeObjects = new();

    public void Toggle()
    {
        foreach (Mode mo in modeObjects)
        {
            mo.Toggle();
        }
    }

    public void Subscribe(Mode modeObject)
    {
        modeObjects.Add(modeObject);
    }
}
