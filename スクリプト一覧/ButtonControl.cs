using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�S����:�v�ۓc
public class ButtonControl : MonoBehaviour
{
    //�{�^���N���b�N���Ƀ{�^���̖��O��n���̂Ɏg�p
    [SerializeField]private ButtonManager buttonManager;
    public void ClickButton()
    {
        //���s���ɂ��Ă���I�u�W�F�N�g���g�̖��O�������œn�����̂Ŏ������͕ύX�s�v
        buttonManager.DisButton(name);   
    }
}
