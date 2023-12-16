using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notepositions : MonoBehaviour
{
   
    public static Vector3 newball1;  
    public static Vector3 newball2; 
    public static Vector3 newball3; 
    public static Vector3 newbat; 
    public static Vector3 newkatana;

    public static Quaternion newball1R;  
    public static Quaternion newball2R; 
    public static Quaternion newball3R; 
    public static Quaternion newbatR; 
    public static Quaternion newkatanaR;

    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject bat;
    public GameObject katana;
    public GameObject kill;

    private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
        {
        newball1 = ball1.transform.position;
        newball2=ball2.transform.position;
        newball3=ball3.transform.position;
        newbat=bat.transform.position;
        newkatana=katana.transform.position;

        newball1R = ball1.transform.rotation;
        newball2R=ball2.transform.rotation;
        newball3R=ball3.transform.rotation;
        newbatR=bat.transform.rotation;
        newkatanaR=katana.transform.rotation;   
    }
}


private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(kill);
        }
    }

}
