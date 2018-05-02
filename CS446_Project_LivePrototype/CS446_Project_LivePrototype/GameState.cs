using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CS446_Project_LivePrototype
{
    // Stores data that is shared between classes and UI elements
    public class GameState
    {
        public MainForm MainForm;
        public MapControl MapControl;
        public string MapImageFile = null;
        public Image MapImage = null;
        public Image MapImageSized = null;
        public float MapGridThickness = 1;
        public int MapGridAlpha = 255;
        public float MapGridHorzOffset = 0.0f;
        public float MapGridVertOffset = 0.0f;
        public float MapGridScale = 10.0f;
        public float MapViewZoom = 1.0f;
        public float MapViewPosX = 0.0f;
        public float MapViewPosY = 0.0f;
    }
}
