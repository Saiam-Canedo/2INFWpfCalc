using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculatrice
{
    /// <summary>
    /// Simple addition class
    /// </summary>
    public class Addition
    {
        private double val1;
        private double val2;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="v1">First Value</param>
        /// <param name="v2">Second value</param>
        public Addition(double v1,double v2)
        {
            this.val1 = v1;
            this.val2 = v2;
        }
        /// <summary>
        /// Add the two setted values
        /// </summary>
        /// <returns>result of sum</returns>
        public double Addtionne()
        {
            return val1 + val2;
        }
        /// <summary>
        /// set first value
        /// </summary>
        /// <param name="val">value</param>
        public void setVal1(double val)
        {
            this.val1 = val;
        }
        /// <summary>
        /// get first value
        /// </summary>
        /// <returns>first value</returns>
        public double getVal1()
        {
            return this.val1;
        }
        /// <summary>
        /// set second value
        /// </summary>
        /// <param name="val">value</param>
        public void setVal2(double val)
        {
            this.val2 = val;
        }
        /// <summary>
        /// get second value
        /// </summary>
        /// <returns>second value</returns>
        public double getVal2()
        {
            return this.val2;
        }

        public string Affiche()
        {
            return "The sum of " + val1.ToString() 
                + " and " + val2.ToString() 
                + " is " + (Addtionne()).ToString();
        }
    }
}
