using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Text Text;
    private int clickCount = 0;

    void Start()
    {
        Text.text = "Click Count: " + clickCount;
    }

    public void USGClick()
    {
        clickCount++;
        Text.text = "Click Count: " + clickCount;
        Debug.Log("Clicked");
    }
}
