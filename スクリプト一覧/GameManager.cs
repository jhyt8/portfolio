using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//担当者:久保田
public class GameManager : MonoBehaviour
{

    //シーン間での設定画面の感度設定の値を保存
    public float playerSensitivity;

    //シーン間での設定画面の明るさ設定の値を保存
    public float brightnessValue;

    //trueでタイトルに戻る際のゲームオーバーの処理を行う
    public bool gameOverFlag = false;

    public static GameManager Instance { get; private set; }

    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }

    private void Start()
    {
        // イベントにイベントハンドラーを追加
        SceneManager.sceneLoaded += SceneLoaded;
    }

    void Update()
    {
        EndGame();
    }

    // イベントハンドラー（イベント発生時に動かしたい処理）
    void SceneLoaded(Scene nextScene, LoadSceneMode mode)
    {
        RenderSettings.ambientIntensity = brightnessValue;
    }

    //タイトル画面とプレイ画面の明るさ設定をした値を同じにするためにここで処理を行う
    public void BrightnessChange(float getValue)
    {
        brightnessValue = getValue;     //持ってきた値を保存
        RenderSettings.ambientIntensity = brightnessValue;  //現在のシーンの明るさに適用
        
    }
    //ゲーム終了
    private void EndGame()
    {
        //左のwindowsボタンが押された時
        if (Input.GetKey(KeyCode.Escape))
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
    Application.Quit();//ゲームプレイ終了
#endif
        }

    }
}
