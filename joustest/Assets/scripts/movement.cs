using UnityEngine;

public class movement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float turnspeed=10;
    public float movemnentspeed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * horizontalInput* movemnentspeed);
        transform.Translate(-Vector3.right * Time.deltaTime * verticalInput* movemnentspeed);
        transform.Rotate(Vector3.up * horizontalInput * turnspeed * Time.deltaTime);
    }
}
