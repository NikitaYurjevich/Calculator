//Здесь реализуется обработка данных из класса Expression.

namespace Calculator
{
    //Абстрактный класс, содержащий метод для вычислений на каждом шаге.
    public abstract class Operation
    {
        public abstract double Calc();
    }

    public class Numbers : Operation
    {
        public double number;
        public Numbers(double num)
        {
            number = num;
        }
        public override double Calc()
        {
            return number;
        }
    }

    public class NegativeNumbers : Operation
    {
        public Operation minus;
        public NegativeNumbers(Operation num)
        {
            minus = num;
        }
        public override double Calc()
        {
            return -minus.Calc();
        }
    }
    // Абстрактный класс для операторов.
    abstract class Operator : Operation
    {
        protected Operation left, right;

        public Operator(Operation l, Operation r)
        {
            left = l;
            right = r;
        }
    }

    class Plus : Operator
    {
        public Plus(Operation l, Operation r)
            : base(l, r)
        {

        }

        public override double Calc()
        {
            return left.Calc() + right.Calc();
        }
    }

    class Minus : Operator
    {
        public Minus(Operation l, Operation r)
            : base(l, r)
        {

        }

        public override double Calc()
        {
            return left.Calc() - right.Calc();
        }
    }

    class Multiply : Operator
    {
        public Multiply(Operation l, Operation r)
            : base(l, r)
        {

        }

        public override double Calc()
        {
            return left.Calc() * right.Calc();
        }
    }

    class Divide : Operator
    {
        public Divide(Operation l, Operation r)
            : base(l, r)
        {

        }

        public override double Calc()
        {
            if (right.Calc() == 0)
            {
                System.Console.WriteLine("Ошибка! У нас тут не теория пределов, где-то в знаменателе ноль");
                return 0;
            }
            else return left.Calc() / right.Calc();
        }
    }
}
