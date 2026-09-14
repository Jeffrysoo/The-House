using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalDoor : MonoBehaviour
{
    [SerializeField] bool canOpen;
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject theCam;
    [SerializeField] GameObject textOnScreen;
    [SerializeField] AudioSource lockedDoorSound;

  void Update()
  {
    if(canOpen == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(OpeningDoor());
            }
        }
  }
  void OnMouseOver()
    {   
        if(PlayerCasting.distanceFromTarget <= 9)
        {
        canOpen = true;
        UiController.actionText = "Open Door";
        UiController.commandText = "Open";
        UiController.uiActive = true;
        }

        else
        {
            UiController.actionText = "";
            UiController.commandText = "";
            UiController.uiActive = false;
        }
    }
    void OnMouseExit()
    {   
        canOpen = false;
        UiController.actionText = "";
        UiController.commandText = "";
        UiController.uiActive = false;
    }

    IEnumerator OpeningDoor()
    {
        theCam.SetActive(true);
        thePlayer.SetActive(false);
        textOnScreen.SetActive(true);
        lockedDoorSound.Play();
        yield return new WaitForSeconds(2);
        textOnScreen.SetActive(false);
        thePlayer.SetActive(true);
        theCam.SetActive(false);
    }

}
