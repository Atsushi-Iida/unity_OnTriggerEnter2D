using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 左に移動
        if (Input.GetKey (KeyCode.LeftArrow)) {
            this.transform.Translate (-0.5f,0.0f,0.0f);
        }
        // 右に移動
        if (Input.GetKey (KeyCode.RightArrow)) {
            this.transform.Translate (0.5f,0.0f,0.0f);
        }
        // 前に移動
        if (Input.GetKey (KeyCode.UpArrow)) {
            this.transform.Translate (0.0f,0.5f,0.0f);
        }
        // 後ろに移動
        if (Input.GetKey (KeyCode.DownArrow)) {
            this.transform.Translate (0.0f,-0.5f,0.0f);
        }
    }
    
    void OnCollisionEnter(Collision collision)
	{
	      Debug.Log(collision.gameObject.name); // ぶつかった相手の名前を取得
	}
	
	//当たった時の処理
    void OnCollisionEnter2D(Collision2D collision)
    {
        //当たったオブジェクトを消す
        Debug.Log(collision.gameObject.name);
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        Destroy(col.gameObject);
    }
    
    //オブジェクトが衝突したとき
	void OnTriggerEnter(Collider col) {
		Debug.Log(col.gameObject.name);
	}
	 
	//オブジェクトが離れた時
	void OnTriggerExit(Collider col) {
		Debug.Log(col.gameObject.name);
	}
	 
	//オブジェクトが触れている間
	void OnTriggerStay(Collider col) {
		Debug.Log(col.gameObject.name);
	}
}
