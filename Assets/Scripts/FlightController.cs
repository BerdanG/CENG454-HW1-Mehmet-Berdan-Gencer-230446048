// FlightController.cs
// CENG 454 – HW1: Sky-High Prototype
// Author: Mehmet Berdan Gençer | Student ID: 230446048


using UnityEditor.Callbacks;
using UnityEngine;
public class FlightController : MonoBehaviour
{
    [SerializeField] private float pitchSpeed = 45f; // degrees/second
    [SerializeField] private float yawSpeed = 45f; // degrees/second
    [SerializeField] private float rollSpeed = 45f; // degrees/second
    [SerializeField] private float thrustSpeed = 5f; // units/second
    
    private Rigidbody rb;
    
    
    void Start()
    {
    // Why is freezeRotation needed? Answer in your PDF.
    rb = GetComponent<Rigidbody>();
    rb.freezeRotation = true;
    }
 

    void Update()// or FixedUpdate()
    {
    HandleRotation();
    HandleThrust();
    }


    private void HandleRotation()
    {
    float pitchInput = Input.GetAxis("Vertical");
    float yawInput   = Input.GetAxis("Horizontal");

    float pitchAmount = pitchInput * pitchSpeed * Time.deltaTime;
    float yawAmount   = yawInput   * yawSpeed   * Time.deltaTime;

    transform.Rotate(Vector3.right * pitchAmount);
    transform.Rotate(Vector3.up    * yawAmount);
    }
 
 
    private void HandleThrust()
    {
    // TODO (Task 3-D):
    }
}

