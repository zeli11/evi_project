using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsUI : MonoBehaviour
{
    [SerializeField] private Button returnButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        returnButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(0);
        });
    }
}
