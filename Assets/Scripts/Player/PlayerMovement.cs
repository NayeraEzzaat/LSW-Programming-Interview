using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spriter2UnityDX;

public class PlayerMovement : MonoBehaviour
{
    [Range(0, 20)]
    public float speed;
    public Rigidbody2D rb;
    public EntityRenderer entityRenderer;

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

    private void LateUpdate()
    {
        if (transform.position.y <= -1.1f && entityRenderer.SortingOrder != 12)
        {
            entityRenderer.SortingOrder = 12;
        }
        else if (transform.position.y > -1.1f && entityRenderer.SortingOrder != 8)
        {
            entityRenderer.SortingOrder = 8;
        }
    }
}
