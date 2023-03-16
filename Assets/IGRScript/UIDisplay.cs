using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIDisplay : MonoBehaviour
{
    [SerializeField]GameObject clearUI;
    // UI Text指定用
    public Text TextAcNum;
    //リング取得数の変数
    private int acNum=0;
    //リング取得数get関数
    public int getAcNum(){
        return acNum;
    }
    private Rigidbody rb;// = gameObject.GetComponent<Rigidbody>();
 
    //private int TextRingCount = AddForce2.acNum;
    // Start is called before the first frame update
    void Start()
    {
        //rb.velocity = Vector3.zero;
        //Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //Time.timeScale = 1f;
        //Debug.Log(acNum);
        TextAcNum.text=string.Format("{0}",acNum);
        

    }
    void OnTriggerEnter(Collider collision){
        if(collision.gameObject.CompareTag("Ring")){
            acNum++;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.CompareTag("Goal")){
            Time.timeScale = 0f;
            clearUI.SetActive(true);
        }
    }

    
}
