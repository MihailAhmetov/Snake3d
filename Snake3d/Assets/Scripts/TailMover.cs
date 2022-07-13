using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMover : MonoBehaviour
{
    private float _speed;
    private GameObject _tailTarget;

    private void Update()
    {
        transform.LookAt(_tailTarget.transform);

        transform.position = Vector3.Lerp(transform.position, _tailTarget.transform.position, _speed * Time.deltaTime);
    }
}
