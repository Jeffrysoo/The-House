using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoxScareScript : MonoBehaviour
{
    public GameObject boxHolder;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            boxHolder.SetActive(false);
        }
    }
}
