using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour

{   
    private const float _stepRatio = 50f;
    private const string horizontalAxis = "Horizontal";

    [SerializeField] private Rigidbody2D _playerRigidbody;

    [Header("Параметры")]
    [SerializeField] private float _horizontalStep;
    private float _direction;

    private void Start()
    {   
        _playerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _direction = Input.GetAxis(horizontalAxis);
    }

    private void FixedUpdate()
    {
        _playerRigidbody.velocity = new Vector2(_horizontalStep * _direction * Time.deltaTime * _stepRatio, _playerRigidbody.velocity.y);
    }
}
