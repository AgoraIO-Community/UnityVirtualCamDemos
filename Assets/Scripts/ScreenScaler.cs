using UnityEngine;

public class ScreenScaler : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float quadHeight = Camera.main.orthographicSize * 2;
        float quadWidth = quadHeight * Screen.width / Screen.height;
        transform.localScale = new Vector3(quadWidth, quadHeight, 1);
    }
}
