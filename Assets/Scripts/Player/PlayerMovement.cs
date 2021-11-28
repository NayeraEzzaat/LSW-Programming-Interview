using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0, 20)]
    public float speed;
    public Rigidbody2D rb;
    public Animator playerAnimator;
    public Animator backAnimator;
    public Animator frontAnimator;
    public Animator leftAnimator;
    public Animator rightAnimator;

    private Vector2 direction;

    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        playerAnimator.SetFloat("Horizontal", direction.x);
        playerAnimator.SetFloat("Vertical", direction.y);
        playerAnimator.SetFloat("Speed", direction.sqrMagnitude);

        backAnimator.SetFloat("Speed", direction.sqrMagnitude);
        frontAnimator.SetFloat("Speed", direction.sqrMagnitude);
        leftAnimator.SetFloat("Speed", direction.sqrMagnitude);
        rightAnimator.SetFloat("Speed", direction.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
