using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 1
using UnityEngine.SceneManagement;
// 2
public static class Utilities
{
public static int PlayerDeaths = 0;
public static string UpdateDeathCount(ref int countReference)
{
    //2
    countReference += 1;
    return "Next time you'll be at number" + countReference;
}
public static void RestartLevel()
{
SceneManager.LoadScene(0);
Time.timeScale = 1.0f;
}
public static bool RestartLevel(int sceneIndex)
// 2
{
// 3
Debug.Log("Player deaths: " + PlayerDeaths);
string message = UpdateDeathCount(ref PlayerDeaths);
Debug.Log("Player deaths: " + PlayerDeaths);
Debug.Log(message);
SceneManager.LoadScene(sceneIndex);
Time.timeScale = 1.0f;
return true;
}

}
