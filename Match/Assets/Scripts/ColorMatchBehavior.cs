using UnityEngine;

public class ColorMatchBehavior : MatchBehavior
{
    public ColorIDDataList colorIDDataListobj;

    private void Awake()
    {
        idObj = colorIDDataListobj.curentColor;
    }

    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = idObj as ColorID;
        renderer.color = newColor.value;
    }
}
