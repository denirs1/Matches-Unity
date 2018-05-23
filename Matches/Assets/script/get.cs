using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

using UnityEngine;


public class get : MonoBehaviour {

    // Use this for initialization
    private string y;
    public Text punkty;
    private int zapalki;
    private int postac = 1 ;
     void Update()
    {
        //pobieranie pola teskwego z planszy 1 i wstawianie go do zmiennej. Wyświetlenie ilości zapałek na ekranie
        tekst editstring = gameObject.GetComponent<tekst>();
       y = PlayerPrefs.GetString("Text Area");

        zapalki = Convert.ToInt32(y);
        punkty.text = zapalki.ToString();

       
    }
    //odejmowanie zapałek
    /*
      zapalki = zapalki - x; <- odejmowanie zapalek
            y = Convert.ToString(zapalki); <- konwertowanie zapałek na string
            PlayerPrefs.SetString("Text Area", y); <- przypisywanie przekonwertownego y do Playerprefu
            punkty.text = zapalki.ToString(); <-wyswietlanie
      */
    void OnGUI()
    {
        
          zapalki= Convert.ToInt32(y);

        
        if (zapalki >= 1)
        { 

            

            if (zapalki>=3) {
                if (GUI.Button(new Rect(100, 30, 60, 20), "3"))
                {
                    zapalki = zapalki - 3;

                    postac = postac + 1;
                    konwertowanie();
                    
                }
            }
            if (zapalki >= 2)
            {
                if (GUI.Button(new Rect(200, 30, 60, 20), "2"))
                {
                    zapalki = zapalki - 2;
                    postac = postac + 1;
                    konwertowanie();
                }
            }
            if (GUI.Button(new Rect(300, 30, 60, 20), "1"))
            {
                zapalki = zapalki - 1;
                postac = postac + 1;
                konwertowanie();
            }
            if(zapalki == -2)
            {
                zapalki = zapalki + 2;
                konwertowanie();

            }
            if (zapalki == -1)
            {
                zapalki = zapalki + 1;
                konwertowanie();

            }
            
              
         
        }
        if (zapalki == 0)
        {

            GUI.Button(new Rect(500, 25, 100, 30), "Wygrywa");

        }

        if (postac == 1)
        {

            GUI.Button(new Rect(400, 30, 60, 20), "Gracz1");
            
        }

        if (postac>1)
        {
            GUI.Button(new Rect(400, 60, 60, 20), "Gracz2");
            if (postac == 3)
                postac = 1;
        }


    }
    //konwertowanie z komentarza wyżej
    void konwertowanie() {

        y = Convert.ToString(zapalki);
        PlayerPrefs.SetString("Text Area", y);
        punkty.text = zapalki.ToString();

    }

    
}
