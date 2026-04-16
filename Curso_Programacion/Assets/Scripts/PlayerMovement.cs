using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.2f;
    public Vector3 direction = Vector3.forward;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
