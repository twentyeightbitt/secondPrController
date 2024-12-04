using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public int speed = 20;
    public int coins = 0;
    public int rotationSpeed = 80;
    private bool _gameOver = false;
    private float _vertical;
    private float _horizontal;
    public TextMeshProUGUI coinsText;

    void Start()
    {
        //coinsText = GetComponent
        //if ()
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

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter" + other.name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            coins++; //++ - операция инкремента, которая увеличивает значение числовой переменной на 1. -- - это декремент, она обратная.
            Destroy(collision.gameObject);
            coinsText.text = "Coins: " + coins;
        }
        if (collision.gameObject.CompareTag("Grow"))
        {
            transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            Destroy(collision.gameObject);
        }
    }
    



}
    



