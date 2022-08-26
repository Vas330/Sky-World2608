using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Animations : MonoBehaviour
{


    public GameObject headPanel;
    public GameObject headPanel1;
    public GameObject headPanel2;
    public GameObject headPanel5;

    public void OnClickPlay()
    {
        if (!headPanel.GetComponent<Animator>().enabled) headPanel.GetComponent<Animator>().enabled = true;
        else headPanel.GetComponent<Animator>().SetTrigger("In");
    }
    public void OnClickPlay1()
    {
        if (!headPanel1.GetComponent<Animator>().enabled) headPanel1.GetComponent<Animator>().enabled = true;
        else headPanel1.GetComponent<Animator>().SetTrigger("In1");
    }
    public void OnClickPlay2()
    {
        if (!headPanel2.GetComponent<Animator>().enabled) headPanel2.GetComponent<Animator>().enabled = true;
        else headPanel2.GetComponent<Animator>().SetTrigger("In2");
    }
    public void OnClickPlay4()
    {
        if (!headPanel5.GetComponent<Animator>().enabled) headPanel5.GetComponent<Animator>().enabled = true;
        else headPanel5.GetComponent<Animator>().SetTrigger("P");
    }

}
