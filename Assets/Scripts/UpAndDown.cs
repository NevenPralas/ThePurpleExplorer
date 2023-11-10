using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    [SerializeField] GameObject go;
    int i = 0;
    int j = 0;

    public void Up()
    {
        if (i == 0)
        {
            go.transform.localPosition += new Vector3(0, 0.26f, 0);
            i++;
        }
    }

    public void Down()
    {
        if (j==0)
        {
            go.transform.localPosition -= new Vector3(0, 0.26f, 0);
            j++;
        }
    }
}
