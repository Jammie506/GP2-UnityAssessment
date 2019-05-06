using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float bSpeed = 10f;
    float Speed;
    public float Sprint = 5f;
    private Vector3 _movement;
    private Rigidbody _playerRigidBody;

 

    private void Awake()
    {
        _playerRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Speed = Sprint;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Speed = bSpeed;
        }
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Move(horizontal, vertical);
    }
    
    private void Move(float horizontal, float vertical)
    {
        _movement = (vertical* transform.forward) + (horizontal* transform.right);
        _movement = _movement.normalized* Speed * Time.deltaTime;
        _playerRigidBody.MovePosition(transform.position + _movement);
    }
}
