using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Method that increases the player's age by a predefined number of years
    void IncreaseAge(int currentAge, int years)
    {
        int newAge = currentAge + years;
        Debug.Log("New Age after " + years + " years: " + newAge);
    }

    // Testing both methods
    void Start()
    {
        int playerAge = 23;

        // Calling the first method (1-year increase)
        IncreaseAge(playerAge); // Should log 26

        // Calling the overloaded method (predefined years increase)
        int yearsToAdd = 5;
        IncreaseAge(playerAge, yearsToAdd); // Should log 30

        yearsToAdd = 10;
        IncreaseAge(playerAge, yearsToAdd); // Should log 35
    }

    // First method (age increment by 1 year)
    void IncreaseAge(int currentAge)
    {
        int newAge = currentAge + 1;
        Debug.Log("New Age after 1 year: " + newAge);
    }
}