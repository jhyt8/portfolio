using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�S����:�v�ۓc

public class BrightnessSetting : MonoBehaviour
{
    //���邳�����o�[�̕ύX�l���擾
    public void SetBrightness(float Value)
    {
        switch (Value)  //�e�i�K�ɂ���ď����𕪂���
        {
            case 0:
                GameManager.Instance.BrightnessChange(0);    //�ύX�����l��GameManager�ɓn��
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
