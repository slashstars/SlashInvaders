using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameObject projectile;
    private FormationMove formation;
    public float minX = -5.0f;
    public float maxX = 5.0f;

    void Start()
    {
        formation = GetComponentInParent<FormationMove>();
    }

    public void Fire()
    {
        var newProjectile = (GameObject)Instantiate(projectile, transform.position - new Vector3(0, 0.5f, 0), transform.rotation);
        newProjectile.SetActive(true);
        newProjectile.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, -2, 0), ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerProjectile"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (transform.position.x <= minX)
        {
            formation.MoveRight();
        }
        else if(transform.position.x >= maxX)
        {
            formation.MoveLeft();
        }

    }
}
