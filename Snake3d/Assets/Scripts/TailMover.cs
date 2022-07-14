using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMover : MonoBehaviour
{
    private GameObject _tailTarget;
    private Tail _tail;

    private void Start()
    {
        _tail = GetComponent<Tail>();
    }

    private void Update()
    {
        transform.LookAt(_tailTarget.transform);

        transform.position = Vector3.Lerp(transform.position, _tailTarget.transform.position, _tail.Speed * Time.deltaTime);
    }
}
