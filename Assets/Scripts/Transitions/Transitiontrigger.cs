using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitiontrigger : MonoBehaviour
{
    private GameObject headPanel;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("TC");
        }

    }
}
