using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    private TMP_Text itemText;
    public TMP_Text ItemText
    {
        get { return itemText; }
    }
    private TMP_Text logText;
    private RarityGenerator rarGen;
    private const string noItemStr = "No Item found";
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
        logBuffer = new TMP_Text[]{ log1, log2, log3, log4, log5 };
        itemText.text = String.Format("{0}", noItemStr);
    }

    public void SetTextColor(string rarity, TMP_Text text)
    {
        string hexColor = rarGen.Color;
        Color color;
        if (ColorUtility.TryParseHtmlString(hexColor, out color))
        {
            text.color = color;
        }
        else
        {
            Debug.LogError("Invalid hex color code: " + hexColor);
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
