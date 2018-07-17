using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour {

    public GameObject HSPanel;
    private Animator anim;
    public Text HSText;
    //public AudioClip clip;
    //AudioSource audio;

    // Use this for initialization
    void Start() {
        anim = HSPanel.GetComponent<Animator>();
        gameOver();
        getHighScore();
        //audio = GetComponent<AudioSource>();
        //audio.Play();
    }

    // Update is called once per frame
    void Update() {

    }

    public void playGame()
    {
        SceneManager.LoadScene("gr");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void playHSPanel()
    {
        anim.SetTrigger("playHSAnim");
    }

    public void backHSPanel()
    {
        anim.SetTrigger("goBack");
    }

    public void gameOver()
    {
        PlayerPrefs.SetString("HighScore", "0");
    }

    private void getHighScore()
    {
        HSText.text = PlayerPrefs.GetString("HighScore");
    }

}
