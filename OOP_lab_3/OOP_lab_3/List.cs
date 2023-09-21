using System;

namespace OOP_lab_3 {
    internal class List {
        private class Item {
            private Item _nextItem;

            private Nullable<int> _value;

            public Item nextElement { 
                get => _nextItem;
                set { _nextItem = value; }
            }

            public Nullable<int> value
            {
                get => _value;
                set => _value = value;
            }

            public Item() {
                _value = default;
                _nextItem = null;
            }

            public Item(Nullable<int> value) {
                _value = value;
                _nextItem = null;
            }

            public Item(Nullable<int> value, Item nextItem) {
                _value = value;
                _nextItem = nextItem;
            }
        }

        private Item _rootElement;
        private Item _lastElement;

        private int _count;

        public int count { get => _count; }
        public Nullable<int> rootValue { get => _rootElement.value; }

        public List() {
            _rootElement = null;
        }

        public List(int value) {
            _rootElement = new Item(value);
        }

        public static List operator ! (List thisClass) {
            List newList = new List();

            Item tempItem = thisClass._rootElement;

            Nullable<int>[] tempArr = new Nullable<int>[thisClass.count];

            int index = 0;

            while (tempItem != null) {
                tempArr[index] = tempItem.value;
                tempItem = tempItem.nextElement;
                index++;
            }

            for (int i = thisClass.count-1; i >= 0; i--) {
                newList.Add(tempArr[i]);
            }

            return newList;
        }

        public static List operator + (List firstList, List secondList) {
            List tempList = firstList;

            Item tempItem = secondList._rootElement;

            while(tempItem != null) {
                tempList.Add(tempItem.value);
                tempItem = tempItem.nextElement;
            }

            return tempList;
        }

        public static bool operator == (List firstList, List secondList) {
            if(firstList.count != secondList.count) return false;

            Item firstTempItem = firstList._rootElement;
            Item secondTempItem = secondList._lastElement;

            while(firstTempItem.nextElement != null && secondTempItem.nextElement != null) {
                if (!firstTempItem.value.Equals(secondTempItem.value))
                    return false;
            }

            return true;
        }

        public static bool operator != (List firstList, List secondList) {
            return !(firstList == secondList);
        }

        public void Add(Nullable<int> value) {
            _count++;

            if (_rootElement == null) {
                _rootElement = new Item(value);

                return;
            }

            Item tempEl = _rootElement;

            while(tempEl.nextElement != null) {
                tempEl = tempEl.nextElement;
            }

            tempEl.nextElement = new Item(value);

            _lastElement = tempEl.nextElement;
        }

        public void RemoveFirst() { 
            _rootElement = _rootElement.nextElement;
        }

        public void RemoveLast() {
            if(_rootElement == null) return;

            Item tempItem = _rootElement;

            while(tempItem.nextElement.nextElement != null) { 
                tempItem = tempItem.nextElement;
            }

            tempItem.nextElement = null;
        }

        public void OutputList() {
            Item tempItem = _rootElement;

            while (tempItem != null) {
                Console.Write(tempItem.value + " ");
                tempItem = tempItem.nextElement;
            }

            Console.WriteLine("\n");
        }
    }
}
