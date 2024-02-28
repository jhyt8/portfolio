using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//担当者:久保田
public class SlideDoor : MonoBehaviour
{
    public enum DoorType
    {
        Open,
        Lock,
        NotOpen
    }

    public DoorType type;

    public bool doorOpen = false;  //ドアの開閉を確認

    Animator animator;

    /// <summary>
    /// ドア開閉の関数
    /// </summary>
    public void OpeningAndClosing()
    {

        animator = GetComponent<Animator>();
        //ドアが閉まっている
        if (!doorOpen)
        {
            doorOpen = !doorOpen;
            animator.SetTrigger("DoorTrigger1");
        }
        //ドアが開いている
        else if (doorOpen)
        {
            doorOpen = !doorOpen;
            animator.SetTrigger("DoorTrigger2");
        }
        
    }


}
