using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IMath
    {
        int Sum(int a, int b);
        int Subtract(int a, int b);
      

        int Multiply(int a, int b);

      
    }

    public interface IComplexMath
    {
        int Divide(int a, int b);
        int Modulo(int a, int b);
        double Power(int a, int b);
    }

    public class SimpleMath : IMath
    {
        public int Multiply(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Sum(int a, int b)
        {
            throw new NotImplementedException();
        }
    }

    public class ComplexMath : IMath, IComplexMath
    {
        public int Divide(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Modulo(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int a, int b)
        {
            throw new NotImplementedException();
        }

        public double Power(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Sum(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
