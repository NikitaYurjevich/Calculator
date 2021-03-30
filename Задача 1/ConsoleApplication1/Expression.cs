//В данном классе реализуется парсинг выражения c передачей данных в дочерние классы Operation.

using System;

namespace Calculator
{
    public class Expression
    {
        private string str;
        public int index;

        public Expression(string _string)
        {
            str = _string;
        }

        //Метод, выводящий результат
        public double Calculation()
        {
            index = 0;
            Operation answer = Parse0();
            return answer.Calc();
        }

        //Метод для поиска того или иного символа.
        public bool Find(char ch)
        {
            if (index >= str.Length) return false;
            while (str[index] == ' ') ++index;

            if (str[index] == ch)
            {
                index++;
                return true;
            }
            return false;
        }
        //Следующие три метода служат для парсинга элементов выражения и соответствующих вычислений.
        //Также, здесь реализуется расстановка приоритетов для операторов в необходимом порядке: 
        //действия в скобках, умножение/деление, сложение/вычитание.
        public Operation Parse0()
        {
            Operation result = Parse1();

            while (true)
            {
                if (Find('+')) result = new Plus(result, Parse1());
                if (Find('-')) result = new Minus(result, Parse1());
                return result;
            }
        }

        public Operation Parse1()
        {
            Operation result = Parse2();

            while (true)
            {
                if (Find('*')) result = new Multiply(result, Parse2());
                else if (Find('/')) result = new Divide(result, Parse2());
                else return result;
            }
        }

        public Operation Parse2()
        {
            Operation result = null;

            if (Find('-')) result = new NegativeNumbers(Parse2());
            else if (Find('('))
            {
                result = Parse0();
                if (!Find(')')) Console.WriteLine("Пропущена ')'.");

            }
            else
            {
                double num = 0;
                int _first_digit = index;

                //При нахождении одной цифры, с помощью Substring() находится полная длина числа
                while (index < str.Length && (char.IsDigit(str[index]) || str[index] == '.')) index++;
                try { num = double.Parse(str.Substring(_first_digit, index - _first_digit)); }
                catch { Console.WriteLine("Ошибка."); }
                result = new Numbers(num);
            }
            return result;
        }

    }
}
