using UnityEngine;

public class RotateE : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 angularV;
    [SerializeField] private Vector3 torque;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angularV;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            rb.AddTorque(torque);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
