using UnityEngine;
using UnityEngine.InputSystem;

//[RequireComponent(typeof(CharacterController))]
//public class InputAsset : MonoBehaviour
//{
//    private PlayerInput _inputActions;
//    private Vector2 _moveInput;
//    private CharacterController _controller;

//    [Header("Movement Settings")]
//    [SerializeField] private float moveSpeed = 5f;

//    private void Awake()
//    {
//        _inputActions = new PlayerInput();
//        _controller = GetComponent<CharacterController>();
//    }

//    private void OnEnable()
//    {
//        _inputActions.Player.Enable();
//        _inputActions.Player.Move.performed += ctx => _moveInput = ctx.ReadValue<Vector2>();
//        _inputActions.Player.Move.canceled += ctx => _moveInput = Vector2.zero;
//    }

//    private void OnDisable()
//    {
//        _inputActions.Player.Move.performed -= ctx => _moveInput = ctx.ReadValue<Vector2>();
//        _inputActions.Plasyer.Move.canceled -= ctx => _moveInput = Vector2.zero;
//        _inputActions.Player.Disable();
//    }

//    private void Update()
//    {
//        Vector3 move = new Vector3(_moveInput.x, 0, _moveInput.y);
//        _controller.Move(move * moveSpeed * Time.deltaTime);
//    }
//}
