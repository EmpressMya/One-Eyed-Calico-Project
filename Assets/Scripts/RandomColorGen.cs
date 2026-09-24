using UnityEngine;

public class RandomColorGenerator : MonoBehaviour
{
    // A list of colors you can assign directly in the Unity Inspector
    public Color[] colorPalette;

    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        
        // Pick and apply a random color from the list on load
        ApplyRandomColor();
    }

    public void ApplyRandomColor()
    {
        // Safety check to ensure you added colors to the array
        if (objectRenderer != null && colorPalette != null && colorPalette.Length > 0)
        {
            // Pick a random index between 0 and the size of your palette
            int randomIndex = Random.Range(0, colorPalette.Length);
            
            // Assign the selected color
            objectRenderer.material.color = colorPalette[randomIndex];
        }
        else
        {
            Debug.LogWarning("Please assign colors to the Color Palette array in the Inspector!");
        }
    }
}
