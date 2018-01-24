using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections;

public class TilemapDataScript : ScriptableObject
{
    BoundsInt bounds;
    ScriptableObject[,] data;

    public static TilemapDataScript CreateInstance(Tilemap map)
    {
        TilemapDataScript that = ScriptableObject.CreateInstance<TilemapDataScript>();
        that.init(map);
        return that;
    }

    public void setData(int x, int y, ScriptableObject data)
    {
        this.data[x-bounds.xMin, y-bounds.yMin] = data;
    }

    public ScriptableObject getData(int x, int y)
    {
        return data[x-bounds.xMin, y-bounds.yMin];
    }

    void init(Tilemap map)
    {
        bounds = map.cellBounds;
        data = new ScriptableObject[bounds.size.x, bounds.size.y];
    }

}
