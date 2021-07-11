using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Upgrade3 : MonoBehaviour
{
    public void JumpUpgrade()
    {
        SceneManager.LoadScene("ThirdLevelPt1.4");
    }
    public void SpeedUpgrade()
    {
        SceneManager.LoadScene("ThirdLevelPt1.5");
    }
}
