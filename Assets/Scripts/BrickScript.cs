using UnityEngine;

public class BrickScript : MonoBehaviour
{
    [SerializeField]
    private UiManagerScript uiManager;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ball") {
            uiManager.IncrementScore();
            Destroy(gameObject);
        }
    }
}
