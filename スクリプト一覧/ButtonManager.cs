using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//�S����:�v�ۓc
public class ButtonManager : MonoBehaviour
{
    //�{�^���̏������܂Ƃ߂ĊǗ�����̂Ń{�^���̐��ɉ�����date����ǉ�����
    [SerializeField] List<ButtonDate> buttonDates;

    //�Q�[���I�[�o�[�̍ۂɕ\������UI
    //(���̏��^�C�g���݂̂Ŏg�p���Ă���X�N���v�g���Ȃ��̂ŉ��u��)
    [SerializeField] private GameObject gameOverUI = null;


    private void Start()
    {
        //�^�C�g����ʂɖ߂��Ă����ۂɃQ�[���I�[�o�[UI��\�������邩
        if(gameOverUI != null && GameManager.Instance.gameOverFlag) 
        {
            gameOverUI.SetActive(!gameOverUI.activeSelf);
        }
    }

    /// <summary>
    /// �{�^���̎�ޕʂɕ�����֐�(���s���͎������Ƀ{�^���̖��O��������)
    /// </summary>
    /// <param name="getButtonName"></param>

    public void DisButton(string getButtonName)
    {
        switch (getButtonName)  //�{�^���̖��O�ʂɏ����𕪊�
        {
            //�A�v����ʂւ̈ړ��Ŏg�p����I�u�W�F�N�g�������Ȃ̂�in��out���܂Ƃ߂�
            case "Setting":
                ChangeScreen(ButtonDate.Type.SettingsInOut);
                break;

            case "Map":
                ChangeScreen(ButtonDate.Type.MapInOut);
                break;

            case "Memo":
                ChangeScreen(ButtonDate.Type.MemoInOut);
                break;

            case "Item":
                ChangeScreen(ButtonDate.Type.ItemInOut);
                break;

            //���g���C��^�C�g������X�^�[�g�ۂɎg�p
            case "GameStart":
                //���������ꂾ���Ȃ̂Ŋ֐��𖢎g�p(���̏����������̍ۂ͊֐����쐬)
                SceneManager.LoadScene("sampleScene");  
                break;

            //�^�C�g���ƃQ�[���I�[�o�[�̃V�[�����ꏏ�Ȃ̂ŃV�[���J�ږ���
            case "GoTitle":
                ChangeScreen(ButtonDate.Type.GoTitle);
                break;

            case "BackPcScreen":
                ChangeScreen(ButtonDate.Type.BackPcScreen);
                break;

        }
    }


    /// <summary>
    /// �I�u�W�F�N�g�̕\����\�����s���֐�
    /// </summary>
    /// <param name="type"></param>
    void ChangeScreen(ButtonDate.Type type)
    {
        ButtonDate data = buttonDates.Find(data => data.type == type);

        if (data.Obj1 != null)  //���g�������Ă���̂����m�F�A�Ȃ��ꍇ�̓X�L�b�v
            data.Obj1.SetActive(!data.Obj1.activeSelf);

        if (data.Obj2 != null)
            data.Obj2.SetActive(!data.Obj2.activeSelf);
    }


}

//�ǉ�����{�^���̃f�[�^
[System.Serializable]
public class ButtonDate
{
    public enum Type  //�{�^�����Ƃ̃^�C�v 
    {
        SettingsInOut,
        MapInOut,
        MemoInOut,
        ItemInOut,
        GameStart,
        GoTitle,
        BackPcScreen
    }

    public Type type;
    public GameObject Obj1;
    public GameObject Obj2;



}
