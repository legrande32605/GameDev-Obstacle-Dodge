using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] float moveSpeed = 10;


    public void Start()
    {
    }

    public void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float ySpeed = 0f;
        float zSpeed = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xSpeed,ySpeed,zSpeed);
    }
}
