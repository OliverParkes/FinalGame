using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{

    public static bool Firing = false;

    public bool FireLocal;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            Firing = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Firing = false;
        }
    }

    private void Update()
    {
        FireLocal = Firing;
    }
}
