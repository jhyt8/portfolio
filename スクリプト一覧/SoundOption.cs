using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//担当者:久保田

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
        AudioManager.Instance.masterVolume = volume / 2;    //変更した音量をAudioManagerに渡す

        if(playAudio)
        AudioManager.Instance.PlaySE(SESoundData.SE.SE00);  //値変更後確認用のSEを再生(変更予定)

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
