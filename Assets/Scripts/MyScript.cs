using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // This will appear once in the Console when you press Play
        Debug.Log("Script has started! The GameObject is active.");
    }

    // Update is called once per frame
    void Update()
    {
        // This will spam the Console every frame. 
        // Time.frameCount helps you see the numbers climbing.
        Debug.Log("Updating frame: " + Time.frameCount);
    }
}
