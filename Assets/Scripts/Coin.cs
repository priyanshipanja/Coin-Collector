using UnityEngine;

public class Coin : MonoBehaviour
{
    [Header("Rotation & Bobbing Settings")]
    [SerializeField] private float rotationSpeed = 120f;
    [SerializeField] private float bobAmplitude = 0.2f;
    [SerializeField] private float bobFrequency = 2.5f;
    [SerializeField] private int scoreValue = 1;

    private Vector3 startPosition;
    private bool isCollected = false;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Continuous smooth rotation around Y axis
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime), Space.World);

        // Subtle vertical floating/bobbing effect
        float newY = startPosition.y + Mathf.Sin(Time.time * bobFrequency) * bobAmplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    public void Collect()
    {
        if (isCollected) return;
        isCollected = true;

        if (GameManager.Instance != null)
        {
            GameManager.Instance.AddScore(scoreValue);
        }

        // Spawn collection particle / effect if present
        Destroy(gameObject);
    }
}
