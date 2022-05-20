using System;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public static Coins Instance;
    
    [SerializeField] private TextMeshProUGUI _text;
    
    public int currentCoins;

    private void Awake() => 
        Instance = this;

    private void Start()
    {
        AddCoins(300);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            AddCoins(300);
        }
    }

    public void AddCoins(int amount)
    {
        currentCoins += amount;
        _text.text = currentCoins + " $";
    }
}
