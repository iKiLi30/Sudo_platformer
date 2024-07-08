using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour

{   
    private const float _StepRatio = 50f;
    private const string _HorizontalAxis = "Horizontal";
    private const string _Ground = "Ground";

    [SerializeField] private Rigidbody2D _playerRigidbody;

    private float _horizontalStep = 8f;
    private float _direction;
    private float  _jumpForce = 500f;
    private bool _isJump;
    private bool _isGround;
    
    private void Start()
    {   
        _playerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _direction = Input.GetAxis(_HorizontalAxis);
        if (_isGround && Input.GetKeyDown(KeyCode.Space))
        {
            _isJump = true;
        } 
    }

    private void FixedUpdate()
    {
        _playerRigidbody.velocity = new Vector2(_horizontalStep * _direction * 
            Time.deltaTime * _StepRatio, _playerRigidbody.velocity.y);
        if (_isJump)
        {
            _playerRigidbody.AddForce(new Vector2(0, _jumpForce));
            _isJump = false;
            _isGround = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(_Ground)) 
            _isGround = true;
    }
}
