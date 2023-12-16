using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class reset_tools : MonoBehaviour
{
    
  

    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject bat;
    public GameObject katana;
    
   

   public void SetPositionsForNamedObjects()
   
    {
        
            if (ball1 != null && ball2 != null && ball3 !=null && bat!=null && katana!=null )
            {
               
                ball1.transform.position = notepositions.newball1;
                ball2.transform.position = notepositions.newball2;
                ball3.transform.position = notepositions.newball3;
                bat.transform.position = notepositions.newbat;
                katana.transform.position = notepositions.newkatana;

                ball1.transform.rotation= notepositions.newball1R;
                ball2.transform.rotation= notepositions.newball2R;
                ball3.transform.rotation= notepositions.newball3R;
                bat.transform.rotation= notepositions.newbatR;
                katana.transform.rotation= notepositions.newkatanaR;
        
                Rigidbody rb1 = ball1.GetComponent<Rigidbody>();
                Rigidbody rb2 = ball2.GetComponent<Rigidbody>();
                Rigidbody rb3 = ball3.GetComponent<Rigidbody>();
                Rigidbody rb4 = bat.GetComponent<Rigidbody>();
                Rigidbody rb5 = katana.GetComponent<Rigidbody>();

                if(rb1 && rb2 && rb3 && rb4 && rb5){
                rb1.velocity = Vector3.zero;
                rb1.angularVelocity = Vector3.zero;
                rb2.velocity = Vector3.zero;
                rb2.angularVelocity = Vector3.zero;
                rb3.velocity = Vector3.zero;
                rb3.angularVelocity = Vector3.zero;
                rb4.velocity = Vector3.zero;
                rb4.angularVelocity = Vector3.zero;
                rb5.velocity = Vector3.zero;
                rb5.angularVelocity = Vector3.zero;
                }
                
            }
    }
    
    

}