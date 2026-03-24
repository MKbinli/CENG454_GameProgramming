using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Something hit me");
            GetComponent<MeshRenderer>().material.color=Color.blue;
        }
    }
}
