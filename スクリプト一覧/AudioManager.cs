using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//担当者:久保田
public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public AudioSource seAudioSource;

    [SerializeField] List<BGMSoundData> bgmSoundDatas;
    [SerializeField] List<SESoundData> seSoundDatas;

    public float masterVolume = 1;
    public float bgmMasterVolume = 1;
    public float seMasterVolume = 1;

    public static AudioManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    /// <summary>
    /// 実引数に使いたいBGMの名前を加える(例)BGMSoundData.BGM.○○
    /// </summary>
    /// <param name="bgm"></param>
    //BGMを再生する
    public void PlayBGM(BGMSoundData.BGM bgm)
    {
        BGMSoundData data = bgmSoundDatas.Find(data => data.bgm == bgm);
        bgmAudioSource.clip = data.audioClip;
        bgmAudioSource.volume = data.volume * bgmMasterVolume * masterVolume;
        bgmAudioSource.Play();
    }

    //BGMを停止する
    public void StopBGM()
    {
        bgmAudioSource.Stop();
    }
    /// <summary>
    /// 実引数に使いたいSEの名前を加える(例)SESoundData.SE.○○
    /// </summary>
    //SEを再生する
    public void PlaySE(SESoundData.SE se)
    {
        SESoundData data = seSoundDatas.Find(data => data.se == se);
        seAudioSource.volume = data.volume * seMasterVolume * masterVolume;
        seAudioSource.PlayOneShot(data.audioClip);
    }
}


[System.Serializable]
public class BGMSoundData
{
    public enum BGM
    {
        //ここがBGMのラベルになる
        //今は仮名
        BGM00,
        BGM01,
        BGM02,
    }

    public BGM bgm;
    public AudioClip audioClip;
    [Range(0, 1)]
    public float volume = 1;
}

[System.Serializable]
public class SESoundData
{
    public enum SE
    {
        //ここがSEのラベルになる
        //今は仮名
        SE00,
        SE01,
        SE02,

    }

    public SE se;
    public AudioClip audioClip;
    [Range(0, 1)]
    public float volume = 1;
}
