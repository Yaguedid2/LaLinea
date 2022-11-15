using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject DrawingFrame;
    public GameObject okButton, clearButton;
    public static ObjectManager instance;
    public GameObject drawingArea,realDrawingArea;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
