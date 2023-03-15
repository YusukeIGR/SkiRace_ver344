using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class topButtonController : MonoBehaviour
{
    public void OnClickStartButton(){
        SceneManager.LoadScene("topScene");
    }
}
