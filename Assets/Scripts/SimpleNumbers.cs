using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SimpleNumbers : MonoBehaviour
{
    public TextMeshProUGUI InfoLabel;
    public TextMeshProUGUI Result;
    public TextMeshProUGUI Sumamount;
    public TextMeshProUGUI Stepamount;
    
   
    [SerializeField] private Button Number1;
    [SerializeField] private Button Number2;
    [SerializeField] private Button Number3;
    [SerializeField] private Button Number4;
    [SerializeField] private Button Number5;
    [SerializeField] private Button Number6;
    [SerializeField] private Button Number7;
    [SerializeField] private Button Number8;
    [SerializeField] private Button Number9;
    [SerializeField] private Button StepAmount;

    private int _sum = 0;
    private int _summount = 0;
   
    
   
    
    // Start is called before the first frame update
    void Start()
    {
        Number1.onClick.AddListener(Number1ButtonClicked);
        Number2.onClick.AddListener(Number2ButtonClicked);
        Number3.onClick.AddListener(Number3ButtonClicked);
        Number4.onClick.AddListener(Number4ButtonClicked);
        Number5.onClick.AddListener(Number5ButtonClicked);
        Number6.onClick.AddListener(Number6ButtonClicked);
        Number7.onClick.AddListener(Number7ButtonClicked);
        Number8.onClick.AddListener(Number8ButtonClicked);
        Number9.onClick.AddListener(Number9ButtonClicked);
        
        
        SetInfoText("Игра в 50");
        
        StepAmount.onClick.AddListener(StepAmountClike);

    }

    private void StepAmountClike()
    {
    _sum = 0;
    _summount = 0;
    SetSumamountText("");

    }

    private void SetInfoText (string text)
    {
        Debug.Log(text);
        InfoLabel.text = text;
    }
    
    private void SetResultText(string text)
    {
        Debug.Log(text);
        Result.text = text; 
    }
    
    private void SetSumamountText(string text)
    {
        Debug.Log(text);
        Sumamount.text = text; 
    }
    
    

    private void Number1ButtonClicked()
    {
        _sum += 1;
        _summount++;
        SetResultText($"Сумма {_sum}");

        if (_sum > 50)
        {
            SetResultText("Перебор,игра окончена !");
            SetSumamountText($"Количество шагов - {_summount}");
        }
        
        if (_sum == 50)
        {
            SetInfoText("Ура! Победа!");
            SetSumamountText($"Количество шагов - {_summount}");
        }
    }

    private void Number2ButtonClicked()
    {
        _sum += 2;
        _summount++;
        SetResultText($"Сумма {_sum}");
        
        if (_sum > 50)
        {
            SetResultText("Перебор,игра окончена ! ");
            SetSumamountText($"Количество шагов - {_summount}");
        }
        
        if (_sum == 50)
        {
            SetInfoText("Ура! Победа!");
            SetSumamountText($"Количество шагов - {_summount}");
        }
    }

    private void Number3ButtonClicked()
    {
        _sum += 3;
        _summount++;
        SetResultText($"Сумма {_sum}");
        
        if (_sum > 50)
        {
            SetResultText("Перебор,игра окончена ! ");
            SetSumamountText($"Количество шагов - {_summount}");
        }
        
        if (_sum == 50)
        {
            SetInfoText("Ура! Победа!");
            SetSumamountText($"Количество шагов - {_summount}");
        }
    }

    private void Number4ButtonClicked()
    {
        _sum += 4;
        _summount++;
        SetResultText($"Сумма {_sum}");
        
        if (_sum > 50)
        {
            SetResultText("Перебор,игра окончена ! ");
            SetSumamountText($"Количество шагов - {_summount}");
        }
        
        if (_sum == 50)
        {
            SetInfoText("Ура! Победа!");
            SetSumamountText($"Количество шагов - {_summount}");
        }
    }

    private void Number5ButtonClicked()
    {
        _sum += 5;
        _summount++;
        SetResultText($"Сумма {_sum}");
        
        if (_sum > 50)
        {
            SetResultText("Перебор,игра окончена ! ");
            SetSumamountText($"Количество шагов - {_summount}");
        }
        
        if (_sum == 50)
        {
            SetInfoText("Ура! Победа!");
            SetSumamountText($"Количество шагов - {_summount}");
        }
    }

    private void Number6ButtonClicked()
    {
        _sum += 6;
        _summount++;
        SetResultText($"Сумма {_sum}");
        
        if (_sum > 50)
        {
            SetResultText("Перебор,игра окончена ! ");
            SetSumamountText($"Количество шагов - {_summount}");
        }
        
        if (_sum == 50)
        {
            SetInfoText("Ура! Победа!");
            SetSumamountText($"Количество шагов - {_summount}");
        }
    }

    private void Number7ButtonClicked()
    {
        _sum += 7;
        _summount++;
        SetResultText($"Сумма {_sum}");
        
        if (_sum > 50)
        {
            SetResultText("Перебор,игра окончена ! ");
            SetSumamountText($"Количество шагов - {_summount}");
        }
        
        if (_sum == 50)
        {
            SetInfoText("Ура! Победа!");
            SetSumamountText($"Количество шагов - {_summount}");
        }
    }

    private void Number8ButtonClicked()
    {
        _sum += 8;
        _summount++;
        SetResultText($"Сумма {_sum}");
        
        if (_sum > 50)
        {
            SetResultText("Перебор,игра окончена ! ");
            SetSumamountText($"Количество шагов - {_summount}");
        }
        
        if (_sum == 50)
        {
            SetInfoText("Ура! Победа!");
            SetSumamountText($"Количество шагов - {_summount}");
        }
    }

    private void Number9ButtonClicked()
    {
        _sum += 9;
        _summount++;
        SetResultText($"Сумма {_sum}");
        
        if (_sum > 50)
        {
            SetResultText("Перебор,игра окончена ! ");
            SetSumamountText($"Количество шагов - {_summount}");
        }

        if (_sum == 50)
        {
            SetInfoText("Ура! Победа!");
            SetSumamountText($"Количество шагов - {_summount}");
        }
    }
    
    
    

    // Update is called once per frame

    void Update()
    {
        
    }
}
