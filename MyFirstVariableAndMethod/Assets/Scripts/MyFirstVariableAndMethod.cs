using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstVariableAndMethod : MonoBehaviour
{
    // Method that increases the player's age by 1 year
    void IncreaseAge(int currentAge)
    {
        int newAge = currentAge + 1;
        Debug.Log("New Age after 1 year: " + newAge);
    }

    // Testing the method in Unity
    void Start()
    {
        int playerAge = 23;
        IncreaseAge(playerAge); // Should log 26
    }
}
