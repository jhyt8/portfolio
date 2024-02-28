using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�S����:�v�ۓc

public class SensitivitySetting : MonoBehaviour
{
    //�ύX�������x�̒l�𔽉f����̂Ɏg�p
    [SerializeField] PlayerDefault playerDefault = null;

    //���x�ݒ�o�[�̕ύX�l���擾
    public void SetSliderValue(float Value)
    {
        switch (Value)
        {
            case 0:
                //�V�[���Ԃł����L���邽��GameManager�ɒl��ۑ�
                GameManager.Instance.playerSensitivity = 2;

                //�v���C���[�f�t�H���g�ɓ����Ă���sensitivity�𒼐ڕύX
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
