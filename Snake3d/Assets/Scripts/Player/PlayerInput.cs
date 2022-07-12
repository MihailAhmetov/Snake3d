using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMover _mover;

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
            _mover.RotateRight();

        if (Input.GetAxis("Horizontal") < 0)
            _mover.RotateLeft();
    }
}