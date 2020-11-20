using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{

    public void ReplayGame()

    {       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 11);

        PlayerPrefs.SetInt("ScoreFile", 0);
        PlayerPrefs.SetInt("Level1Score", 0);
        PlayerPrefs.SetInt("Level2Score", 0);
        PlayerPrefs.SetInt("Level3Score", 0);
        PlayerPrefs.SetInt("Level4Score", 0);
        PlayerPrefs.SetInt("Level5Score", 0);
        PlayerPrefs.SetInt("Level6Score", 0);
        PlayerPrefs.SetInt("Level7Score", 0);
        PlayerPrefs.SetInt("Level8Score", 0);
        PlayerPrefs.SetInt("Level9Score", 0);
        PlayerPrefs.SetInt("Level10Score", 0);
        PlayerPrefs.SetInt("TotalDeaths", 0);

    }
}