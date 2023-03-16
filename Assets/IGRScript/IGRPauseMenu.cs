using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGRPauseMenu : MonoBehaviour
{
    //　ポーズした時に表示するUIのプレハブ
    public GameObject pauseUIPrefab;
	//　ポーズUIのインスタンス
	private GameObject pauseUIInstance;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
            if (pauseUIInstance == null) {
				pauseUIInstance = GameObject.Instantiate (pauseUIPrefab) as GameObject;
			    Time.timeScale = 0f;
            }else{
                Destroy (pauseUIInstance);
				Time.timeScale = 1f;
            }
        }
	}
}
