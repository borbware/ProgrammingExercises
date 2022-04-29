using UnityEngine;

public class SetColor : MonoBehaviour
{
    Renderer _renderer;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }
    void SetColorToRed()
    {
        _renderer.material.SetColor("_Color", Color.red);
    }

    void SetColorTo(Color color, Vector3 position)
    {
        _renderer.material.SetColor("_Color", color);
        transform.position += position;
    }
    void SetColorToRandom()
    {
        _renderer.material.SetColor("_Color", new Color(
            Random.Range(0f,1f),
            Random.Range(0f,1f),
            Random.Range(0f,1f)
        ));
    }


}
