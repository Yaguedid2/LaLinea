using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingToJson : MonoBehaviour
{
    public static DrawingToJson instance;
    public float[] mousePosition = new float[2];
   

    public List<List<List<float>>> imageStrokes = new List<List<List<float>>>();
    private void Awake()
    {
        instance = this;
    }
}
