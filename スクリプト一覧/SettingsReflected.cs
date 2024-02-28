using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

//�S����:�v�ۓc

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
        //�ۑ����Ă��銴�x�̒l��setSensitivity�ɕۊ�
        setSensitivity = GameManager.Instance.playerSensitivity;

        //�ݒ��ʂ̃X���C�_�[��ݒ肵���l�ɍ��킹��
        switch (setSensitivity)
        {
            case 2:
                sensitivitySlider.value = 0;    //�ݒ��ʂ̃X���C�_�[��Value��ύX
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

        //�ۑ����Ă��閾�邳�̒l��setBrightness�ɕۊ�
        setBrightness = GameManager.Instance.brightnessValue;

        //�ݒ��ʂ̃X���C�_�[��ݒ肵���l�ɍ��킹��
        switch (setBrightness) 
        {
            case 0:
                brightnessSlider.value = 0; //�ݒ��ʂ̃X���C�_�[��Value��ύX

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

        //���ꂼ��̉��ʂ̒l��setAudio�ɕۊ�
        setAudio[0] = AudioManager.Instance.masterVolume;
        setAudio[1] = AudioManager.Instance.bgmMasterVolume;
        setAudio[2] = AudioManager.Instance.seMasterVolume;

        //setAudio�̗v�f�����J��Ԃ�
        for (int i = 0; i < setAudio.Length; i++)
        {
            //�X���C�_Value�ł̉��ʐݒ�̍ۂɁ�2���Ă���̂Ł~2�ɂ��Ēl�����킹��
            VolumeSlider[i].value = setAudio[i] * 2;    
        }
        soundOption.playAudio = true;
    }

}
