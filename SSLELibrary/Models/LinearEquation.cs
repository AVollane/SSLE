using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLELibrary.Models
{
    /// <summary>
    /// Is a linear equation
    /// </summary>
    public class LinearEquation
    {
        private double[] _coefficients; // Array of factors

        private double _freeMember; // Free member

        /// <summary>
        /// Build a linear equation by coefficients array and free member
        /// </summary>
        /// <param name="coefficients">Array of equation coefficients</param>
        /// <param name="freeMember">Free member that staying after the equal sign</param>
        public LinearEquation(double[] coefficients, double freeMember)
        {
            _coefficients = coefficients;
            _freeMember = freeMember;
        }

        /// <summary>
        /// Returns the array of coefficients of equation
        /// </summary>
        public double[] Coefficients
        {
            get { return _coefficients; }
        }

        /// <summary>
        /// Returns the free member
        /// </summary>
        public double FreeMember
        {
            get { return _freeMember; }
        }
    }
}
