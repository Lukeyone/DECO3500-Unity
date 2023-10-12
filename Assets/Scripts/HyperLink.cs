using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperLink : MonoBehaviour
{
    public string URL;
    public void OpenURL()
    {
        Debug.Log("opening url " + URL);
        Application.OpenURL(URL);
    }
}
