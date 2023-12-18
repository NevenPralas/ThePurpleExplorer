using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public GameObject objectToHide;
    public void HideObject()
    {
        if (objectToHide != null)
        {
            objectToHide.SetActive(false);
        }
        else
        {
            Debug.LogError("Object doesn't exist");
        }
    }

    void Awake(){
        HideObject();
    }
    
}