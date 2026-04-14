using System;
using UnityEngine;
using UnityEngine.UI;

public class TextGardenManager : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private InputField inputField;
    [SerializeField] private GameObject scg;
    bool isDecorated = false;

    public void OnSubmit()
    {
        string input = inputField.text;
        text.text = input;
        isDecorated = false;
        inputField.text = "";
    }

    public void OnEndEdit()
    {
        scg.SetActive(true);
        Invoke("DeactivateSCG", 1f);
    }

    private void DeactivateSCG()
    {
        scg.SetActive(false);
    }

    public void Decorate()
    {
        if (isDecorated) return;
        text.text = $"<color=blue><b>{"[" + text.text + "]"}</b></color>";
        isDecorated = true;
    }
}
