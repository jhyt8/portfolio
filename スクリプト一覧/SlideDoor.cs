using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�S����:�v�ۓc
public class SlideDoor : MonoBehaviour
{
    public enum DoorType
    {
        Open,
        Lock,
        NotOpen
    }

    public DoorType type;

    public bool doorOpen = false;  //�h�A�̊J���m�F

    Animator animator;

    /// <summary>
    /// �h�A�J�̊֐�
    /// </summary>
    public void OpeningAndClosing()
    {

        animator = GetComponent<Animator>();
        //�h�A���܂��Ă���
        if (!doorOpen)
        {
            doorOpen = !doorOpen;
            animator.SetTrigger("DoorTrigger1");
        }
        //�h�A���J���Ă���
        else if (doorOpen)
        {
            doorOpen = !doorOpen;
            animator.SetTrigger("DoorTrigger2");
        }
        
    }


}
