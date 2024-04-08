   using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenReadMeFile : MonoBehaviour
{
    public void OpenReadMe()
    {
        Debug.Log(Application.dataPath);
        //Application.OpenURL(Application.dataPath);
    }
}
