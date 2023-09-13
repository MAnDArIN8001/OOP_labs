using System;

namespace OOP_lab_1
{
    internal class Primitiv {
        private bool _bool = true;
        private Nullable<float> _float;
        private double _double;
        private byte _byte;
        private sbyte _sbyte;
        private ushort _ushort;
        private short _short;
        private uint _uint;
        private nint _nint;
        private nuint _nuint;
        private int _int;
        private long _long;
        private ulong _ulong;
        private char _char;
        private decimal _decimal;

        public Primitiv() {
            Console.Write("enter float value:");
            _float = float.TryParse(Console.ReadLine(), out float result) ? result : null;

            Console.Write("enter double value: ");
            _double = double.Parse(Console.ReadLine());

            Console.Write("enter byte value: ");
            _byte = byte.Parse(Console.ReadLine());

            Console.Write("enter sbyte value: ");
            _sbyte = sbyte.Parse(Console.ReadLine());

            Console.Write("enter ushort value: ");
            _ushort = ushort.Parse(Console.ReadLine());

            Console.Write("enter short value: ");
            _short = short.Parse(Console.ReadLine());

            Console.Write("enter uint value: ");
            _uint = uint.Parse(Console.ReadLine());

            Console.Write("enter int value: ");
            _int = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter long value: ");
            _long = long.Parse(Console.ReadLine());

            Console.Write("enter ulong value: ");
            _ulong = ulong.Parse(Console.ReadLine());

            Console.Write("enter letter: ");
            _char = char.Parse(Console.ReadLine());

            Console.Write("enter decimal value: ");
            _decimal = decimal.Parse(Console.ReadLine());
        }

        public void OutputData() {
            Console.WriteLine($"\n{nameof(_bool)}:{_bool}");
            Console.WriteLine($"{nameof(_float)}:{_float}");
            Console.WriteLine($"{nameof(_byte)}:{_byte}");
            Console.WriteLine($"{nameof(_double)}:{_double}");
            Console.WriteLine($"{nameof(_sbyte)}:{_sbyte}");
            Console.WriteLine($"{nameof(_ushort)}:{_ushort}");
            Console.WriteLine($"{nameof(_short)}:{_short}");
            Console.WriteLine($"{nameof(_uint)}:{_uint}");
            Console.WriteLine($"{nameof(_int)}:{_int}");
            Console.WriteLine($"{nameof(_long)}:{_long}");
            Console.WriteLine($"{nameof(_char)}:{_char}");
            Console.WriteLine($"{nameof(_ulong)}:{_ulong}");
            Console.WriteLine($"{nameof(_decimal)}:{_decimal}");
        }

        public void ExplicitConversion() {
            Console.WriteLine($"\nto int - {_float}+{_double}={(int)(_float + _double)}");
            Console.WriteLine($"float value {_float} to int is {(int)_float}");
            Console.WriteLine($"double value {_double} to short is {(short)_double}");
            Console.WriteLine($"char value {_char} to int is {(int)_char}");
            Console.WriteLine($"double value {_double} to int is {(int)_double}");
        }

        public void UnexplicitConversion() {
            int testInt = _byte;

            object packedInt = testInt;
            Console.WriteLine($"unpacked int - {(int)packedInt}");

            Console.WriteLine($"\nsum of float {_float} and int {_int} is {_float+_int}");
            Console.WriteLine($"sum of double {_double} and long {_long} is {_double+_long}");
            Console.WriteLine($"sum of byte {_byte} and int {_int} is {_byte+_int}");
            Console.WriteLine($"sum of decimal {_decimal} and long is {_decimal + _long}");
            Console.WriteLine($"byte {_byte} to int {testInt}");
        }
    }

}
