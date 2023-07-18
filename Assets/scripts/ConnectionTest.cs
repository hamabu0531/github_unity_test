using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionTest : MonoBehaviour
{

    string url = "https://gahag.net/img/201602/18s/gahag-0057645820-1.jpg";
    //urlに画像urlを格納
    void Start()
    {
        StartCoroutine(Connect());
        //APIは必ずcoroutineで指定する
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Connect()
    {
        var www = new WWW(url);
        //wwwというvar変数(jsでいうletみたいな感じ)にWWWクラス(サイトにgetとpostを行えるclass)を使ってurlをぶち込む
        yield return www;
        //wwwの値が返ってくるまで待つ
        GetComponent<Renderer>().material.mainTexture = www.texture;
    }
}
