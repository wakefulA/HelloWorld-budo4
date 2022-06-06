using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MagicNumbers : MonoBehaviour
{
    [SerializeField] private int _min = 1;
    [SerializeField] private int _max = 1000;

    public TextMeshProUGUI InfoLabel;
    public Button MoreButton;
    public Button FinishButton;
    public Button LessButton;
    
    private int _guess;
    private int _moveamount = 0 ;
    private void Start()
    {
        MoreButton.onClick.AddListener(MoreButtonClicked);
        FinishButton.onClick.AddListener(FinishButtonClicked);
        LessButton.onClick.AddListener(LessButtonClicked);
        
        SetInfoText(($"Загадай число от {_min} до {_max}."));
        CalculateGuess();
    }
    private void CalculateGuess()
    {
        _guess = (_min + _max) / 2;
        SetInfoText($"Твоё число: {_guess}?, количество шагов {_moveamount}");
    }
    private void SetInfoText (string text)
    {
        Debug.Log(text);
        InfoLabel.text = text; 
    }
    private void MoreButtonClicked()
    {
        _moveamount++;
        SetInfoText($"Число больше, количество шагов {_moveamount}");
        _min = _guess;
        CalculateGuess();
    }
    private void LessButtonClicked()
    {
        _moveamount ++;
        SetInfoText($"Число меньше, количество шагов {_moveamount}");
        _max = _guess;
        CalculateGuess();
    }
    private void FinishButtonClicked()
    {
        ScoreManager.Instance.Score = $"Победа: твоё число {_guess}, количество шагов {_moveamount}";
        SceneManager.LoadScene(2);
    }
}



   



 





 

