using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float countdownTime = 30f;
    private bool isCountingDown = false;
    public Text countdownText;
    public TextMeshProUGUI countdownText2;
    public Button startButton;

    public GameObject audioSource;
    public AudioClip audioClip;
    public AudioClip audioClipS;

    void Start()
    {
        countdownText.color = Color.white;
        countdownText2.color = Color.white;
        GlobalMemory.prosloVrijeme = 0;
        startButton.onClick.AddListener(StartCountdown);
    }

    void Update()
    {
        if (isCountingDown)
        {
            countdownText.text = countdownTime.ToString("F1");
            countdownText2.text = countdownTime.ToString("F1");

            // Dodajte proveru uslova za prekid odbrojavanja
            if (GlobalMemory.pobjeda == 10)
            {
                StopCountdown();
            }
        }
    }

    void StartCountdown()
    {
        if (!isCountingDown)
        {
            audioSource.GetComponent<AudioSource>().clip = audioClip;
            audioSource.GetComponent<AudioSource>().Play();
            StartCoroutine(Countdown());
        }
    }

    IEnumerator Countdown()
    {
        isCountingDown = true;

        while (countdownTime > 0f)
        {
            yield return new WaitForSeconds(1f);

            // Dodajte proveru uslova za prekid odbrojavanja
            if (GlobalMemory.pobjeda == 10)
            {
                StopCountdown();
                countdownText.color = Color.green;
                countdownText.text = "Nice job";
                countdownText2.color = Color.green;
                countdownText2.text = "Nice job";
                yield return new WaitForSeconds(3f);
                countdownText2.text = "";
                yield break; // Izlazak iz Coroutine
            }

            countdownTime -= 1f;
        }

        GlobalMemory.pobjeda = 0;
        GlobalMemory.svi = 0;
        GlobalMemory.kangaroo = 0;
        GlobalMemory.emu = 0;
        GlobalMemory.kazuar = 0;
        GlobalMemory.kljunas = 0;
        GlobalMemory.koala = 0;

         GlobalMemory.pamtiButton = null;
         GlobalMemory.pamti = null;

    GlobalMemory.prosloVrijeme = 1;
        audioSource.GetComponent<AudioSource>().clip = audioClipS;
        audioSource.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Otok");
        Debug.Log("Vrijeme je isteklo!");



        ResetCountdown();
    }

    void StopCountdown()
    {
        audioSource.GetComponent<AudioSource>().clip = audioClipS;
        audioSource.GetComponent<AudioSource>().Play();
        isCountingDown = false;
        Debug.Log("Odbrojavanje je zaustavljeno jer je GlobalMemory.pobjeda dostigla 10.");
    }

    void ResetCountdown()
    {
        isCountingDown = false;
        countdownTime = 60f;
        countdownText.color = Color.red;
        countdownText.text = "Mission Failed";
        countdownText2.color = Color.red;
        countdownText2.text = "Mission Failed";
    }
}