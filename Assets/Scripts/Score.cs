using UnityEngine;

public class Score : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter2D()
    {
        GameManager.Instance.IncreaseScore();
        audioSource.Play();
    }
}
