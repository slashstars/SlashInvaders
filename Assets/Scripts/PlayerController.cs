using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 5.0f;
    private float minX = -5.0f;
    private float maxX = 5.0f;    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("EnemyProjectile"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        if (mousePosition.x >= minX && mousePosition.x <= maxX)
        {
            transform.position = Vector2.Lerp(transform.position, new Vector3(mousePosition.x,
                transform.position.y, transform.position.z), speed);
        }

    }
}
