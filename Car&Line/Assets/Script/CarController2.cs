using UnityEngine;

public class CarController2 : MonoBehaviour
{
    [SerializeField] private float speed = 20;
    [SerializeField] private Rigidbody2D carRigidbody2D;
    [SerializeField] private AudioSource audioPlay;
    public bool toGo = false;
    private void Start()
    {
        carRigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Move();
    }
    public void Move()
    {
        if (toGo)
        {
            carRigidbody2D.AddForce(Vector2.left);
        }

    }

    public void GoEnable()
    {
        toGo = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spike"))
        {
            Destroy(gameObject);
        }
    }
}
