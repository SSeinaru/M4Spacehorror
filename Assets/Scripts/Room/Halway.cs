using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Halway : MonoBehaviour
{
    public GameObject hallway;
    public GameObject innercore;
    public GameObject airlock;
    public GameObject medbay;
    // Start is called before the first frame update
    public void returnInner()
    {
        hallway.SetActive(false);
        innercore.SetActive(true);
    }
    public void GoAirlock()
    {
        hallway.SetActive(false);
        airlock.SetActive(true);
    }
    public void GoMedbay()
    {
        hallway.SetActive(false);
        medbay.SetActive(true);
    }
}
