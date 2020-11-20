using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelComplete : MonoBehaviour {

    

    public void LoadNextLevel ()
    {

        PlayerPrefs.SetInt("ScoreFile", 0);
        PlayerPrefs.SetInt("CloseCall", 1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("TotalDeaths", PlayerPrefs.GetInt("TotalDeaths") + GameManager.Deathcount);
        GameManager.Deathcount = 0;


    }
}
