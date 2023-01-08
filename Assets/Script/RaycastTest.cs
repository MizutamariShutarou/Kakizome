using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    [SerializeField]
    private Raycast _raycastSample = default;

    private void Start()
    {
        _raycastSample.Initialize(transform);
    }
    private void Update()
    {
        _raycastSample.Update();
    }
    private void OnDrawGizmos()
    {
        _raycastSample.OnDrawGizmo(transform);
    }
}

