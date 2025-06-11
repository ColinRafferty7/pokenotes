using UnityEngine;

public class NotesInput : MonoBehaviour
{
    [SerializeField] Object leftClick;
    [SerializeField] Transform canvas;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(leftClick, Input.mousePosition, Quaternion.identity, canvas);
        }
    }
}
