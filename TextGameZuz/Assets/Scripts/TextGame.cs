using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int shoot = 500;

    //Program zgaduje liczbe ktora sobie wymyslilismy z przedzialu liczbowego
    void Start()
    {

        Debug.Log("Witaj w grze - pomysl w glowie liczbe od 1 do 1000");
        Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od 500");
        //print string
        //Nacisnij gorna strzalke aby odpowiedziec ze wieksza
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od "+shoot + " ?");
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od " + shoot + " ?");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Komputer zgadl liczbe");
        }
    }
}
