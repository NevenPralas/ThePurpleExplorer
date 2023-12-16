using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//namespace BNG{



public class reset_tools : MonoBehaviour
{
    
    public Vector3 newball1 = new Vector3(547.341f, 48.792f, 355.171f);  
    public Vector3 newball2 = new Vector3(547.2983f, 48.792f, 355.073f);
    public Vector3 newball3 = new Vector3(547.2305f, 48.792f, 355.171f);
    public Vector3 newbat = new Vector3(547.3948f, 48.77557f, 354.7365f);
    public Vector3 newkatana = new Vector3(547.355f, 48.794f, 354.5806f);

    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject bat;
    public GameObject katana;
    
    

    void SetPositionsForNamedObjects()
    {
            if (ball1 != null && ball2 != null && ball3 !=null && bat!=null && katana!=null )
            {
                
                ball1.transform.position = newball1;
                ball2.transform.position = newball2;
                ball3.transform.position = newball3;
                bat.transform.position = newbat;
                katana.transform.position = newkatana;
            }
            
        
    }
    
    /*
 Dictionary<Grabbable, PosRot> _initalGrabbables;

    void Start() {

            

            if(ItemsHolder) {
                _initalGrabbables = new Dictionary<Grabbable, PosRot>();
                var allGrabs = ItemsHolder.GetComponentsInChildren<Grabbable>();
                foreach(var grab in allGrabs) {
                    _initalGrabbables.Add(grab, new PosRot() { Position = grab.transform.position, Rotation = grab.transform.rotation });
                }
            }
        }

         public void ResetGrabbables() {
            foreach (var kvp in _initalGrabbables) {
                // Only reset high level grabbables that aren't being held
                if(kvp.Key != null && !kvp.Key.BeingHeld && kvp.Key.transform.parent == ItemsHolder) {
                    kvp.Key.transform.position = kvp.Value.Position;
                    kvp.Key.transform.rotation = kvp.Value.Rotation;

                    Rigidbody rb = kvp.Key.GetComponent<Rigidbody>();
                    if(rb) {
                        rb.velocity = Vector3.zero;
                        rb.angularVelocity = Vector3.zero;
                    }
                }
            }
        }


public class PosRot {
        public Vector3 Position;
        public Quaternion Rotation;
    }


}
*/

}