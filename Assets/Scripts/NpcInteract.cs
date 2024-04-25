using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcInteract : MonoBehaviour
{ 
   public GameObject ui;

void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        ui.SetActive(true);
    }
}

void OnTriggerExit(Collider other)
{
    if (other.CompareTag("Player"))
    {
        ui.SetActive(false);
    }
}
}