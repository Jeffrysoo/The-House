using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CandlePickUp : MonoBehaviour
{
    [SerializeField] bool canPick;
    [SerializeField] GameObject textOnScreen;
    [SerializeField] GameObject tableCandle;
    [SerializeField] GameObject handCandle;
    [SerializeField] GameObject webEvent;

  void Update()
  {
    if(canPick == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                tableCandle.SetActive(false);
                handCandle.SetActive(true);
                webEvent.SetActive(true);

                canPick = false;
                UiController.actionText = "";
                UiController.commandText = "";
                UiController.uiActive = false;
            }
        }
  }
  void OnMouseOver()
    {   
        if(PlayerCasting.distanceFromTarget <= 9)
        {
        canPick = true;
        UiController.actionText = "Candle";
        UiController.commandText = "Pick Up";
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
        canPick = false;
        UiController.actionText = "";
        UiController.commandText = "";
        UiController.uiActive = false;
    }

   

}
