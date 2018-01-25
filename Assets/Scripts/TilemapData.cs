using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections;

public class TilemapData
{
    BoundsInt bounds;
    object[,] data;

    public void setData(int x, int y, object data)
    {
        this.data[x-bounds.xMin, y-bounds.yMin] = data;
    }

    public object getData(int x, int y)
    {
        return data[x-bounds.xMin, y-bounds.yMin];
    }

    public TilemapData(Tilemap map)
    {
        bounds = map.cellBounds;
        data = new object[bounds.size.x, bounds.size.y];
    }

}
