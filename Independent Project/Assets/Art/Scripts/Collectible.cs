using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
   [SerializeField] int _value = 0;

   GameManager _gameManager;

   void Start()
   {
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
        if(other.gameObject.CompareTag("Player"))
        {
            _gameManager.UpdateKeyCount(_value);
        }
   }
}
