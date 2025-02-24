using System.Collections;
using System.Collections.Generic;
using CustomExtensions;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameBehavior : MonoBehaviour
{
    // 2
private string _state;
// 3
public string State
{
get { return _state; }
set { _state = value; }
}
    public int MaxItems = 4;
    public Text HealthText;
    public Text ItemText;
    public Text ProgressText;
    public Button WinButton;
    public Button LossButton;

    void Start()
    { 
        ItemText.text += _itemsCollected;
        HealthText.text += _playerHP;
        Initialize();
    }
    public void Initialize()
    {
        _state = "Game Manager initialized..";
Debug.Log(_state);
_state.FancyDebug();
Debug.Log(_state);
    }

    private int _itemsCollected = 0;
    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;
            ItemText.text = "Items Collected: " + Items;

            if (_itemsCollected >= MaxItems)
            {
                WinButton.gameObject.SetActive(true);
                UpdateScene("You've found all the items!");
            }
            else
            {
                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected) + " more to go!";
            }
        }
    }

    private int _playerHP = 10;
    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            HealthText.text = "Player Health: " + HP;

            if (_playerHP <= 0)
            {
                LossButton.gameObject.SetActive(true);
                UpdateScene("You want another life with that?");
            }
            else
            {
                ProgressText.text = "Ouch... that's got hurt.";
            }

            Debug.LogFormat("Lives: {0}", _playerHP);
        }
    }

    public void UpdateScene(string updatedText)
    {
        ProgressText.text = updatedText;
        Time.timeScale = 0f;
    }

    public void RestartScene()
    {
  Utilities.RestartLevel(0);
    }
}
