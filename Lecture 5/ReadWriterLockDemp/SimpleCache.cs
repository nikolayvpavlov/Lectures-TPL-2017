using System;
using System.Collections.Generic;
using System.Threading;

namespace ReadWriterLockDemp
{
    class SimpleCache
    {
        private Dictionary<string, string> cacheData;

        private ReaderWriterLockSlim rwLock;

        public string GetData(string key)
        {
            rwLock.EnterUpgradeableReadLock();
            string value;
            if (!cacheData.TryGetValue (key, out value))
            {
                //Get data from db...
                Thread.Sleep(500);//Simulate call to db.
                value = "Some data...";
                //Add the new value to cache.
                AddData(key, value);
            }
            rwLock.ExitUpgradeableReadLock();
            return value;
        }

        public string JustGetData (string key)
        {
            rwLock.EnterReadLock();
            string value = cacheData[key];
            rwLock.ExitReadLock();
            return value;
        }

        public void AddData (string key, string value)
        {
            rwLock.EnterWriteLock();
            cacheData.Add(key, value);
            rwLock.ExitWriteLock();
        }
    }
}
