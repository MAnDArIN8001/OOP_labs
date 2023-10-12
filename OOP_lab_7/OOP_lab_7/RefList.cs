using System;
using System.IO;
using System.Xml.Serialization;

namespace OOP_lab_7 {
    internal class RefList<T> where T : struct {
        private class Item<T> where T : struct {
            private Item<T>? _nextItem;

            private Nullable<T> _value;

            public Item<T>? nextElement {
                get => _nextItem;
                set { _nextItem = value; }
            }

            public Nullable<T> value {
                get => _value;
                set => _value = value;
            }

            public Item() {
                _value = null;
                _nextItem = null;
            }

            public Item(Nullable<T> value) {
                _value = value;
                _nextItem = null;
            }

            public Item(Nullable<T> value, Item<T> nextItem) {
                _value = value;
                _nextItem = nextItem;
            }
        }

        private int _count;

        private const string _dataFilePath = "dataFile.txt";

        private Item<T> _rootElement;
        private Item<T> _lastElement;


        public int count { get => _count; }

        public RefList() {
            _rootElement = null;
        }

        public RefList(T? value) {
            _rootElement = new Item<T>(value);
        }

        public static RefList<T> operator !(RefList<T> thisClass) {
            RefList<T> newList = new RefList<T>();

            Item<T>? tempItem = thisClass._rootElement;

            Nullable<T>[] tempArr = new Nullable<T>[thisClass.count];

            int index = 0;

            while (tempItem != null) {
                tempArr[index] = tempItem.value;
                tempItem = tempItem.nextElement;
                index++;
            }

            for (int i = thisClass.count - 1; i >= 0; i--) {
                newList.Add(tempArr[i]);
            }

            return newList;
        }

        public static RefList<T> operator +(RefList<T> firstList, RefList<T> secondList) {
            RefList<T> tempList = firstList;

            Item<T> tempItem = secondList._rootElement;

            while (tempItem != null) {
                tempList.Add(tempItem.value);
                tempItem = tempItem.nextElement;
            }

            return tempList;
        }

        public static bool operator ==(RefList<T> firstList, RefList<T> secondList)
        {
            if (firstList.count != secondList.count)
                return false;

            Item<T> firstTempItem = firstList._rootElement;
            Item<T> secondTempItem = secondList._lastElement;

            while (firstTempItem.nextElement != null && secondTempItem.nextElement != null) {
                if (!firstTempItem.value.Equals(secondTempItem.value))
                    return false;
            }

            return true;
        }

        public static bool operator !=(RefList<T> firstList, RefList<T> secondList) {
            return !(firstList == secondList);
        }

        public void Add(Nullable<T> value) {
            _count++;

            if (_rootElement == null) {
                _rootElement = new Item<T>(value);

                return;
            }

            Item<T> tempEl = _rootElement;

            while (tempEl.nextElement != null) {
                tempEl = tempEl.nextElement;
            }

            tempEl.nextElement = new Item<T>(value);

            _lastElement = tempEl.nextElement;
        }

        public void RemoveFirst() {
            _rootElement = _rootElement.nextElement;
        }

        public void RemoveLast() {
            try {
                if (_rootElement == null)
                    throw new Exception("there's no root element");

                Item<T> tempItem = _rootElement;

                while (tempItem.nextElement.nextElement != null)
                {
                    tempItem = tempItem.nextElement;
                }

                tempItem.nextElement = null;
            } catch(Exception err) {
                Console.WriteLine(err.Message);
            } finally { }
        }

        public void OutputList() {
            Item<T> tempItem = _rootElement;

            while (tempItem != null) {
                Console.Write(tempItem.value + " ");
                tempItem = tempItem.nextElement;
            }

            Console.WriteLine("\n");
        }
    }
}
