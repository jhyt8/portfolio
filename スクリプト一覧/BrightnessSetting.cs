using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//担当者:久保田

public class BrightnessSetting : MonoBehaviour
{
    //明るさ調整バーの変更値を取得
    public void SetBrightness(float Value)
    {
        switch (Value)  //各段階によって処理を分ける
        {
            case 0:
                GameManager.Instance.BrightnessChange(0);    //変更した値をGameManagerに渡す
                break;

            case 1:
                GameManager.Instance.BrightnessChange(0.1f);
                break;

            case 2:
                GameManager.Instance.BrightnessChange(0.15f);
                break;

            case 3:
                GameManager.Instance.BrightnessChange(0.2f);
                break;

        }

    }
}
