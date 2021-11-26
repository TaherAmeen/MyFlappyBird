using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Control : MonoBehaviour {

    public static Control instance;
    public GameObject Birdy;
    private bool isDead = false;
    public GameObject gameOvertext;
    public Text scoreText;
    private float Score = 0;
    // Use this for initialization
    void Awake () {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        if (isDead && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdDied()
    {
        isDead = true;
        gameOvertext.SetActive(true);
    }

    public void BirdScored()
    {
        if (isDead)
            return;
        Score++;
        scoreText.text = "Score: " + Score.ToString();
    }
    public bool getIsDead()
    {
        return isDead;
    }
}
