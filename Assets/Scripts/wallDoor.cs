using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int doorNumber;  // Oznaèava redni broj vrata (1, 2, 3, 4, 5)
    private bool isOpen = false;

    public void ActivateDoor()
    {
        if (!isOpen)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        transform.Translate(Vector3.up * 5f);
        isOpen = true;
    }
}
