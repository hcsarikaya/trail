using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using UnityEngine.Splines;
[ExecuteInEditMode]
public class splineTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private SplineContainer splineContainer;
    [SerializeField]
    int splineIndex;
    [Range(0f, 1f)]
    private float time;

    float3 position;
    float3 tangent;
    float3 normal;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        splineContainer.Evaluate(splineIndex,time, out position, out tangent, out normal);
    }

   #if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Handles.matrix = transform.localToWorldMatrix;
        Handles.SphereHandleCap(0, position, Quaternion.identity, 1f, EventType.Repaint);
    }
    # endif
}
