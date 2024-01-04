using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.LookDev;
using UnityEngine.UI;

public class MijenanjeTeksta : MonoBehaviour
{
    public GameObject textObject;
    Text text;
 

    public void MijenjajTekstDesno()
    {
        text = textObject.GetComponent<Text>();

        //Koala
        if (text.text == "1. Koala means 'No drink'")
        {
            text.text = "2. They don’t live in social groups";
        }
       else if (text.text == "2. They don’t live in social groups")
        {
            text.text = "3. They can sleep up to 18 hours a day";
        }
       else if (text.text == "3. They can sleep up to 18 hours a day")
        {
            text.text = "1. Koala means 'No drink'";
        }

        //Platypus
        if (text.text == "1. Platypuses are venomous")
        {
            text.text = "2. Platypuses lay eggs";
        }
        else if (text.text == "2. Platypuses lay eggs")
        {
            text.text = "3. They're at Risk of Extinction";
        }
        else if (text.text == "3. They're at Risk of Extinction")
        {
            text.text = "1. Platypuses are venomous";
        }

        //Kangaroo
        if (text.text == "1. Kangaroos are the largest marsupials on Earth")
        {
            text.text = "2. They use their tails as a fifth leg";
        }
        else if (text.text == "2. They use their tails as a fifth leg")
        {
            text.text = "3. Together they're called a mob";
        }
        else if (text.text == "3. Together they're called a mob")
        {
            text.text = "1. Kangaroos are the largest marsupials on Earth";
        }

        //Emu
        if (text.text == "1. Emus can run at speeds of up to 48 km per hour")
        {
            text.text = "2. They are the only birds with calf muscles";
        }
        else if (text.text == "2. They are the only birds with calf muscles")
        {
            text.text = "3. They can be helpful to farmers";
        }
        else if (text.text == "3. They can be helpful to farmers")
        {
            text.text = "1. Emus can run at speeds of up to 48 km per hour";
        }

        //Kazuar
        if (text.text == "1. They have giant fingernails on their heads")
        {
            text.text = "2. They can jump five feet off the ground";
        }
        else if (text.text == "2. They can jump five feet off the ground")
        {
            text.text = "3. They’re one of the most dangerous birds alive";
        }
        else if (text.text == "3. They’re one of the most dangerous birds alive")
        {
            text.text = "1. They have giant fingernails on their heads";
        }

    }

    public void MijenjajTekstLijevo()
    {
        text = textObject.GetComponent<Text>();

        //Koala
        if (text.text == "1. Koala means 'No drink'")
        {
            text.text = "3. They can sleep up to 18 hours a day";
        }
       else if (text.text == "2. They don’t live in social groups")
        {
            text.text = "1. Koala means 'No drink'";
        }
        else if (text.text == "3. They can sleep up to 18 hours a day")
        {
            text.text = "2. They don’t live in social groups";
        }

        //Platypus
        if (text.text == "1. Platypuses are venomous")
        {
            text.text = "3. They're at Risk of Extinction";
        }
        else if (text.text == "2. Platypuses lay eggs")
        {
            text.text = "1. Platypuses are venomous";
        }
        else if (text.text == "3. They're at Risk of Extinction")
        {
            text.text = "2. Platypuses lay eggs";
        }

        //Kangaroo
        if (text.text == "1. Kangaroos are the largest marsupials on Earth")
        {
            text.text = "3. Together they're called a mob";
        }
        else if (text.text == "2. They use their tails as a fifth leg")
        {
            text.text = "1. Kangaroos are the largest marsupials on Earth";
        }
        else if (text.text == "3. Together they're called a mob")
        {
            text.text = "2. They use their tails as a fifth leg";
        }

        //Emu
        if (text.text == "1. Emus can run at speeds of up to 48 km per hour")
        {
            text.text = "3. They can be helpful to farmers";
        }
        else if (text.text == "2. They are the only birds with calf muscles")
        {
            text.text = "1. Emus can run at speeds of up to 48 km per hour";
        }
        else if (text.text == "3. They can be helpful to farmers")
        {
            text.text = "2. They are the only birds with calf muscles";
        }

        //Kazuar
        if (text.text == "1. They have giant fingernails on their heads")
        {
            text.text = "3. They’re one of the most dangerous birds alive";
        }
        else if (text.text == "2. They can jump five feet off the ground")
        {
            text.text = "1. They have giant fingernails on their heads";
        }
        else if (text.text == "3. They’re one of the most dangerous birds alive")
        {
            text.text = "2. They can jump five feet off the ground";
        }
    }
}
