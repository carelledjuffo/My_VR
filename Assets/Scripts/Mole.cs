using System.Collections;
using UnityEngine;

public class Mole : MonoBehaviour
{
    // This variable will hold a reference to the Renderer component
    private Renderer moleRenderer;

    // This function is called when the game starts
    void Start()
    {
        // Get the Renderer component attached to this object and store it in moleRenderer
        moleRenderer = GetComponent<Renderer>();
    }

    // This function is called when the mouse hovers over this object
    void OnMouseOver()
    {
        // Make the mole invisible
        moleRenderer.enabled = false;

        // Start the process of making the mole reappear after 2 seconds
        StartCoroutine(ReappearAfterDelay(2));
    }

    // This function makes the mole reappear after a delay
    IEnumerator ReappearAfterDelay(float delay)
    {
        // Wait for the specified number of seconds
        yield return new WaitForSeconds(delay);

        // Make the mole visible again
        moleRenderer.enabled = true;
    }
}