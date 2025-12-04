using UnityEngine;
using UnityEngine.Animations;

public class imrpovMovement : MonoBehaviour
{
    public float moveSpeed;
    public Transform orientation;
    float horizontalInupt;
    float verticalInupt;
    Vector3 movedirection;
    Rigidbody rb;

    Animator animator;

    public float grounddrag;
    public float playerheight;
    public LayerMask whatisground;
    bool grounded;

    public float groundistance;

    Vector3 forwardfacing;


    void Start()
    {
       rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
       rb.freezeRotation = true;
    }
    private void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerheight * 0.5f + 0.2f, whatisground);
        myinput();
        speedcontrol();
        if (grounded)
            rb.linearDamping = grounddrag;
        else
            rb.linearDamping = 0;
        RaycastHit hit;
        Vector3 castposition = transform.position;
        castposition.y = 0;
        if (Physics.Raycast(castposition, -transform.up, out hit, Mathf.Infinity, whatisground))
        {
            if (hit.collider != null)
            {
                Vector3 moveposition = transform.position;
                moveposition.y = hit.point.y + groundistance;
                transform.position = moveposition;
            }
            if (movedirection != Vector3.zero)
            {
                transform.forward = movedirection;
            }
        }
    
                }
    private void FixedUpdate()
    {
        moveplayer();
    }
   
    private void myinput()
    {
        horizontalInupt = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Move", horizontalInupt);
        verticalInupt = Input.GetAxisRaw("Vertical");

    }
    private void moveplayer()
    {
        movedirection = orientation.forward * verticalInupt+ orientation.right * horizontalInupt;
        rb.AddForce(movedirection.normalized* moveSpeed* 10f, ForceMode.Force);
    }
    private void speedcontrol()
    {
        Vector3 flatvel = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        if(flatvel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatvel.normalized * moveSpeed;
            rb.linearVelocity = new Vector3(limitedVel.x, rb.linearVelocity.y, limitedVel.z);
        }
    }
    private void wheretoface()
    {
      
    }


}
