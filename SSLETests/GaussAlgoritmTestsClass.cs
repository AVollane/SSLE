using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSLELibrary.Models;
using SSLELibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSLELibrary.Exceptions;

namespace SSLETests
{
    [TestClass]
    public class GaussAlgoritmTestsClass
    {
        [TestMethod]
        public void GaussAlgoritmTest()
        {
            // Arrange
            double[] firstEquationCoeffs = new double[] { 2, -3 };
            double firstEquationFreeMember = 5;

            double[] secondEquationCoeffs = new double[] { 1, -2 };
            double secondEquationFreeMember = 3;

            LinearEquation equation1 = new LinearEquation(firstEquationCoeffs, firstEquationFreeMember);
            LinearEquation equation2 = new LinearEquation(secondEquationCoeffs, secondEquationFreeMember);

            LinearEquationSystem equationSystem = new LinearEquationSystem(new LinearEquation[] { equation1, equation2 });

            // Expect
            double[] expectedAnswer = new double[] { 1, -1 };

            // Actual
            double[] actualAnswer = EquationSolver.Gauss(equationSystem);

            Assert.AreEqual(expectedAnswer[0], actualAnswer[0], 0.01);
            Assert.AreEqual(expectedAnswer[1], actualAnswer[1], 0.01);
        }

        [TestMethod]
        public void GaussAlgoritmSystemIsWrong()
        {
            // Arrange
            double[] firstEquationCoeffs = new double[] { 4, -3, 2, -1 };
            double firstEquationFreeMember = 8;
            LinearEquation equation1 = new LinearEquation(firstEquationCoeffs, firstEquationFreeMember);

            double[] secondEquationCoeffs = new double[] { 3, -2, 1, -3 };
            double secondEquationFreeMember = 7;
            LinearEquation equation2 = new LinearEquation(secondEquationCoeffs, secondEquationFreeMember);

            double[] thirdEquationCoeffs = new double[] { 5, -3, 1, -8 };
            double thirdEquationFreeMember = 1;
            LinearEquation equation3 = new LinearEquation(thirdEquationCoeffs, thirdEquationFreeMember);

            LinearEquation[] equations = new LinearEquation[] { equation1, equation2, equation3 };
            LinearEquationSystem equationSystem = new LinearEquationSystem(equations);

            double[] answer = new double[equations.Length];

            bool isExceptionThrown = false;

            try
            {
                answer = EquationSolver.Gauss(equationSystem);
            }
            catch (Exception)
            {
                isExceptionThrown = true;
            }
            finally
            {
                Assert.AreEqual(isExceptionThrown, true);
            }
        }
    }
}
