using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;





    public void Start() { }
    


        void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {


            gameManager.CompleteLevel();
            
            
        }
        
    }
}
