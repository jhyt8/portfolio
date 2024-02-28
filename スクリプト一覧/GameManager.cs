using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//�S����:�v�ۓc
public class GameManager : MonoBehaviour
{

    //�V�[���Ԃł̐ݒ��ʂ̊��x�ݒ�̒l��ۑ�
    public float playerSensitivity;

    //�V�[���Ԃł̐ݒ��ʂ̖��邳�ݒ�̒l��ۑ�
    public float brightnessValue;

    //true�Ń^�C�g���ɖ߂�ۂ̃Q�[���I�[�o�[�̏������s��
    public bool gameOverFlag = false;

    public static GameManager Instance { get; private set; }

    
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

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }

    private void Start()
    {
        // �C�x���g�ɃC�x���g�n���h���[��ǉ�
        SceneManager.sceneLoaded += SceneLoaded;
    }

    void Update()
    {
        EndGame();
    }

    // �C�x���g�n���h���[�i�C�x���g�������ɓ��������������j
    void SceneLoaded(Scene nextScene, LoadSceneMode mode)
    {
        RenderSettings.ambientIntensity = brightnessValue;
    }

    //�^�C�g����ʂƃv���C��ʂ̖��邳�ݒ�������l�𓯂��ɂ��邽�߂ɂ����ŏ������s��
    public void BrightnessChange(float getValue)
    {
        brightnessValue = getValue;     //�����Ă����l��ۑ�
        RenderSettings.ambientIntensity = brightnessValue;  //���݂̃V�[���̖��邳�ɓK�p
        
    }
    //�Q�[���I��
    private void EndGame()
    {
        //����windows�{�^���������ꂽ��
        if (Input.GetKey(KeyCode.Escape))
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
    Application.Quit();//�Q�[���v���C�I��
#endif
        }

    }
}
