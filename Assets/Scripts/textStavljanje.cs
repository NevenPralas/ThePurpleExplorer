using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textStavljanje : MonoBehaviour
{
    public Text textKucica;

    public string text;
    // Start is called before the first frame update
    void Start()
    {
        text = "Nista";
    }

    // Update is called once per frame
    void Update()
    {
        if (textKucica.text == "North America" || text == "North America")
        {
            if (GlobalMemory.totemAfrika == 1)
            {
                text = "North America";

                textKucica.text = "Task completed";

                textKucica.color = Color.green;

                textKucica.fontSize = 40;
            }
            if (GlobalMemory.totemAfrika == 0)
            {
                textKucica.text = "North America";

                textKucica.color = Color.white;

                textKucica.fontSize = 40;
            }
        }

        if (textKucica.text == "Australia" || text == "Australia")
        {
            if (GlobalMemory.totemAustralija == 1)
            {
                text = "Australia";

                textKucica.text = "Task completed";

                textKucica.color = Color.green;

                textKucica.fontSize = 40;
            }
            if (GlobalMemory.totemAustralija == 0)
            {
                textKucica.text = "Australia";

                textKucica.color = Color.white;

                textKucica.fontSize = 40;
            }
        }

        if (textKucica.text == "Europe" || text == "Europe")
        {
            if (GlobalMemory.totemEuropa == 1)
            {
                text = "Europe";

                textKucica.text = "Task completed";

                textKucica.color = Color.green;

                textKucica.fontSize = 40;
            }
            if (GlobalMemory.totemEuropa == 0)
            {
                textKucica.text = "Europe";

                textKucica.color = Color.white;

                textKucica.fontSize = 40;
            }
        }
    }

}

