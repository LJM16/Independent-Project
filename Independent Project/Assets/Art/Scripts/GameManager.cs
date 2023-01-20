using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int _keyCount = 0;

    public GameObject[] CollectibleObjects;
    public void UpdateKeyCount(int amount)
    {
        _keyCount += amount;

        for(int i = 0; i <_keyCount; i++)
        {
            CollectibleObjects[i].gameObject.SetActive(true);
        }
    }
}
