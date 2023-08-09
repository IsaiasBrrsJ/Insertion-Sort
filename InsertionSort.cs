      static void InsertionSor(ref int[] insertionSort)
        {
            int array = insertionSort.Length;
            int i = 0;
           
            while (i < array)
            {   
                int current = insertionSort[i];
                int j = i - 1;

                while (j >=0 && insertionSort[j] > current)
                {
                    insertionSort[j+1] = insertionSort[j];
                    j--;
                }
                insertionSort[j+1] = current;
                i++;
            }

        }
