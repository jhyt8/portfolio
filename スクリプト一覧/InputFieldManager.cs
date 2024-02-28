using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    //InputFieldを格納するための変数
    [SerializeField] TMP_InputField inputField;

    [SerializeField] PlayProgressManager progressManager;
    public void GetInputName()
    {
        //InputFieldからテキスト情報を取得する
        string inputPs = inputField.text;

        progressManager.InputConfirmPassword(inputPs);
        ////入力フォームのテキストを空にする
        //inputField.text = "";
    }
}
