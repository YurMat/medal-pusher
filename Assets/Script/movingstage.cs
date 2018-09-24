using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingstage : MonoBehaviour {

    [SerializeField]
    private Vector3 _startPosition;
    private Vector3 _targetPosition;
    private float _duration = 1f;
    private float _time = 0;
    //private int _dirFactor = 1;
    private bool _inverse = false;

    // Use this for initialization
    private void Start () {
    }
	
	// Update is called once per frame
	private void Update () {

        _time += Time.deltaTime;
        // 指定時間を過ぎたら向きを逆に
        if (_time >= _duration)
        {
            _time = 0;
            _inverse = !_inverse;
        }

        // 時間を媒介変数として計算（0 - 1）
        float t = _time / _duration;

        if (_inverse)
        {
            transform.position = Vector3.Lerp(_startPosition, _targetPosition, 1f - t);
            Debug.Log(transform.position);
        }
        else
        {
            transform.position = Vector3.Lerp(_startPosition, _targetPosition, t);
            Debug.Log(transform.position);
        }
    }
}
