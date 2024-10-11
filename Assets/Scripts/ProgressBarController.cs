using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBarController : MonoBehaviour
{
    public Slider progressBar;
    public float progressIncrement = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UpdateProgressBar(progressIncrement);
        }
    }

    void UpdateProgressBar(float increment)
    {
        progressBar.value += increment;

        if (progressBar.value >= progressBar.maxValue)
        {
            progressBar.value = progressBar.maxValue;
            Debug.Log("Bravo tu as réussi !");
        }
        else {
            
        }
    }
}
