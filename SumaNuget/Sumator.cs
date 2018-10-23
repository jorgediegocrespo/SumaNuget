using System.Linq;

namespace SumaNuget
{
    /// <summary>
    /// Manage diferent sum operations
    /// </summary>
    public class Sumator
    {
        /// <summary>
        /// Sum all the values in a decimal array
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public decimal Suma(decimal[] values)
        {
            return values.Sum();
        }

        /// <summary>
        /// Sum all the values in an int array
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public int Suma(int[] values)
        {
            return values.Sum();
        }
    }
}
