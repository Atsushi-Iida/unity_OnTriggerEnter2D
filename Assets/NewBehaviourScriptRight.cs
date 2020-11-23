using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScriptRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision)
	{
	      Debug.Log(collision.gameObject.name); // ぶつかった相手の名前を取得
	}
	
	//当たった時の処理
    void OnCollisionEnter2D(Collision2D collision)
    {
        //当たったオブジェクトを消す
        Debug.Log(collision.gameObject.name); // ぶつかった相手の名前を取得
    }
}
