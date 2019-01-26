using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Целочисленные переменные
            byte bt = 4;
            sbyte sbt = -101;
            short shrt = 22041;
            ushort ushrt = 0;
            int int1 = 311;
            uint unt = 4294967295;
            long lng = 555555555555;
            ulong ulng = 676841;
            //Переменные с плавающей точкой
            float flt = 3.14f;
            double dbl = -345.21;
            //Символьный тип
            char chr = '\n';
            Console.WriteLine("Целочисленные переменные:" + "\n" + "Тип byte: " + bt + "\n" + "Тип sbyte: " + sbt + 
                "\n" + "Тип short: " + shrt +
                "\n" + "Тип ushort: " + ushrt + "\n" + "Тип int: " + int1 + "\n" + "Тип uint: " + unt + "\n" +
                "Тип long: " + lng + "\n" + "Тип ulong: " + ulng + "\n" +
                "------------------------------------------" + "\n" +
                "Переменные с плавающей точкой:" + "\n" + "Тип float: " + flt + "\n" + "Тип double: " + dbl
                + "------------------------------------------" + "\n" + "Тип char: " + chr);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Размеры и типы переменных");
            Console.WriteLine("Переменная byte:" + "\n" + "Размер: " + sizeof(byte) + "\n" + "Тип: " + typeof(byte) + "\n" + "\n"
                + "Переменная sbyte:" + "\n" + "Размер: " + sizeof(sbyte) + "\n" + "Тип: " + typeof(sbyte) + "\n" + "\n"
                + "Переменная short:" + "\n" + "Размер: " + sizeof(short) + "\n" + "Тип: " + typeof(short) + "\n" + "\n"
                + "Переменная ushort:" + "\n" + "Размер: " + sizeof(ushort) + "\n" + "Тип: " + typeof(ushort) + "\n" + "\n"
                + "Переменная int:" + "\n" + "Размер: " + sizeof(int) + "\n" + "Тип: " + typeof(int) + "\n" + "\n"
                + "Переменная uint:" + "\n" + "Размер: " + sizeof(uint) + "\n" + "Тип: " + typeof(uint) + "\n" + "\n"
                + "Переменная long:" + "\n" + "Размер: " + sizeof(long) + "\n" + "Тип: " + typeof(long) + "\n" + "\n"
                + "Переменная ulong:" + "\n" + "Размер: " + sizeof(ulong) + "\n" + "Тип: " + typeof(ulong) + "\n" + "\n"
                + "Переменная float:" + "\n" + "Размер: " + sizeof(float) + "\n" + "Тип: " + typeof(float) + "\n" + "\n"
                + "Переменная double:" + "\n" + "Размер: " + sizeof(double) + "\n" + "Тип: " + typeof(double) + "\n"
                + "Переменная char:" + "\n" + "Размер: " + sizeof(char) + "\n" + "Тип: " + typeof(char) + "\n");
            short one = bt;
            int two = bt;
            long three = bt;
            short four = (short)int1;
            long five = int1;
            long six = unt;
            float seven = (float)dbl;
            double eight = flt;
            int nine = chr;
            char ten = (char)int1;
            char eleven = (char)bt;
            Console.WriteLine("Приведение типов:");
            Console.WriteLine("a) byte(" + bt + ") -> short = " + one + "\n" +
                "b) byte(" + bt + ") -> int = " + two + "\n" +
                "c) byte(" + bt + ") -> long = " + three + "\n" +
                "d) int(" + int1 + ") -> short = " + four + "\n" +
                "e) int(" + int1 + ") -> long = " + five + "\n" +
                "f) uint(" + unt + ") -> long = " + six + "\n" +
                "g) double(" + dbl + ") -> float = " + seven + "\n" +
                "h) float(" + flt + ") -> double = " + eight + "\n" +
                "i) char(" + chr + ") -> int = " + nine + "\n" +
                "j) int(" + int1 + ") -> char = " + ten + "\n" +
                "k) byte(" + bt + ") -> char = " + eleven + "\n");

        }
    }
}
