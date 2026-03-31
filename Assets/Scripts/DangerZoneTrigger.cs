using Unity.VisualScripting;
using UnityEngine;

public class DangerZoneTrigger : MonoBehaviour
{
    [SerializeField] GameObject missile;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("You've entered th danger zone!!");
            missile.SetActive(true);

        }
    }
}
