using UnityEngine;

public class TableController : MonoBehaviour
{
    public DoorController associatedDoor;
    private bool isActivated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Crystal") && !isActivated)
        {
            if (associatedDoor != null)
            {
                associatedDoor.ActivateDoor();
            }
            isActivated = true;
        }
    }
}
