using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

//�S����:�v�ۓc
public class TimeLineController : MonoBehaviour
{
    /// <summary>
    /// TimeLine���w��ӏ��܂ōĐ����ꂽ����s�����֐�
    /// </summary>
    public void GoNextScene()
    {
        //�Q�[���I�[�o�[��`����
        GameManager.Instance.gameOverFlag = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Title");
    }
}
