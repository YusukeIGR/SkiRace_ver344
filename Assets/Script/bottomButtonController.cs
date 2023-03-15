using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bottomButtonController : MonoBehaviour
{
    public void OnStartButtonClicked(){
        SceneManager.LoadScene("buttomScene");
    }
}

