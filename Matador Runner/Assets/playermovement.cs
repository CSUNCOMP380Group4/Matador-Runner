using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {

    public float MovementSpeed = 1;
    public float JumpForce = 1;
    private Rigidbody2D _rigidbody;
    public Animator animator;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update() {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        animator.SetFloat("Speed", Mathf.Abs(movement));

        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true);
        }

        Vector3 characterScale = transform.localScale;
        if(Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -7;
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 7;
        }
        transform.localScale = characterScale;
    }
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }
}
