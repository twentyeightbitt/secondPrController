using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 20;
    public int rotationSpeed = 80;
    private bool _gameOver = false;
    private float _vertical;
    private float _horizontal;

    void Start()
    {
        
    }

    void Update()
    {
        if (!_gameOver)
        { 
            _horizontal = Input.GetAxis("Horizontal");
            _vertical = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * Time.deltaTime * speed * _vertical);
            transform.Translate(Vector3.right * Time.deltaTime * speed * _horizontal);
            //transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * _horizontal);
        }
    }
}
