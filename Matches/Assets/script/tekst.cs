using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;



public class tekst : MonoBehaviour
{
    public string stringToEdit = "Wprowadz liczbe zapalek";
    
    void OnGUI()
    {
        //Pole tesktowe na planszy 1
        stringToEdit = GUI.TextArea(new Rect(425, 250, 100, 50), stringToEdit, 200);
        
        if (GUI.Button (new Rect(425,325,150,20),"Zapisz ilość zapałek")) {
           
           PlayerPrefs.SetString("Text Area", stringToEdit);
        }
        
    }
    
   
}
