using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS446_Project_LivePrototype
{
    public class TokenAddedRemovedEventArgs : EventArgs
    {
        private TokenData data;

        public TokenAddedRemovedEventArgs(ref TokenData data)
        {
            this.data = new TokenData(ref data);
        }
        public TokenData TokenData
        {
            get { return data; }
        }
    }

    public class TokenLibraryCollection
    {
        protected List<TokenData> tokenDataList;

        public delegate void TokenAddedRemovedEventHandler(object sender, TokenAddedRemovedEventArgs a);
        public event TokenAddedRemovedEventHandler TokenAddedRemovedEvent;

        public TokenLibraryCollection()
        {
            tokenDataList = new List<TokenData>();
        }

        public int Count
        {
            get { return tokenDataList.Count; }
        }

        public List<TokenData>.Enumerator GetEnumerator()
        {
            return tokenDataList.GetEnumerator();
        }

        public TokenData this[string name]
        {
            get { return tokenDataList.Find(x => x.Name.Equals(name));  }
            set
            {
                int index = tokenDataList.FindIndex(x => x.Name.Equals(name));

                if (index >= 0)
                {
                    this[index] = value;
                }
            }
        }

        public TokenData this[int i]
        {
            get { return tokenDataList[i]; }
            set { tokenDataList[i] = value; }
        }

        // Finds token by data
        public bool Contains(ref TokenData data)
        {
            return tokenDataList.Contains(data);
        }

        // Finds token by name
        public bool Contains(string name)
        {
            return tokenDataList.FindIndex(x => x.Name.Equals(name)) >= 0;
        }

        // returns index by data
        public int IndexOf(ref TokenData data)
        {
            return tokenDataList.IndexOf(data);
        }

        // returns index by name
        public int IndexOf(string name)
        {
            return tokenDataList.FindIndex(x => x.Name.Equals(name));
        }

        public bool Add(ref TokenData data)
        {
            if (tokenDataList.Contains(data)) { return false; }

            tokenDataList.Add(data);

            onTokenAddedRemoved(ref data);

            return true;
        }

        public bool Remove(ref TokenData data)
        {
            int index = tokenDataList.IndexOf(data);
            if (index == -1) { return false; }

            return Remove(index);
        }

        public bool Remove(int index)
        {
            if (index < 0 || index >= tokenDataList.Count) { return false; }

            TokenData removed = tokenDataList[index];

            tokenDataList.RemoveAt(index);

            onTokenAddedRemoved(ref removed);

            return true;
        }

        // Called when a token is added or removed from the collection
        protected void onTokenAddedRemoved(ref TokenData token)
        {
            TokenAddedRemovedEventHandler handler = TokenAddedRemovedEvent;

            if (handler != null)
            {
                TokenAddedRemovedEventArgs args = new TokenAddedRemovedEventArgs(ref token);
                handler(this, args);
            }
        }
    }
}
