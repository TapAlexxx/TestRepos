using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    [SerializeField] private float _offset;
    [SerializeField] private float _damp;

    private Transform _target;

    private void Update()
    {
        if (_target != null)
            UpdatePosition(_target);
    }

    public void UpdatePosition(Transform target)
    {
        Vector3 targetPosition = new Vector3(target.position.x + _offset, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * _damp);
    }

    public void UnTrack()
    {
        _target = null;
    }

    public void Track(Transform target)
    {
        _target = target;
    }
}
