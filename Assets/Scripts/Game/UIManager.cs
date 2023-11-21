using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    private TMP_Text itemText;
    public TMP_Text ItemText
    {
        get { return itemText; }
    }
    private TMP_Text logText;
    private RarityGenerator rarGen;
    private List<string> log;
    private TMP_Text log1;
    private TMP_Text log2;
    private TMP_Text log3;
    private TMP_Text log4;
    private TMP_Text log5;
    private TMP_Text[] logBuffer;
    private int currentIndex = 0;
    private GameObject logPanel;
    [SerializeField] private GameObject logTextPrefab;
    private TMP_Text damageText;
    private TMP_Text armourText;
    private TMP_Text weightText;
    private TMP_Text valueText;

    private const string uiError0 = "No Item found";
    private const string uiError1 = "Invalid hex color code: ";

    void Start()
    {
        rarGen = GameObject.Find("Item Generator").GetComponent<RarityGenerator>();
        itemText = GetComponentInChildren<TMP_Text>();
        logPanel = GameObject.Find("LogPanel");
        log1 = GameObject.Find("Log1").GetComponent<TMP_Text>();
        log2 = GameObject.Find("Log2").GetComponent<TMP_Text>();
        log3 = GameObject.Find("Log3").GetComponent<TMP_Text>();
        log4 = GameObject.Find("Log4").GetComponent<TMP_Text>();
        log5 = GameObject.Find("Log5").GetComponent<TMP_Text>();
        damageText = GameObject.Find("DamageText").GetComponent<TMP_Text>();
        armourText = GameObject.Find("ArmourText").GetComponent<TMP_Text>();
        weightText = GameObject.Find("WeightText").GetComponent<TMP_Text>();
        valueText = GameObject.Find("ValueText").GetComponent<TMP_Text>();
        logBuffer = new TMP_Text[]{ log1, log2, log3, log4, log5 };
        itemText.text = String.Format("{0}", uiError0);
    }

    public void SetTextColor(string rarColor, TMP_Text text)
    {
        string hexColor = rarColor;
        Color color;
        if (ColorUtility.TryParseHtmlString(hexColor, out color))
        {
            text.color = color;
        }
        else
        {
            Debug.LogError(String.Format("{0} {1}", uiError1, hexColor));
        }
    }

    public void UpdateText(string itemOutput)
    {
        itemText.text = itemOutput;
    }

    public void AddItemToLog(string itemOutput)
    {
        if (itemOutput != null)
        {
            TMP_Text logOutput = logBuffer[currentIndex];
            SetTextColor(rarGen.Color, logOutput);
            logOutput.text = itemOutput;
            currentIndex = (currentIndex + 1) % logBuffer.Length;
        }
    }
}