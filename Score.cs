using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public Text multiplier;
    private int scoref;

    




    void Update ()
    {
        multiplier.text = PlayerPrefs.GetInt("CloseCall").ToString() + "X";

        int scoref = (int)player.transform.position.z;


            if (scoref  > PlayerPrefs.GetInt("ScoreFile"))
            {
                scoreText.text = (scoref.ToString());
                PlayerPrefs.SetInt("ScoreFile", (scoref));
                PlayerPrefs.Save();
            }

            else
            {

                scoreText.text = PlayerPrefs.GetInt("ScoreFile").ToString();
            }
        

       


    }
}
