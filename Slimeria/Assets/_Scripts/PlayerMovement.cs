using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _speed;
    private float _moveSpeed = 5f;
    private float _runSpeed = 7f;
    private Rigidbody2D _rigidbody2D;

    private Vector2 _movement;
    
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _speed = _moveSpeed;
    }

    private void Update()
    {
        _movement.x =  Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + _movement.normalized * _speed * Time.fixedDeltaTime);
    }
}
