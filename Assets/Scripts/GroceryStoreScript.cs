using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections;

public class GroceryStoreScript : MonoBehaviour
{
    Tilemap layout;
    Tilemap products;
    TilemapDataScript floorMap;

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
        floorMap = TilemapDataScript.CreateInstance(layout);

        foreach (var position in layout.cellBounds.allPositionsWithin)
        {
            TileBase t = layout.GetTile(position);
            if (t != null)
            {
                LocationScript location = LocationScript.CreateInstance<LocationScript>();
                if (t.name == "Shelf_0")
                    location.facing = LocationScript.Direction.South;
                else if (t.name == "Shelf_1")
                    location.facing = LocationScript.Direction.East;
                else if (t.name == "Shelf_2")
                    location.facing = LocationScript.Direction.West;
                else if (t.name == "Shelf_3")
                    location.facing = LocationScript.Direction.North;
                else if (t.name == "Carts_0")
                    location.facing = LocationScript.Direction.West;
                else if (t.name == "Checkout_0")
                    location.facing = LocationScript.Direction.South;
                else if (t.name == "Checkout_1")
                    location.facing = LocationScript.Direction.South;
                else if (t.name == "Checkout_2")
                    location.facing = LocationScript.Direction.South;
                else if (t.name == "Fridge_0")
                    location.facing = LocationScript.Direction.South;
                else if (t.name == "Fridge_1")
                    location.facing = LocationScript.Direction.East;
                else if (t.name == "Fridge_2")
                    location.facing = LocationScript.Direction.West;
                else if (t.name == "Fridge_3")
                    location.facing = LocationScript.Direction.North;
                else if (t.name == "Freezer_0")
                    location.facing = LocationScript.Direction.South;
                else if (t.name == "Freezer_1")
                    location.facing = LocationScript.Direction.East;
                else if (t.name == "Freezer_2")
                    location.facing = LocationScript.Direction.West;
                else if (t.name == "Freezer_3")
                    location.facing = LocationScript.Direction.North;

                floorMap.setData(position.x, position.y, location);
            }
        }
    }
}
