using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickUp : MonoBehaviour
{
    [SerializeField] bool canPick;
    [SerializeField] GameObject textOnScreen;
    [SerializeField] GameObject tableCandle;
    [SerializeField] GameObject handCandle;
    [SerializeField] GameObject handGun;
    [SerializeField] GameObject tableGun;

    void Update()
    {
        if (canPick == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                tableCandle.SetActive(true);
                handCandle.SetActive(false);
                tableGun.SetActive(false);
                handGun.SetActive(true);
            }
        }
    }
    void OnMouseOver()
    {
        if (PlayerCasting.distanceFromTarget < 5)
        {
            canPick = true;
            UiController.actionText = "Handgun";
            UiController.commandText = "Pick Up";
            UiController.uiActive = true;
        }
        else
        {
            canPick = false;
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
