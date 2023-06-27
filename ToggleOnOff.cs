using UnityEngine;

public class ToggleONOff : MonoBehaviour
{
    public GameObject objectToToggle;

    private bool isVisible = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isVisible = !isVisible;
            objectToToggle.SetActive(isVisible);
        }
    }
}
