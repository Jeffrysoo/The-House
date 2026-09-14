using UnityEngine;

public class UiController : MonoBehaviour
{
    public static string actionText;
    public static string commandText;
    public static bool uiActive;

    [SerializeField] GameObject actionBox;
    [SerializeField] GameObject commandBox;
    [SerializeField] GameObject interactCross;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (uiActive)
            {
                actionBox.SetActive(true);
                commandBox.SetActive(true);
                interactCross.SetActive(false);
                actionBox.GetComponent<TMPro.TextMeshProUGUI>().text = actionText;
                commandBox.GetComponent<TMPro.TextMeshProUGUI>().text = "[E] " + commandText;
            }
            else
            {
                actionBox.SetActive(false);
                commandBox.SetActive(false);
                interactCross.SetActive(true);
            }
    }
}
