using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionTest : MonoBehaviour
{

    string url = "https://gahag.net/img/201602/18s/gahag-0057645820-1.jpg";
    //url�ɉ摜url���i�[
    void Start()
    {
        StartCoroutine(Connect());
        //API�͕K��coroutine�Ŏw�肷��
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Connect()
    {
        var www = new WWW(url);
        //www�Ƃ���var�ϐ�(js�ł���let�݂����Ȋ���)��WWW�N���X(�T�C�g��get��post���s����class)���g����url���Ԃ�����
        yield return www;
        //www�̒l���Ԃ��Ă���܂ő҂�
        GetComponent<Renderer>().material.mainTexture = www.texture;
    }
}
