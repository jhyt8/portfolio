using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//担当者:久保田

public class SensitivitySetting : MonoBehaviour
{
    //変更した感度の値を反映するのに使用
    [SerializeField] PlayerDefault playerDefault = null;

    //感度設定バーの変更値を取得
    public void SetSliderValue(float Value)
    {
        switch (Value)
        {
            case 0:
                //シーン間でも共有するためGameManagerに値を保存
                GameManager.Instance.playerSensitivity = 2;

                //プレイヤーデフォルトに入っているsensitivityを直接変更
                if (playerDefault != null) 
                    playerDefault.sensitivity = 2;

                break;

            case 1:
                GameManager.Instance.playerSensitivity = 4;

                if (playerDefault != null)
                    playerDefault.sensitivity = 4;

                break;

            case 2:
                GameManager.Instance.playerSensitivity = 6;

                if (playerDefault != null)
                    playerDefault.sensitivity = 6;

                break;

            case 3:
                GameManager.Instance.playerSensitivity = 8;

                if (playerDefault != null)
                    playerDefault.sensitivity = 8;

                break;

        }

    }
}
