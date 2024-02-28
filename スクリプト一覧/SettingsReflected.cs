using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

//担当者:久保田

public class SettingsReflected : MonoBehaviour
{
    [SerializeField]Slider brightnessSlider;

    [SerializeField]Slider sensitivitySlider;

    [SerializeField]Slider[] VolumeSlider;

    float setSensitivity;

    float setBrightness;

    float[] setAudio = new float[3];

    [SerializeField]SoundOption soundOption;

    void OnEnable()
    {
        //保存している感度の値をsetSensitivityに保管
        setSensitivity = GameManager.Instance.playerSensitivity;

        //設定画面のスライダーを設定した値に合わせる
        switch (setSensitivity)
        {
            case 2:
                sensitivitySlider.value = 0;    //設定画面のスライダーのValueを変更
                break;

            case 4:
                sensitivitySlider.value = 1;
                break;

            case 6:
                sensitivitySlider.value = 2;
                break;

            case 8:
                sensitivitySlider.value = 3;
                break;
        }

        //保存している明るさの値をsetBrightnessに保管
        setBrightness = GameManager.Instance.brightnessValue;

        //設定画面のスライダーを設定した値に合わせる
        switch (setBrightness) 
        {
            case 0:
                brightnessSlider.value = 0; //設定画面のスライダーのValueを変更

                break;

            case 0.1f:
                brightnessSlider.value = 1;

                break;

            case 0.15f:
                brightnessSlider.value = 2;

                break;

            case 0.2f:
                brightnessSlider.value = 3;

                break;
        }

        //それぞれの音量の値をsetAudioに保管
        setAudio[0] = AudioManager.Instance.masterVolume;
        setAudio[1] = AudioManager.Instance.bgmMasterVolume;
        setAudio[2] = AudioManager.Instance.seMasterVolume;

        //setAudioの要素数分繰り返す
        for (int i = 0; i < setAudio.Length; i++)
        {
            //スライダValueでの音量設定の際に÷2しているので×2にして値を合わせる
            VolumeSlider[i].value = setAudio[i] * 2;    
        }
        soundOption.playAudio = true;
    }

}
