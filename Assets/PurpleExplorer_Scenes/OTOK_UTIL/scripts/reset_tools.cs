using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset_tools : MonoBehaviour
{
    public Vector3 newball1 = new Vector3(547.341f, 48.792f, 355.171f);  
    public Vector3 newball2 = new Vector3(547.2983f, 48.792f, 355.073f);
    public Vector3 newball3 = new Vector3(547.2305f, 48.792f, 355.171f);
    public Vector3 newbat = new Vector3(547.3948f, 48.77557f, 354.7365f);
    public Vector3 newkatana = new Vector3(547.355f, 48.794f, 354.5806f);


    void Start()
    {
        SetPositionsForNamedObjects();
    }

    void SetPositionsForNamedObjects()
    {
        
        
            GameObject ball1 = GameObject.Find("Ball_m");
            GameObject ball2 = GameObject.Find("Ball (1)_m");
            GameObject ball3 = GameObject.Find("Ball (2)_m");
            GameObject bat = GameObject.Find("Bat 2H_m");
            GameObject katana = GameObject.Find("Katana_m");

            if (ball1 != null && ball2 != null && ball3 !=null && bat!=null && katana!=null )
            {
                
                ball1.transform.position = newball1;
                ball2.transform.position = newball2;
                ball3.transform.position = newball3;
                bat.transform.position = newbat;
                katana.transform.position = newkatana;
            }
            
        
    }
}
