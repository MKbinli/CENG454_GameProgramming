using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{   [SerializeField] Transform player;
    Vector3 playerPosition;
    [SerializeField] float missileSpeed = 10f;
    void Start()
    {
        playerPosition = player.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    private void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    private void MoveToPlayer()
    {
        transform.position = 
        Vector3.MoveTowards(transform.position, playerPosition, missileSpeed * Time.deltaTime);
    }
}
