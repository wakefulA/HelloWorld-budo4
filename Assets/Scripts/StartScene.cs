using TMPro;
using UnityEngine;


public class StartScene : MonoBehaviour
{
    public TextMeshProUGUI StartSceneLabel;
    public TextMeshProUGUI InfoGuess;
    
    void Start()
    {
        SetInfoText("Привет, ты в игре Magic Numbers !");
    }
    
    private void SetInfoText(string text)
    

    {
        Debug.Log(text);
        StartSceneLabel.text = text;
    }
}
