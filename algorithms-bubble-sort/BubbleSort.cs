namespace algorithms_bubble_sort
{
    public class BubbleSort
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                    }
                }
            }
        }
        
        public void RecursiveSort(int[] array, int length)
        {
            if (length < 1) return;

            for (int i = 0; i < length; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int aux = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = aux;
                }
            }

            RecursiveSort(array, length - 1);
        }
    }
}