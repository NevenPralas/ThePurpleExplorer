using UnityEngine;
using UnityEngine.UI;

public class OmoguciDugmad : MonoBehaviour
{
    [SerializeField] GameObject[] materials = new GameObject[10];
    public Button startButton;
    void Start()
    {
        startButton.onClick.AddListener(Omoguci);
    }

    void Omoguci()
    {


        for (int i = 0; i < 10; i++)
        {
            BoxCollider button = materials[i].GetComponent<BoxCollider>();

            if (button != null)
            {
                button.enabled = true;
            }
            else
            {
                Debug.LogError("Button komponenta nije pronadena na objektu " + i);
            }
        }
    }
}
