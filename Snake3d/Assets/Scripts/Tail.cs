using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    [SerializeField] private Tail _tailTemplate;
    [SerializeField] private float _speedChange;
    [SerializeField] private GameObject _headPlayer;
     
    public float Speed { get; private set; }

    private List<GameObject> _tails = new List<GameObject>();

    private void Start()
    {
        _tails.Add(_headPlayer);
    }

    public void Addtail()
    {
        Vector3 newTailPosition = _tails[_tails.Count-1].transform.position;
        Instantiate(_tailTemplate, newTailPosition,Quaternion.identity);
        Speed += _speedChange;
    }
}
