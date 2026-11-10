using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeadBobController : MonoBehaviour
{

    [SerializeField, Range(0, 0.1f)] private float _amplitude = 0.015f;
    [SerializeField, Range(0, 30)] private float _frequency = 10f;

    [SerializeField] Transform _camera = null;
    [SerializeField] Transform _cameraHolder = null;
    [SerializeField] InputActionReference move;

    private Rigidbody rb;
    private float currentSpeed = 0f;
    private Vector3 _startPos;

    void Start()
    {
        rb = GetComponentInParent<Rigidbody>();
    }

    void Update()
    {
        currentSpeed = (move.action.ReadValue<Vector2>()).magnitude;

        CheckMotion();
        ResetPosition();
        //_camera.LookAt(FocusTarget());
    }

    private void PlayMotion(Vector3 motion)
    {
        _camera.localPosition += motion;
    }

    private void CheckMotion()
    {
        if (currentSpeed <= 0.5) return;

        PlayMotion(FootStepMotion());
    }

    private Vector3 FootStepMotion()
    {
        Vector3 pos = Vector3.zero;
        pos.y += Mathf.Sin(Time.time * _frequency) * _amplitude;
        pos.x += Mathf.Cos(Time.time * _frequency / 2) * _amplitude * 2;
        return pos;
    }
    
    private void ResetPosition()
    {
        if (_camera.localPosition == _startPos) return;
        _camera.localPosition = Vector3.Lerp(_camera.localPosition, _startPos, 1 * Time.deltaTime);
    }

    private Vector3 FocusTarget()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y + _cameraHolder.localPosition.y, transform.position.z);
        pos += _cameraHolder.forward * 15.0f;
        return pos;
    }

}
