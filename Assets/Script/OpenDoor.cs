using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] bool canOpen;
    [SerializeField] AudioSource creakDoor;
    [SerializeField] GameObject theDoor;

    void Update()
    {
        if (canOpen == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(OpeningDoor());
            }
        }
    }
    void OnMouseOver()
    {
        if (PlayerCasting.distanceFromTarget < 5)
        {
            canOpen = true;
            UiController.actionText = "Open Door";
            UiController.commandText = "Open";
            UiController.uiActive = true;
        }
        else
        {
            canOpen = false;
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
        creakDoor.Play();
        theDoor.GetComponent<Animator>().Play("Metal Door Open");
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(2);
    }

}