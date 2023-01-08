using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HelperTest : MonoBehaviour
{
    [SerializeField]
    private OverlapBox _overlapBoxSample = default;
    [SerializeField]
    private Raycast _raycastSample = default;

    private void Start()
    {
        _overlapBoxSample.Initialize(transform);
        _raycastSample.Initialize(transform);
    }
    private void Update()
    {
        _overlapBoxSample.Update();
        _raycastSample.Update();
    }
    private void OnDrawGizmos()
    {
        _overlapBoxSample.OnDrawGizmos(transform);
        _raycastSample.OnDrawGizmo(transform);
    }
}

