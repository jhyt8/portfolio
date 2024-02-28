using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

//担当者:久保田
public class MemoApplication : MonoBehaviour
{
    /// <summary>
    /// 現在回収済みのフラグ配列
    /// </summary>
    public bool[] memoFlag;

    //ヒントを記載するのに使用
    [SerializeField] TextMeshProUGUI memoText;
    // Start is called before the first frame update

    //このスクリプトがついているオブジェクトがアクティブになると実行
    private void OnEnable() 
    {
        //メモの記載をリセット
        memoText.text = "";
        InputText();
    }
    /// <summary>
    /// メモにヒントを記載する関数
    /// </summary>
    void InputText()
    {
        if (memoFlag[0]) 
        {
            memoText.text = "ルーム22の扉が開くようになったみたいだ、行ってみよう...\n";
        }

        if (memoFlag[1])
        {
            memoText.text += "フラグ<color=#191970>「２」</color>回収\n";
        }

        if (memoFlag[1]) 
        {
            memoText.text += "フラグ<color=#ffff00>「３」</color>回収\n";
        }

        if (memoFlag[1])
        {
            memoText.text += "フラグ<color=#9400d3>「４」</color>回収\n";
        }
    }
}
