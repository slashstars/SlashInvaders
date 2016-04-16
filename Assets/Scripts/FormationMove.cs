using UnityEngine;

public class FormationMove : MonoBehaviour {

    public float moveDownInterval = 4.0f;
    private float moveDownDelay;
    public float moveDownStep = 0.5f;

    public float speed = 2.0f;

    Rigidbody2D _rigidbody;

    void Start()
    {
        moveDownDelay = moveDownInterval;
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        _rigidbody.velocity = Vector3.left * speed;
    }

    public void MoveRight()
    {
        _rigidbody.velocity = Vector3.right * speed;
    }

    void Update()
    {
        moveDownDelay -= Time.deltaTime;
        if(moveDownDelay <= 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - moveDownStep, transform.position.z);
            moveDownDelay = moveDownInterval;
        }
    }
}
