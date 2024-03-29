using UnityEngine;

public class GridCellBehaviour : MonoBehaviour
{
    public Cell cell;
    [HideInInspector]public Transform parent;
    [SerializeField] public bool isValid = true;
    [SerializeField] private float margin = 0.5f;

    public void Initialize()
    {
        SetPosition();
        SetName();
        SetParent();
    }

    private void SetPosition()
    {   
        transform.position = Position();
    }

    private void SetName()
    {
        transform.name = GetName();
    }

    private void SetParent()
    {
        transform.parent = parent;
    }

    private string GetName()
    {
        return "Cell_" + cell.column + "x" + cell.row;
    }

    private Vector2 Position()
    {
        float positionX = transform.position.x + PositionX();
        float positionY = transform.position.y + PositionY();

        return new Vector2(positionX, positionY);
    }

    private float PositionX()
    {
        float sizeX = GetComponent<SpriteRenderer>().size.x;
        return (sizeX + margin) * cell.column;
    }

    private float PositionY()
    {
        float sizeY = GetComponent<SpriteRenderer>().size.y;
        return (sizeY + margin) * cell.row;
    }
}