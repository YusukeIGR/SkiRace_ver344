using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerfectText : MonoBehaviour
{
    [SerializeField]GameObject perfectText;
    
    private GameObject IGRplayer;
    UIDisplay uiDisplay; 
    private int count;
    void FixedUpdate(){
    IGRplayer = GameObject.Find("IGRPlayer");
    uiDisplay=IGRplayer.GetComponent<UIDisplay>();
    count = uiDisplay.getAcNum();
    Debug.Log("動いてんのか？");
    }
   

    
    
   
}
