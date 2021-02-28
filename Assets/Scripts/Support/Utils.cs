using System;
using Enums;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Support
{
    public static class Utils
    {
        public static ItemType GetRandomType()
        {
            var values = Enum.GetValues(typeof(ItemType));
            return (ItemType) Random.Range(0, values.Length);
        }

        public static Color GetColor(ItemType itemType)
        {
            switch (itemType)
            {
                case ItemType.Blue:
                    return Color.blue;
                case ItemType.Red:
                    return Color.red;
                case ItemType.Green:
                    return Color.green;
                case ItemType.Cyan:
                    return Color.cyan;
                case ItemType.Magenta:
                    return Color.magenta;
                // case ItemType.White:
                //     return Color.white;
                // case ItemType.Yellow:
                //     return Color.yellow;
                // case ItemType.Black:
                //     return Color.black;
                // case ItemType.Gray:
                //     return Color.gray;
                default:
                    return  Color.clear;
            }
        }
    }
}