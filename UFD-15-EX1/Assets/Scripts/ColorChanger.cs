using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {
    float red = 0.225f;
    float green = 0.54f;
    float blue = 0.37f;
    float alpha = 0.11f;
    public float colorArgument = 0.01f;
    Material m_Material;
    // Use this for initialization
    void Start () {
        m_Material = GetComponent<Renderer>().material;
        m_Material.color = new Color(red, green, blue, alpha);
    }

    // Update is called once per frame
    void Update () {
        ColorCorection();

    }
    void ColorCorection()
    {
        m_Material.color = new Color(red + colorArgument, green + colorArgument, blue + colorArgument, alpha);
    }
}
