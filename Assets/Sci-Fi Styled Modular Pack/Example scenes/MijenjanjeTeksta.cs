using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MijenjanjeTeksta : MonoBehaviour
{
    void Start()
    {
        Invoke("PromijeniTekst1", 6f);
    }

    void PromijeniTekst1()
    {
        TextMeshPro textMeshProComponent = GetComponent<TextMeshPro>();

        if (textMeshProComponent != null)
        {
            textMeshProComponent.text = "We hope you enjoyed playing our game.";

            Invoke("PromijeniTekst2", 6f);
        }
        else
        {
            Debug.LogError("TextMeshPro komponenta nije pronadjena na istom objektu.");
        }
    }

    void PromijeniTekst2()
    {
        TextMeshPro textMeshProComponent = GetComponent<TextMeshPro>();

        if (textMeshProComponent != null)
        {
            textMeshProComponent.text = "Good luck in your future challenges.";

            Invoke("PromijeniTekst3", 6f);
        }
        else
        {
            Debug.LogError("TextMeshPro komponenta nije pronadjena na istom objektu.");
        }
    }

    void PromijeniTekst3()
    {
        TextMeshPro textMeshProComponent = GetComponent<TextMeshPro>();

        if (textMeshProComponent != null)
        {
            textMeshProComponent.text = "Loading...";

            Invoke("UcitajMainMenuScenu", 6f);
        }
        else
        {
            Debug.LogError("TextMeshPro komponenta nije pronadjena na istom objektu.");
        }
    }

    void UcitajMainMenuScenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}