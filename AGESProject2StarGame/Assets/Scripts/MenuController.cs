using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public GameObject playButton;
    public GameObject creditsButton;
    public GameObject exitButton;

    public GameObject credits;

    bool creditsopen = false;

	// Use this for initialization
	void Start () {
        Button PlayButton = playButton.GetComponent<Button>();
        Button CreditsButton = creditsButton.GetComponent<Button>();
        Button ExitButton = exitButton.GetComponent<Button>();
        PlayButton.onClick.AddListener(Play);
        CreditsButton.onClick.AddListener(Credits);
        ExitButton.onClick.AddListener(Exit);

        credits.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Play()
    {
        SceneManager.LoadScene(1);
    }

    void Credits()
    {
        credits.SetActive(true);
        playButton.SetActive(false);
        creditsButton.SetActive(false);
        creditsopen = true;
    }

    void Exit()
    {
        if (creditsopen)
        {
            credits.SetActive(false);
            playButton.SetActive(true);
            creditsButton.SetActive(true);
            creditsopen = false;
        }
        else { Application.Quit(); }
    }
}
