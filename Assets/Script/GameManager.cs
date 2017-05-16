using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool colis = true;

    [SerializeField]
    private GameObject cube;

    private void Start()
    {
        StartCoroutine(CubeBehaviour());

        instance = this;
    }
    private void Update()
    {

    }

    private IEnumerator CubeBehaviour()
    {

        Debug.Log("Changing cube color");
        if (colis == false)
        {

        }
        if (colis == true)
        {
            while (colis == true)
            {
                yield return ChangeToColor(Color.green, Color.blue); //Waiting until Change color done
                Debug.Log("CubeBehaviour done!");
                yield return ChangeToColor(Color.blue, Color.green); //Waiting until Change color done
                Debug.Log("CubeBehaviour done!");
            }
        }
    }


    public IEnumerator ChangeToColor(Color targetColor, Color targetColor1)
    {
        float t = 0f; //time variable that will hold the time between 0..1

        Renderer renderer = cube.GetComponent<Renderer>();

        Color originalColor = renderer.material.color;

        while (t < 1f) //while time is not over or equal to 1f (100%)
        {
            t += Time.deltaTime; // increase percentage by 1/fps

            Color newColor = Color.Lerp(originalColor, targetColor, t); //Interpolate linearly between original color and target color using T as percentage
            renderer.material.color = newColor; // set new color
            yield return null;// wait for the next frame
        }
        if (targetColor == Color.green)
        {
            Color originalColor1 = renderer.material.color;
            while (t < 1f) //while time is not over or equal to 1f (100%)
            {
                t += Time.deltaTime; // increase percentage by 1/fps

                Color newColor = Color.Lerp(originalColor1, targetColor1, t); //Interpolate linearly between original color and target color using T as percentage
                renderer.material.color = newColor; // set new color
                yield return null;// wait for the next frame
            }
        }
        if (targetColor1 == Color.blue)

        {
            Color originalColor2 = renderer.material.color;
            while (t < 1f) //while time is not over or equal to 1f (100%)
            {
                t += Time.deltaTime; // increase percentage by 1/fps

                Color newColor = Color.Lerp(originalColor2, targetColor, t); //Interpolate linearly between original color and target color using T as percentage
                renderer.material.color = newColor; // set new color
                yield return null;// wait for the next frame
            }

        }
    }
}

    /// <summary>
    /// When current state is changed - state machine will react
    /// </summary>
    /// <returns></returns>

