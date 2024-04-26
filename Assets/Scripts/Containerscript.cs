using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attach behaviour to game object using Unity MonoBehaviour.
public class Containerscript : MonoBehaviour
{
    //public slot to drag and drop UI GameObject in
    public GameObject ui;

    //triggered automatically when something collides with this object's box collider.
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //If it's the player show the UI element.
            ui.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //If player leaves hide the UI element.
            ui.SetActive(false);
        }
    }
}

