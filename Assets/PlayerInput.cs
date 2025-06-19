
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float HInput;
    public float VInput;

    PlayerMover playerMover;

    private void Start()
    {
        playerMover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        HInput = Input.GetAxis("Horizontal");
        VInput = Input.GetAxis("Vertical");

        Vector2 moveInput = new Vector2(HInput, VInput);
        playerMover.Move(moveInput);

    }
}