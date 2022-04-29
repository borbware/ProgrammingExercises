using UnityEngine;

public class SetColorImpostor : MonoBehaviour
{
    Renderer _renderer;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }
    void SetColorTo(Color color)
    {
        _renderer.material.SetColor("_Color", Color.black);
    }
}
