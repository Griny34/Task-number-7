using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _numberCoins;
    [SerializeField] private PlayerMovement _playerCoin;

    private void Update()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        _numberCoins.text = _playerCoin.NumberCoin.ToString();
    }
}
