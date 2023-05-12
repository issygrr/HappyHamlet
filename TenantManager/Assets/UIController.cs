using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] Slider slider;

    public void SetStatus(float f)
    {
        f = Mathf.Clamp(f, 0f, 100f);
        slider.value = f;
    }
}
