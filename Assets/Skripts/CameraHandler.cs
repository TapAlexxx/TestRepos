using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _offset;
    [SerializeField] private float _damp;

    private void Update()
    {
        if (_player.IsAlive)
            transform.position = Vector3.Lerp(transform.position, new Vector3(_player.transform.position.x + _offset, transform.position.y, transform.position.z), Time.deltaTime * _damp);
    }
}
