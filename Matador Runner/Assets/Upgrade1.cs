using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Upgrade1 : MonoBehaviour
{
    public void TimerUpgrade()
    {
        SceneManager.LoadScene("SecondLevel");
    }
    public void EasierLevel()
    {
        SceneManager.LoadScene("SecondLevelPt1.2");
    }
}
