using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OverlapTest : MonoBehaviour
{
    [SerializeField]
    private OverlapBox _overlapBoxSample = default;

    private void Start()
    {
        _overlapBoxSample.Initialize(transform);
    }
    private void Update()
    {
        _overlapBoxSample.Update();
    }
    private void OnDrawGizmos()
    {
        _overlapBoxSample.OnDrawGizmos(transform);
    }
}

