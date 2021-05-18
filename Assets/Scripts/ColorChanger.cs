using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    TextMesh textMesh;
    [SerializeField]
    float PingPongLength = 1;

    MeshRenderer meshRenderer;

    private void Awake()
    {
        textMesh = GetComponent<TextMesh>();
        if (textMesh == null)
        {
            meshRenderer = GetComponent<MeshRenderer>();	
	    }
    }


    void Update()
    {
        if (textMesh != null)
        {
            textMesh.color = Color.Lerp(Color.blue, Color.red, Mathf.PingPong(Time.time, PingPongLength));
        } else
        if (meshRenderer != null)
        { 
	        meshRenderer.material.color = Color.Lerp(Color.green, Color.red, Mathf.PingPong(Time.time, PingPongLength));
        }
    }

}
