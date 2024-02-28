using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//担当者:久保田
public class ButtonControl : MonoBehaviour
{
    //ボタンクリック時にボタンの名前を渡すのに使用
    [SerializeField]private ButtonManager buttonManager;
    public void ClickButton()
    {
        //実行時につけているオブジェクト自身の名前を自動で渡されるので実引数は変更不要
        buttonManager.DisButton(name);   
    }
}
