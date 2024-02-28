using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//担当者:久保田
public class ButtonManager : MonoBehaviour
{
    //ボタンの処理をまとめて管理するのでボタンの数に応じてdate数を追加する
    [SerializeField] List<ButtonDate> buttonDates;

    //ゲームオーバーの際に表示するUI
    //(今の所タイトルのみで使用しているスクリプトがないので仮置き)
    [SerializeField] private GameObject gameOverUI = null;


    private void Start()
    {
        //タイトル画面に戻ってきた際にゲームオーバーUIを表示させるか
        if(gameOverUI != null && GameManager.Instance.gameOverFlag) 
        {
            gameOverUI.SetActive(!gameOverUI.activeSelf);
        }
    }

    /// <summary>
    /// ボタンの種類別に分ける関数(実行時は実引数にボタンの名前を加える)
    /// </summary>
    /// <param name="getButtonName"></param>

    public void DisButton(string getButtonName)
    {
        switch (getButtonName)  //ボタンの名前別に処理を分岐
        {
            //アプリ画面への移動で使用するオブジェクトが同じなのでinとoutをまとめる
            case "Setting":
                ChangeScreen(ButtonDate.Type.SettingsInOut);
                break;

            case "Map":
                ChangeScreen(ButtonDate.Type.MapInOut);
                break;

            case "Memo":
                ChangeScreen(ButtonDate.Type.MemoInOut);
                break;

            case "Item":
                ChangeScreen(ButtonDate.Type.ItemInOut);
                break;

            //リトライやタイトルからスタート際に使用
            case "GameStart":
                //処理がこれだけなので関数を未使用(他の処理を実装の際は関数を作成)
                SceneManager.LoadScene("sampleScene");  
                break;

            //タイトルとゲームオーバーのシーンが一緒なのでシーン遷移無し
            case "GoTitle":
                ChangeScreen(ButtonDate.Type.GoTitle);
                break;

            case "BackPcScreen":
                ChangeScreen(ButtonDate.Type.BackPcScreen);
                break;

        }
    }


    /// <summary>
    /// オブジェクトの表示非表示を行う関数
    /// </summary>
    /// <param name="type"></param>
    void ChangeScreen(ButtonDate.Type type)
    {
        ButtonDate data = buttonDates.Find(data => data.type == type);

        if (data.Obj1 != null)  //中身が入っているのかを確認、ない場合はスキップ
            data.Obj1.SetActive(!data.Obj1.activeSelf);

        if (data.Obj2 != null)
            data.Obj2.SetActive(!data.Obj2.activeSelf);
    }


}

//追加するボタンのデータ
[System.Serializable]
public class ButtonDate
{
    public enum Type  //ボタンごとのタイプ 
    {
        SettingsInOut,
        MapInOut,
        MemoInOut,
        ItemInOut,
        GameStart,
        GoTitle,
        BackPcScreen
    }

    public Type type;
    public GameObject Obj1;
    public GameObject Obj2;



}
