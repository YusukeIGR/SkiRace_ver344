using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGRPauseMenu : MonoBehaviour
{
    //　ポーズした時に表示するUIのプレハブ
    [SerializeField] private GameObject pauseUI;
    //[SerializeField] private GameObject reset;

    //[SerializeField] private GameObject exit;
    
	//　ポーズUIのインスタンス
    void Start(){
    } 
    
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
            pauseUI.SetActive (!pauseUI.activeSelf);
            //reset.SetActive (!reset.activeSelf);

            
            //　ポーズUIが表示されてる時は停止
			if(pauseUI.activeSelf) {
				Time.timeScale = 0f;
			//　ポーズUIが表示されてなければ通常通り進行
			} else {
				Time.timeScale = 1f;
			}
        }
    }   
}
	


