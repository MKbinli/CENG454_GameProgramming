using UnityEngine;

public class HealtScript : MonoBehaviour
{
    int HealthOfPlayer=100;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            HealthOfPlayer -=10;
            Debug.Log(HealthOfPlayer);
            collision.gameObject.tag="Hit";
        }

        
    }
}
