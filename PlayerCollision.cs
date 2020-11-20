using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;





    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
   
    }



        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Obstacle"))
                PlayerPrefs.SetInt("CloseCall", (PlayerPrefs.GetInt("CloseCall") + 1));

        }

}
