using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem dust;

    private void Awake() {
        var emission = dust.emission;
        emission.enabled = false;
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        var emission = dust.emission;
        emission.enabled = true;

        StartCoroutine(stopSparkDust());
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("1 on trigger");
    }

    IEnumerator stopSparkDust() {
        yield return new WaitForSeconds(.4f);

        var emission = dust.emission;
        emission.enabled = false;
    }
}
