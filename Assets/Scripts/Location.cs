using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Location {

    public enum Direction
    {
        None = 0,
        North = 1,
        East = 2,
        South = 3,
        West = 4
    };

    public enum LocationType
    {
        Carts = 1,
        CheckoutEntry = 2,
        CheckoutRegister = 3,
        CheckoutExit = 4,
        Fridge = 5,
        Freezer = 6,
        Shelf = 7
    }

    public Direction facing;
    public LocationType type;

    public static Location GetLocationFromTile(TileBase tile)
    {
        Location location;
        tileMappings.TryGetValue(tile.name, out location);
        return location;
    }

    Location(LocationType type, Direction facing)
    {
        this.type = type;
        this.facing = facing;
    }

    static Dictionary<string, Location> tileMappings = new Dictionary<string, Location>();
    static Location()
    {
        tileMappings.Add("Shelf_0", new Location(LocationType.Shelf, Direction.South));
        tileMappings.Add("Shelf_1", new Location(LocationType.Shelf, Direction.East));
        tileMappings.Add("Shelf_2", new Location(LocationType.Shelf, Direction.West));
        tileMappings.Add("Shelf_3", new Location(LocationType.Shelf, Direction.North));
        tileMappings.Add("Fridge_0", new Location(LocationType.Fridge, Direction.South));
        tileMappings.Add("Fridge_1", new Location(LocationType.Fridge, Direction.East));
        tileMappings.Add("Fridge_2", new Location(LocationType.Fridge, Direction.West));
        tileMappings.Add("Fridge_3", new Location(LocationType.Fridge, Direction.North));
        tileMappings.Add("Freezer_0", new Location(LocationType.Freezer, Direction.South));
        tileMappings.Add("Freezer_1", new Location(LocationType.Freezer, Direction.East));
        tileMappings.Add("Freezer_2", new Location(LocationType.Freezer, Direction.West));
        tileMappings.Add("Freezer_3", new Location(LocationType.Freezer, Direction.North));
        tileMappings.Add("Carts_0", new Location(LocationType.Carts, Direction.West));
        tileMappings.Add("Checkout_0", new Location(LocationType.CheckoutEntry, Direction.South));
        tileMappings.Add("Checkout_1", new Location(LocationType.CheckoutRegister, Direction.North));
        tileMappings.Add("Checkout_2", new Location(LocationType.CheckoutExit, Direction.South));
    }

}
