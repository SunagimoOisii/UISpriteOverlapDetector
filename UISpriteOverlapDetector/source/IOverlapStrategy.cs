using UnityEngine;

public interface IOverlapStrategy
{
    //OBB対応のためRectではなくVector2を使用(Rectは回転しないため)
    bool Overlap(Vector2[] a, Vector2[] b);
}