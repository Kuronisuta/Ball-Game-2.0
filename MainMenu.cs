using UnityEngine;
using System.Collections;


public class MainMenu : MonoBehaviour {
    public int High;
    public int newHigh;
    public void sceneChange()
    {
        newHigh = 0;
        Application.LoadLevel("game");

    }
}
