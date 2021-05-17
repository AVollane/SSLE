using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSLELibrary.Models;
using SSLELibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLETests
{
    [TestClass]
    public class GaussAlghoritmTestsClass
    {
        [TestMethod]
        public void GaussAlghoritmTest()
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
    }
}
