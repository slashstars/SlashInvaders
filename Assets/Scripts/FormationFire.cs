using UnityEngine;

public class FormationFire : MonoBehaviour {

    public float fireIntervalMin = 0.5f;
    public float fireIntervalMax = 2.0f;
    public float fireDelay;
	// Use this for initialization
	void Start () {
        SetDelay();
	}
	
	// Update is called once per frame
	void Update () {
        fireDelay -= Time.deltaTime;

        if(fireDelay <= 0)
        {
            var enemy = GetRandomEnemy();
            if(enemy != null)
            {
                enemy.Fire();
            }
            SetDelay();
        }
	}

    void SetDelay()
    {
        fireDelay = Random.Range(fireIntervalMin, fireIntervalMax);
    }

    EnemyController GetRandomEnemy()
    {
        var enemies = GetComponentsInChildren<EnemyController>();
        if (enemies.Length <= 0) return null;
        else
        {
            return enemies[Random.Range(0, enemies.Length - 1)];
        }
    }
}
