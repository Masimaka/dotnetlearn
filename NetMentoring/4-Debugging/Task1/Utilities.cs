using System;

namespace Task1
{
    public static class Utilities
    {
        /// <summary>
        /// Sorts an array in ascending order using bubble sort.
        /// </summary>
        /// <param name="numbers">Numbers to sort.</param>
        public static void Sort(int[] numbers)
        {
            // Проверка на то что не переда null
            if (numbers == null)
            {
                // trow механиз ошибки
                // new ArgumentNullException тип ошибки
                throw new ArgumentNullException(nameof(numbers)); // Unhandled exception. System.ArgumentNullException: Value cannot be null. (Parameter 'numbers')
                //throw new ArgumentNullException(); // Unhandled exception. System.ArgumentNullException: Value cannot be null.
            }
            int temp;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
        }


        /// <summary>
        /// Searches for the index of a product in an <paramref name="products"/> 
        /// based on a <paramref name="predicate"/>.
        /// </summary>
        /// <param name="products">Products used for searching.</param>
        /// <param name="predicate">Product predicate.</param>
        /// <returns>If match found then returns index of product in <paramref name="products"/>
        /// otherwise -1.</returns>
        public static int IndexOf(Product[] products, Predicate<Product> predicate)
        {   
            if (products == null || predicate == null)
            {
                throw new ArgumentNullException(); 
            }
            for (int i = 0; i < products.Length; i++)
            {
                var product = products[i];
                Console.WriteLine($"Product Name: {product.Name} {product.Price}");


                var predicateResult = predicate(product);
                Console.WriteLine($"Predicate for {product.Name} {product.Price} Result {predicateResult}");
                if (predicate(product))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
