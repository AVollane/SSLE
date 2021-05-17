using SSLELibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSLELibrary.Alghoritms;

namespace SSLELibrary.Utils
{
    public static class EquationSolver
    {
        public static double[] Gauss(LinearEquationSystem system)
        {
            GaussAlgoritm gauss = new GaussAlgoritm(system.Matrix, system.RightPart);
            return gauss.XVector;
        }

        public static double[] Iterations(LinearEquationSystem system)
        {
            IterationsAlgoritm iterations = new IterationsAlgoritm(system.Matrix, system.RightPart);
            return iterations.XVector;
        }
    }
}
