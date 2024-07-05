using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerRigidbody;
    [Header("Параметры")]
    [SerializeField] private float _horizontalStep;

    private void Start()
    {   
        _playerRigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _playerRigidbody.velocity = new Vector2(_horizontalStep, _playerRigidbody.velocity.y);
        
    }

}
