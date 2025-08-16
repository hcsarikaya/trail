using UnityEngine;
using Unity.Cinemachine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public CinemachineDollyCart dollyCart;
    public float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Forward movement
        if (Input.GetMouseButton(0)) // touch/hold click
        {
            dollyCart.m_Speed = speed;
        }
        else
        {
            dollyCart.m_Speed = 0f;
        }
    }
}
