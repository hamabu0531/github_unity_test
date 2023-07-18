using System.Collections;
using LitJson;
using UnityEngine;
using UnityEngine.Networking;

public class JsonTest : MonoBehaviour
{

    public UserData userData = new UserData();
    public string url = "http://192.168.56.1:8000";
    public string jsonName;

    IEnumerator Start()
    {
        userData.name = "Yamada";
        userData.age = 20;
        string jsondata = JsonMapper.ToJson(userData);
        print(jsondata);
        WWWForm form = new WWWForm();
        form.AddField("jsondata", jsondata);

        //����͂����炭POST�ɂȂ��Ă��܂�
        //var www = new WWW(url, form);
        //yield return www;
        //print(www.text);

        UnityWebRequest webRequest = UnityWebRequest.Get(url + "/" + jsonName);
        //URL�ɐڑ����Č��ʂ��߂��Ă���܂őҋ@
        yield return webRequest.SendWebRequest();

        Debug.Log("Get" + " : " + webRequest.downloadHandler.text);
    }
}

