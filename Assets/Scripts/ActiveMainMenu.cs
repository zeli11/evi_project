using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActiveMainMenu : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
