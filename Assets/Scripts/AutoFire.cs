using UnityEngine;

public class AutoFire : MonoBehaviour {

    public GameObject projectile;
    public float fireInterval = 0.6f;
    private float fireDelay;

	// Use this for initialization
	void Start () {
        fireDelay = fireInterval;
        
	}
	
	// Update is called once per frame
	void Update () {
        fireDelay -= Time.deltaTime;

        if (fireDelay <= 0.0f && projectile != null)
        {
            var newProjectile = (GameObject)Instantiate(projectile, transform.position + new Vector3(0, 0.5f, 0), transform.rotation);
            newProjectile.SetActive(true);
            newProjectile.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,2,0), ForceMode2D.Impulse);
            fireDelay = fireInterval;
        }
	}
}
