using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    [SerializeField] private int _min = 1;
    [SerializeField] private int _max = 1000;

    public TextMeshProUGUI InfoLabel;
    public TextMeshProUGUI InfoGuess;
    public Button MoreButton;
    public Button FinishButton;
    public Button LessButton;
    
    private int _guess;

    private int _moveamount = 0;
    
    
    
  
    private void Start()
    {

        MoreButton.onClick.AddListener(MoreButtonClicked);
        FinishButton.onClick.AddListener(FinishButtonClicked);
        LessButton.onClick.AddListener(LessButtonClicked);
        _min = 1;
        _max = 1000;

        
        SetInfoText(($"Загадай число от {_min} до {_max}."));
        CalculateGuess();
    
    }

    private void Update()
    {
        
    }

    private void CalculateGuess()
    {
        _guess = (_min + _max) / 2;

        SetInfoText($"Твоё число: {_guess}?");
    }

    private void SetInfoText (string text)
    {
        Debug.Log(text);

        InfoLabel.text = text; 
    }

    private void SetGuessText(string text)
    {
        Debug.Log(text);

        InfoGuess.text = text; 
    }


    private void MoreButtonClicked()
    {
        SetInfoText("Число больше");
        _min = _guess;
        CalculateGuess();
        _moveamount++;
    }

    private void LessButtonClicked()
    {
        SetInfoText("Число меньше");
        _max = _guess;
        CalculateGuess();
        _moveamount ++;
    }

    private void FinishButtonClicked()
    {
        SetInfoText($"Победа: твоё число {_guess}, количество шагов {_moveamount}");

        _guess = 0;
        _min = 0;
        _max = 0;

    }
}



   



 





 

