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
            GaussAlghoritm gauss = new GaussAlghoritm(system.Matrix, system.RightPart);
            return gauss.XVector;
        }

        public static double[] Iterations(LinearEquationSystem system)
        {
            IterationsAlghoritm iterations = new IterationsAlghoritm(system.Matrix, system.RightPart);
            return iterations.XVector;
        }
    }
}
