using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inneco : MonoBehaviour
{
    public GameObject Dock;
    public GameObject Observe;
    public GameObject Hallway;
    public GameObject Hydroponics;
    public GameObject Innercore;
    
    public GameObject SceneChange;

    public void DockActive()
    {
        Innercore.SetActive(false);
        Dock.SetActive(true);
    }
    public void ObserveActive()
    {
        Innercore.SetActive(false);
        Observe.SetActive(true);
    }

    public void MedbayActive()
    {
        Innercore.SetActive(false);
        Hallway.SetActive(true);
    }
    public void HydroponicsActive()
    {
        Innercore.SetActive(false);
        Hydroponics.SetActive(true);
    }
}
