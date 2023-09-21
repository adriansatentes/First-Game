using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TryAgain : MonoBehaviour
{
     public void LoadGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }
}
