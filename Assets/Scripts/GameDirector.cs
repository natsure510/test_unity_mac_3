using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Text Text;
    [SerializeField] private GameObject effectsg;// prefab
    [SerializeField] private Transform effectsg_Parent;
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

        GameObject obj = Instantiate(effectsg, effectsg_Parent);
        obj.transform.localPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
