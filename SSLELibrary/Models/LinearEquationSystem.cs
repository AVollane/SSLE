using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLELibrary.Models
{
    public class LinearEquationSystem
    {
        private LinearEquation[] _linearEquations;

        private double[,] _matrix; // Matrix of the equations system

        private double[] _rightPart; // Array of free members

        private uint _rowsCount;
        private uint _columnsCount;

        public LinearEquationSystem(LinearEquation[] linearEquations)
        {
            _linearEquations = linearEquations;

            _rowsCount = (uint)_linearEquations.Length;
            _columnsCount = (uint)_linearEquations[0].Coefficients.Length;

            _matrix = new double[_rowsCount, _columnsCount];
            _rightPart = new double[_rowsCount];

            ToMatrixAndRightPart();
        }

        private void ToMatrixAndRightPart()
        {
            for(int i = 0; i < _rowsCount; i++)
            {
                double[] coeffs = _linearEquations[i].Coefficients;

                double rightElement = _linearEquations[i].FreeMember;
                _rightPart[i] = rightElement;

                for (int j = 0; j < _columnsCount; j++)
                {
                    if(j <= coeffs.Length)
                    {
                        _matrix[i, j] = coeffs[j];
                    }
                    else
                    {
                        _matrix[i, j] = 0;
                    }
                }
            }
        }

        public double[,] Matrix { get { return _matrix; } }
        public double[] RightPart { get { return _rightPart; } }
    }
}
