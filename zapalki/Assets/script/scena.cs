using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class scena : MonoBehaviour {
    //ładowanie poziomu
    public void change(string scenename)
    {
        Application.LoadLevel(scenename);
    }
    


}
