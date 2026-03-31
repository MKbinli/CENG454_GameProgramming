using UnityEngine;
using UnityEngine.SceneManagement;

public class HealtScript : MonoBehaviour
{
    int HealthOfPlayer=100;
    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Obstacle" :
                Debug.Log("Hit the obstacle");
                HealthOfPlayer -=10;
                Debug.Log(HealthOfPlayer);
                collision.gameObject.tag="Hit";
                int currScene = SceneManager.GetActiveScene().buildIndex;
                int nextScene= currScene+1;
                int totalSceneNumber = SceneManager.sceneCountInBuildSettings;
                if (nextScene == totalSceneNumber)
                {
                    nextScene=0;
                }
                SceneManager.LoadScene(nextScene);
                break;
            case "Friendly" :
                Debug.Log("Nothing happened");
                break;
            default:
                int currentScene = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentScene);
                break;
            
        }        
        /*if (collision.gameObject.tag == "Obstacle")
        {
            HealthOfPlayer -=10;
            Debug.Log(HealthOfPlayer);
            collision.gameObject.tag="Hit";
        }
        */
        
    }
}
