using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseToTitle : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickStartButton(){
        SceneManager.LoadScene("IGRTitle");
        Time.timeScale = 1f;
    }
}
