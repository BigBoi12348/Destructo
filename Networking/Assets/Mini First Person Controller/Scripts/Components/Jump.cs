using UnityEngine;
using Photon.Pun;

public class Jump : MonoBehaviour
{
    Rigidbody rb;
    public float jumpStrength = 2;
    public event System.Action Jumped;
    PhotonView view;

    [SerializeField, Tooltip("Prevents jumping when the transform is in mid-air.")]
    GroundCheck groundCheck;


    void Reset()
    {
        // Try to get groundCheck.
        groundCheck = GetComponentInChildren<GroundCheck>();
    }
    private void Start()
    {
        //view.GetComponent<PhotonView>();
    }

    void Awake()
    {
        // Get rigidbody.
        rb = GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        
            // Jump when the Jump button is pressed and we are on the ground.
            if (Input.GetButtonDown("Jump") && (!groundCheck || groundCheck.isGrounded))
            {
                rb.AddForce(Vector3.up * 100 * jumpStrength);
                Jumped?.Invoke();
            }
        
       
    }
}
