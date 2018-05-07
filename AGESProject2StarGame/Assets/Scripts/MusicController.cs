using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour {

    public int currentTrack;
    public Text MusicText;

    AudioSource allMusic;

    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;


	// Use this for initialization
	void Start () {
        allMusic = GetComponent<AudioSource>();

        currentTrack = 1;
        allMusic.clip = clip1;
        allMusic.Play();
        MusicText.text = "Drown In You by Alex Stoner";
	}
	
	// Update is called once per frame
	void Update () {
        CheckAndSwitchMusic();
	}

    void CheckAndSwitchMusic()
    {
        if (!allMusic.isPlaying)
        {
            if (currentTrack != 4)
            { currentTrack++; }
            else { currentTrack = 1; }

            if (currentTrack == 1)
            {
                allMusic.clip = clip1;
                allMusic.Play();
                MusicText.text = "Drown In You by Alex Stoner";
            }
            else if (currentTrack == 2)
            {
                allMusic.clip = clip2;
                allMusic.Play();
                MusicText.text = "Above The Clouds by Paul Keane";
            }
            else if (currentTrack == 3)
            {
                allMusic.clip = clip3;
                allMusic.Play();
                MusicText.text = "Touch Your Soul by Alex Stoner";
            }
            else if (currentTrack == 4)
            {
                allMusic.clip = clip4;
                allMusic.Play();
                MusicText.text = "The Constellation Of Orion by Paul Keane";
            }
        }
    }
}
