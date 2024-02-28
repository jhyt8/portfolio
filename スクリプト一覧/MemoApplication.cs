using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

//�S����:�v�ۓc
public class MemoApplication : MonoBehaviour
{
    /// <summary>
    /// ���݉���ς݂̃t���O�z��
    /// </summary>
    public bool[] memoFlag;

    //�q���g���L�ڂ���̂Ɏg�p
    [SerializeField] TextMeshProUGUI memoText;
    // Start is called before the first frame update

    //���̃X�N���v�g�����Ă���I�u�W�F�N�g���A�N�e�B�u�ɂȂ�Ǝ��s
    private void OnEnable() 
    {
        //�����̋L�ڂ����Z�b�g
        memoText.text = "";
        InputText();
    }
    /// <summary>
    /// �����Ƀq���g���L�ڂ���֐�
    /// </summary>
    void InputText()
    {
        if (memoFlag[0]) 
        {
            memoText.text = "���[��22�̔����J���悤�ɂȂ����݂������A�s���Ă݂悤...\n";
        }

        if (memoFlag[1])
        {
            memoText.text += "�t���O<color=#191970>�u�Q�v</color>���\n";
        }

        if (memoFlag[1]) 
        {
            memoText.text += "�t���O<color=#ffff00>�u�R�v</color>���\n";
        }

        if (memoFlag[1])
        {
            memoText.text += "�t���O<color=#9400d3>�u�S�v</color>���\n";
        }
    }
}
