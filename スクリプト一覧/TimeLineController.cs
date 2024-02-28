using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

//担当者:久保田
public class TimeLineController : MonoBehaviour
{
    /// <summary>
    /// TimeLineが指定箇所まで再生されたら実行される関数
    /// </summary>
    public void GoNextScene()
    {
        //ゲームオーバーを伝える
        GameManager.Instance.gameOverFlag = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Title");
    }
}
