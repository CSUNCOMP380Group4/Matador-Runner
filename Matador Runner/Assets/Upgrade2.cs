using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Upgrade2 : MonoBehaviour
{
    public void JumpUpgrade()
    {
        SceneManager.LoadScene("ThirdLevel");
    }
    public void SpeedUpgrade()
    {
        SceneManager.LoadScene("ThirdLevelPt1.3");
    }
}
