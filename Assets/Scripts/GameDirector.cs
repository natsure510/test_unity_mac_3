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

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;
            Text.text = "Click Count: " + clickCount;
        }
    }
}
