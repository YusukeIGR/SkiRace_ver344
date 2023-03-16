using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseToReset : MonoBehaviour
{
    /*
    void Start () {
        // イベントにイベントハンドラーを追加
        SceneManager.sceneLoaded += SceneLoaded;
        // シーンの読み込み
        SceneManager.LoadScene("IGRGameScene");
    }

    // イベントハンドラー（イベント発生時に動かしたい処理）
    void SceneLoaded (Scene nextScene, LoadSceneMode mode) {
       Time.timeScale = 1f;
    }
    */
    public void OnClickStartButton(){
        SceneManager.LoadScene("IGRGameScene");
        Time.timeScale = 1f;
    }
    
}
