using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerRigidbody2D;
    private float _horizontalStep = 2f;
    private float _verticalStep = 0f;

    private void Start()
    {   
        
        _playerRigidbody2D = GetComponent<Rigidbody2D>();
        _playerRigidbody2D.velocity = new Vector2(_horizontalStep, _verticalStep);
    }

}
