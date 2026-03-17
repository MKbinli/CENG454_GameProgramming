using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed= 10.0f;
    [SerializeField] float flyingSpeed= 100.0f;
    Rigidbody rb;
    AudioSource audioSource;
    [SerializeField] InputAction flyObject;
    [SerializeField] InputAction wingsAngle;

    void OnEnable()
    {
        flyObject.Enable();
        wingsAngle.Enable();
    }
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        audioSource=GetComponent<AudioSource>();

    }
    /*
    void Update()
    {   
        float xAxisValue=Input.GetAxis("Horizontal");
        float zAxisValue= Input.GetAxis("Vertical");
        transform.Translate(xAxisValue*Time.deltaTime*moveSpeed,0,zAxisValue*Time.deltaTime*moveSpeed);
        if (flyObject.IsPressed())
        {
            rb.AddForce(0,1*Time.deltaTime*flyingSpeed,0);
        }
        
    }*/
     void FixedUpdate()
    {
        HandleMovement();
        HandleFly();
        float angle=wingsAngle.ReadValue<float>();
        Debug.Log("Angle value : "+ angle);
    }

    private void HandleMovement()
    {
        float xAxisValue = Input.GetAxis("Horizontal");
        float zAxisValue = Input.GetAxis("Vertical");
        transform.Translate(xAxisValue * Time.fixedDeltaTime * moveSpeed, 0, zAxisValue * Time.fixedDeltaTime * moveSpeed);
    }

    private void HandleFly()
    {
        if (flyObject.IsPressed())
        {
            rb.AddForce(0, 1 * Time.fixedDeltaTime * flyingSpeed, 0);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            
        }
        else
        {
            audioSource.Stop();
        }
    }
}
