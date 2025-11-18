using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Transform[] patrolPoints;
    [SerializeField] float speed, playerChaseThreshold, patrolThreshold;

    int patrolPointIndex = 1;
    Transform playerTransform;
    
    void Start()
    {
        transform.position = patrolPoints[0].position;
        playerTransform = FindAnyObjectByType<PlayerController>().transform;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, playerTransform.position) <= playerChaseThreshold)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[patrolPointIndex].position, speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, patrolPoints[patrolPointIndex].position) <= patrolThreshold)
            {
                if (patrolPointIndex == 1)
                {
                    patrolPointIndex = 0;
                }
                else
                {
                    patrolPointIndex = 1;
                }
            }
        }

    }
}
