using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS446_Project_LivePrototype
{
    public class MapTokenAddedRemovedEventArgs : EventArgs
    {
        private MapToken token;

        public MapTokenAddedRemovedEventArgs(MapToken token)
        {
            this.token = token;
        }
        public MapToken MapToken
        {
            get { return token; }
        }
    }

    public class MapTokenCollection
    {
        protected List<MapToken> mapTokenList;

        public delegate void MapTokenAddedRemovedEventHandler(object sender, MapTokenAddedRemovedEventArgs a);
        public event MapTokenAddedRemovedEventHandler MapTokenAddedRemovedEvent;

        public MapTokenCollection()
        {
            mapTokenList = new List<MapToken>();
        }

        public int Count
        {
            get { return mapTokenList.Count; }
        }

        public List<MapToken>.Enumerator GetEnumerator()
        {
            return mapTokenList.GetEnumerator();
        }

        public MapToken this[string name]
        {
            get { return mapTokenList.Find(x => x.GetTokenData().Name.Equals(name)); }
            set
            {
                int index = mapTokenList.FindIndex(x => x.GetTokenData().Name.Equals(name));

                if (index >= 0)
                {
                    this[index] = value;
                }
            }
        }

        public MapToken this[int i]
        {
            get { return mapTokenList[i]; }
            set { mapTokenList[i] = value; }
        }

        // Checks if MapToken instance is in collection
        public bool Contains(MapToken mapToken)
        {
            return mapTokenList.Contains(mapToken);
        }

        // Finds token by name
        public bool Contains(string name)
        {
            return mapTokenList.FindIndex(x => x.GetTokenData().Name.Equals(name)) >= 0;
        }

        // returns index by data
        public int IndexOf(MapToken token)
        {
            return mapTokenList.IndexOf(token);
        }

        // returns index by name
        public int IndexOf(string name)
        {
            return mapTokenList.FindIndex(x => x.GetTokenData().Name.Equals(name));
        }

        public bool Add(MapToken token)
        {
            if (mapTokenList.Contains(token)) { return false; }

            mapTokenList.Add(token);

            onMapTokenAddedRemoved(token);

            return true;
        }

        public bool Remove(MapToken token)
        {
            int index = mapTokenList.IndexOf(token);
            if (index == -1) { return false; }

            return Remove(index);
        }

        public bool Remove(int index)
        {
            if (index < 0 || index >= mapTokenList.Count) { return false; }

            MapToken removed = mapTokenList[index];

            mapTokenList.RemoveAt(index);

            onMapTokenAddedRemoved(removed);

            return true;
        }

        // Called when a token is added or removed from the collection
        protected void onMapTokenAddedRemoved(MapToken token)
        {
            MapTokenAddedRemovedEventHandler handler = MapTokenAddedRemovedEvent;

            if (handler != null)
            {
                MapTokenAddedRemovedEventArgs args = new MapTokenAddedRemovedEventArgs(token);
                handler(this, args);
            }
        }
    }
}
