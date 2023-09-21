using System;

namespace OOP_lab_3 {
    internal static class ListExtensions {
        public static void RemovePart(this List list, int newLength) {
            if (newLength > list.count) return;

            for (int i = 0; i < newLength; i++) {
                list.RemoveLast();
            }
        }

        public static Nullable<int> GetSumOfList(this List list) {
            Nullable<int> tempResult = 0;

            List listClone = list;

            while(listClone.rootValue != null) {
                tempResult += listClone.rootValue;
                listClone.RemoveFirst();
            }

            return tempResult;
        }
    }
}
