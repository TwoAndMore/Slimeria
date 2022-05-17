using System;
using UnityEngine;

public class ActivateBuilding : MonoBehaviour
{
    private const string PLAYERTAG = "Player";
    private const KeyCode ACTIVATE = KeyCode.F;
    [SerializeField] private GameObject _pressButton;

    private bool _inRange;

    private void Update()
    {
        if (_inRange && Input.GetKeyDown(ACTIVATE))
        {
             
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entered");
        if(!other.CompareTag(PLAYERTAG))
            return;
        _inRange = true;
        _pressButton.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(!other.CompareTag(PLAYERTAG))
            return;
        _inRange = false;
        _pressButton.SetActive(false);
    }
}
