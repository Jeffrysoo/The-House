using UnityEngine;

public class DoorJumpscare : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private AudioSource pianoScare;
    [SerializeField] private AudioSource doorSlam;
    [SerializeField] private GameObject theDoor;
    [SerializeField] private GameObject gunPickup;

  void OnTriggerEnter(Collider other)
  {
    theDoor.GetComponent<Animator>().Play("Monster Door Open");
    pianoScare.Play();
    doorSlam.Play();
    gunPickup.SetActive(true);
    this.gameObject.GetComponent<BoxCollider>().enabled = false;
  }
}
