using UnityEngine;

public class starEffect : MonoBehaviour
{
    [SerializeField] private GameObject starEffects;
    [SerializeField] private AudioSource starAudio;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(starEffects, transform.position, Quaternion.identity);
            Destroy(gameObject);
            starAudio.Play();
        }
    }

}
