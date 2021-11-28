using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float ballForce = 200;

    bool gameStarted = false;

    private void Awake() {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && !gameStarted) {
            transform.SetParent(null);

            rb.isKinematic = false; // disable kinematic system
            rb.AddForce(new Vector2(ballForce, ballForce));

            gameStarted = true;
        }
    }
}
