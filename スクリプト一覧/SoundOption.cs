using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//�S����:�v�ۓc

public class SoundOption : MonoBehaviour
{
    public bool playAudio = false;

    public void GetSliderDate(float getValue,string sliderName)
    {
        switch (sliderName)
        {
            case "MASTER":
                SetMaster(getValue);
                break;

            case "BGM":
                SetBGM(getValue);
                break;

            case "SE":
                SetSE(getValue);
                break;
        }
    }
    public void SetMaster(float volume)
    {
        AudioManager.Instance.masterVolume = volume / 2;    //�ύX�������ʂ�AudioManager�ɓn��

        if(playAudio)
        AudioManager.Instance.PlaySE(SESoundData.SE.SE00);  //�l�ύX��m�F�p��SE���Đ�(�ύX�\��)

    }

    public void SetBGM(float volume)
    {
        AudioManager.Instance.bgmMasterVolume = volume / 2;
    }

    public void SetSE(float volume)
    {
        AudioManager.Instance.seMasterVolume = volume / 2;
    }
}
