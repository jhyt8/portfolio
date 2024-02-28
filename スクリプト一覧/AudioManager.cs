using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//�S����:�v�ۓc
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
    /// �������Ɏg������BGM�̖��O��������(��)BGMSoundData.BGM.����
    /// </summary>
    /// <param name="bgm"></param>
    //BGM���Đ�����
    public void PlayBGM(BGMSoundData.BGM bgm)
    {
        BGMSoundData data = bgmSoundDatas.Find(data => data.bgm == bgm);
        bgmAudioSource.clip = data.audioClip;
        bgmAudioSource.volume = data.volume * bgmMasterVolume * masterVolume;
        bgmAudioSource.Play();
    }

    //BGM���~����
    public void StopBGM()
    {
        bgmAudioSource.Stop();
    }
    /// <summary>
    /// �������Ɏg������SE�̖��O��������(��)SESoundData.SE.����
    /// </summary>
    //SE���Đ�����
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
        //������BGM�̃��x���ɂȂ�
        //���͉���
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
        //������SE�̃��x���ɂȂ�
        //���͉���
        SE00,
        SE01,
        SE02,

    }

    public SE se;
    public AudioClip audioClip;
    [Range(0, 1)]
    public float volume = 1;
}
