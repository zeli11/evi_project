using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

	void Start () {
	}

    void Update()
    {
        if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.Space))
            OnClickPlay();

        if (Input.GetKey(KeyCode.Escape))
            OnClickExit();
    }

	public void OnClickPlay(){
        SceneManager.LoadScene("Game");
	}

	public void OnClickScores(){
        Debug.Log("You have clicked the scores button!");
	}

	public void OnClickExit(){
		Application.Quit();
	}

}
