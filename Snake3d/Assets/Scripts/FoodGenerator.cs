using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : MonoBehaviour
{
    [SerializeField] private Food _foodTemplate;
    [SerializeField] private float _xSize;
    [SerializeField] private float _zSize;

    private Vector3 _foodPosition;
    private Food _foodCurrent;

    private void Update()
    {
        if( _foodCurrent == null)
        {
            GeneratePosition();
            _foodCurrent = Instantiate(_foodTemplate, _foodPosition, Quaternion.identity);
        }
    }

    private void GeneratePosition()
    {
        _foodPosition = new Vector3(Random.Range(-_xSize, _xSize), 0.3f, Random.Range(-_zSize, _zSize));
    }
}
