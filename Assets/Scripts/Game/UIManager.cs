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
    private ItemGenerator itemGen;
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
    public TMP_Text DamageText
    {
        get { return damageText; }
        set { damageText = value; }
    }
    private TMP_Text armourText;
    public TMP_Text ArmourText
    {
        get { return armourText; }
        set { armourText = value; }
    }
    private TMP_Text weightText;
    public TMP_Text WeightText
    {
        get { return weightText; }
        set { WeightText = value; }
    }
    private TMP_Text valueText;
    public TMP_Text ValueText
    {
        get { return valueText; }
        set { valueText = value; }
    }

    private const string damageStart = "Damage = 0";
    private const string armourStart = "Armour = 0";
    private const string weightStart = "Weight = 0";
    private const string valueStart = "Value = 0";

    private const string uiError0 = "No Item found";
    private const string uiError1 = "Invalid hex color code: ";

    void Start()
    {
        itemGen = GameObject.Find("Item Generator").GetComponent<ItemGenerator>();
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
        damageText.text = String.Format($"{damageStart}");
        armourText.text = String.Format($"{armourStart}");
        weightText.text = String.Format($"{weightStart}");
        valueText.text = String.Format($"{valueStart}");
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
            Debug.LogError(String.Format($"{uiError1} {hexColor}"));
        }
    }

    public void UpdateText(string itemOutput)
    {
        itemText.text = itemOutput;
        damageText.text = String.Format($"Damage = {itemGen.ItemType.ItemTypeDamage}");
        armourText.text = String.Format($"Armour = {itemGen.ItemType.ItemTypeArmour}");
        weightText.text = String.Format($"Weight = {itemGen.ItemType.ItemTypeWeight}");
        valueText.text = String.Format($"Value = {itemGen.ItemType.ItemTypeValue}");
    }

    public void AddItemToLog(string itemOutput)
    {
        if (itemOutput != null)
        {
            TMP_Text logOutput = logBuffer[currentIndex];
            SetTextColor(itemGen.Rarity.RarityColor, logOutput);
            logOutput.text = itemOutput;
            currentIndex = (currentIndex + 1) % logBuffer.Length;
        }
    }
}