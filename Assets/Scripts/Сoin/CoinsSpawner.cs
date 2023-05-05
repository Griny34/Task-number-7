using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    [SerializeField] private Jump _prefabCoin;
    [SerializeField] private Transform _pointSpawn;
    [SerializeField] private float _delay;

    private void Start()
    {
        StartCoroutine(InstantiateCoins());
    }

    private IEnumerator InstantiateCoins()
    {
        while (true)
        {
            InstantiateCoin();
            yield return new WaitForSeconds(_delay);
        }

    }

    private void InstantiateCoin()
    {
        Instantiate(_prefabCoin, _pointSpawn.position, Quaternion.identity);
    }
}
