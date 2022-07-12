using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    public void RotateRight()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }

    public void RotateLeft()
    {
        transform.Rotate(Vector3.down * _rotationSpeed * Time.deltaTime);
    }
}
