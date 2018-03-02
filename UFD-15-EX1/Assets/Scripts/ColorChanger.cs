using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {
    float red = 0.0f;
    float green = 0.0f;
    float blue = 0.0f;
    float alpha = 0.11f;
    public float colorArgument = 0.01f;
    bool grow = true;
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
        
        if (grow == true){ 
        red += colorArgument;
        blue += colorArgument;
        green += colorArgument;
        m_Material.color = new Color(red + colorArgument, green + colorArgument, blue + colorArgument, alpha);
            if (red + blue + green >= 3)
            {
                grow = false;
            }
        }
        else if (grow == false){ 
            red -= colorArgument;
            blue -= colorArgument;
            green -= colorArgument;
            m_Material.color = new Color(red + colorArgument, green + colorArgument, blue + colorArgument, alpha);
            if (red + blue + green <=0)
            {
                grow = true;
            }
        }
    }
}
