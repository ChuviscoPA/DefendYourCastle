using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

[ExecuteAlways]
public class CordinateLabel : MonoBehaviour
{

    TMP_Text label;

    Vector2Int cordinates = new Vector2Int();

    private void Awake()
    {
        label = GetComponent<TextMeshPro>();
        DisplayCordinates();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!Application.isPlaying)
        {
            DisplayCordinates();
            ConvertCordinatesToName();
        }

    }

    void ConvertCordinatesToName()
    {
        transform.parent.name = cordinates.ToString();
    }

    void DisplayCordinates()
    {
        cordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        cordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);

        label.text = cordinates.x + "," + cordinates.y;

       
    }
}
