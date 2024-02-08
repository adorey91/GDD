using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCircle : MonoBehaviour
{

    public LineRenderer circleRenderer;
    public int resolution = 100;  // Résolution du cercle
    public float radius = 1f;     // Rayon du cercle

    void Start()
    {
        DrawCircle();
    }

    void DrawCircle()
    {
        circleRenderer.loop = true;  // Cela ferme le cercle
        circleRenderer.positionCount = resolution;

        float angle = 0f;

        for (int i = 0; i < resolution; i++)
        {
            float x = radius * Mathf.Cos(angle);
            float y = radius * Mathf.Sin(angle);

            circleRenderer.SetPosition(i, new Vector3(x, y, 0f));

            angle += 2f * Mathf.PI / resolution;
        }
    }
}