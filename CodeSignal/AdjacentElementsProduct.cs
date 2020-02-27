namespace CodeSignal
{
    public class AdjacentElementsProduct
    {
        private int adjacentElementsProduct(int[] inputArray)
        {
            if (inputArray.Length <= 0)
            {
                return inputArray[0];
            }

            var maxProduct = int.MinValue;
            for (var i = 0; i < inputArray.Length - 1; i++)
            {
                var product = inputArray[i] * inputArray[i + 1];
                if (product > maxProduct)
                {
                    maxProduct = product;
                }
            }

            return maxProduct;
        }
    }
}