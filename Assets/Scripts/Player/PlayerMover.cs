using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector2 _inputDirection;

    [Header("Movement Parameters")]
    [field: SerializeField] public float MoveSpeed { get; private set; }
    [SerializeField] private float _turnSpeed;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Move(_inputDirection);
    }
    

    public void OnMove(InputAction.CallbackContext context)
    {
        _inputDirection = context.ReadValue<Vector2>();
    }

    public void Move(Vector2 direction)
    {
        float moveX = direction.x;
        float moveZ = direction.y;

        transform.Rotate(Vector3.up, moveX * _turnSpeed * Time.deltaTime, Space.World);
        
        _rigidbody.linearVelocity = transform.forward * (moveZ * MoveSpeed);
    }
}
