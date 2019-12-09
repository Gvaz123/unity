using UnityEngine;
using System.Collections;

public class BGScroller : MonoBehaviour
{
    public GameController gamecon;
    public float scrollSpeed;
    public float tileSizeZ;

    private Vector3 startPosition;

    void Start()
    {
        gamecon = gamecon.GetComponent<GameController>();
        startPosition = transform.position;
    }

    void Update()
    {
        if (gamecon.score >= 100)
        {
            scrollSpeed = -30;
        }
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.forward * newPosition;
    }
}