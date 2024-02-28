using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSlider : MonoBehaviour
{

    [SerializeField]SoundOption soundOption;
    public void SetSliderValue(float value)
    {
        soundOption.GetSliderDate(value, name);
    }
}
