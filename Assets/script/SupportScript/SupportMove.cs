using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportMove : MonoBehaviour
{
    public Transform objectToFollow;
    private Vector3 deltaPosition;

    private void Start()
    {
        deltaPosition = transform.position - objectToFollow.position;
    }

    private void Update()
    {
        transform.position = objectToFollow.position + deltaPosition;
    }
}
