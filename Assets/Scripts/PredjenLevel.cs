using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PredjenLevel : MonoBehaviour
{
    public Image image;
    public Button button;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (text.text == "GO TO NORTH AMERICA") // nisam htio mijenjati ovo America -> Afrika...
        {
            if (GlobalMemory.totemAfrika == 1 || GlobalMemory.gsAfrika == 1)
            {
                image.color = Color.green;
                button.enabled = false;
                button.image.color = Color.gray;
                text.text = "Task completed";
                text.color = Color.green;

                GlobalMemory.gsAfrika = 1;
            }
        }
        if (text.text == "GO TO ANTARCTICA") // nisam htio mijenjati ovo America -> Afrika...
        {
            if (GlobalMemory.totemAnt == 1 || GlobalMemory.gsAnt == 1)
            {
                image.color = Color.green;
                button.enabled = false;
                button.image.color = Color.gray;
                text.text = "Task completed";
                text.color = Color.green;

                GlobalMemory.gsAnt = 1;
            }
        }
        if (text.text == "GO TO AUSTRALIA")
        {
            if (GlobalMemory.totemAustralija == 1 || GlobalMemory.gsAustralija == 1)
            {
                image.color = Color.green;
                button.enabled = false;
                button.image.color = Color.gray;
                text.text = "Task completed";
                text.color = Color.green;

                GlobalMemory.gsAustralija = 1;
            }

            if (GlobalMemory.prosloVrijeme == 1)
            {
                text.text = "Task failed! Try again?";
                text.color = Color.white;
                button.image.color = Color.red;
            }

        }

        if (text.text == "GO TO EUROPE")
        {
            if (GlobalMemory.totemEuropa == 1 || GlobalMemory.gsEuropa == 1)
            {
                image.color = Color.green;
                button.enabled = false;
                button.image.color = Color.gray;
                text.text = "Task completed";
                text.color = Color.green;

                GlobalMemory.gsEuropa = 1;
            }
        }
        if (text.text == "GO TO NORTH AMERICA")
        {
            if (BrojanjeLoptica.brojacLoptica == 0 || SmanjivanjeLoptica.poraz == 1)
            {
                text.text = "Task failed! Try again?";
                text.color = Color.white;
                button.image.color = Color.red;
            }
        }

    }
}
