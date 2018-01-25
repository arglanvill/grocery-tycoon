using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections;

public class GroceryStoreScript : MonoBehaviour
{
    Tilemap layout;
    Tilemap products;
    TilemapData floorMap;

    // Use this for initialization
    void Start()
    {
        // Get the tilemap objects
        Tilemap[] ts = GetComponentsInChildren<Tilemap>();
        foreach (Tilemap t in ts)
        {
            if (t.name == "Objects")
                layout = t;
            else if (t.name == "Products")
                products = t;
        }

        InitializeFloorMap();
    }

    // Update is called once per frame
    void Update()
    {

    }


    // Add location scripts to each tile in the objects map
    void InitializeFloorMap()
    {
        floorMap = new TilemapData(layout);

        foreach (var position in layout.cellBounds.allPositionsWithin)
        {
            TileBase t = layout.GetTile(position);
            if (t != null)
            {
                Location location = Location.GetLocationFromTile(t);
                if (location != null)
                    floorMap.setData(position.x, position.y, location);
            }
        }
    }
}
