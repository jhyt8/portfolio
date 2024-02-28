using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    //InputField���i�[���邽�߂̕ϐ�
    [SerializeField] TMP_InputField inputField;

    [SerializeField] PlayProgressManager progressManager;
    public void GetInputName()
    {
        //InputField����e�L�X�g�����擾����
        string inputPs = inputField.text;

        progressManager.InputConfirmPassword(inputPs);
        ////���̓t�H�[���̃e�L�X�g����ɂ���
        //inputField.text = "";
    }
}
