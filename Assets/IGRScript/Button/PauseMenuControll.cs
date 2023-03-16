using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuControll : MonoBehaviour
{
    [SerializeField] private GameObject reset;
    [SerializeField] private GameObject exit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Escape)) {
            reset.SetActive (!reset.activeSelf);
            exit.SetActive (!exit.activeSelf);
        }
        
    }
}
