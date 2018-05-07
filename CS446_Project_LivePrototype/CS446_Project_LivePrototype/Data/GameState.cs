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
        public string MapImageFile = null;
        public TokenLibraryCollection TokenLibrary = new TokenLibraryCollection();
        public MapTokenCollection ActiveTokens = new MapTokenCollection();
    }
}
