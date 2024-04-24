using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LevelLoader : MonoBehaviour
{

    void Start()
    {
        SampleObject ob = new SampleObject("Rafael", 10, 500f);
        PlayerPrefs.SetString("PROGRESS", JsonUtility.ToJson(ob));
        SampleObject loadedObject = JsonUtility.FromJson<SampleObject>(PlayerPrefs.GetString("PROGRESS"));
        Debug.Log(loadedObject.name);
        Debug.Log(loadedObject.number);
        Debug.Log(loadedObject.otherNumber);
    }

    // Update is called once per frame
    void Update()
    {

    }
}


