using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityController : MonoBehaviour
{
    public GameObject food;

    void Start()
    {
        
      
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        food.SetActive(true);
    }
}



