# NET.W.2016.01.Lahovskaya.05

Task1. Разработать класс, позволяющий выполнять вычисления НОД по алгоритму Евклида для двух, трех и т.д. целых чисел.
Методы класса помимо вычисления НОД должны определять значение времени, необходимое для выполнения расчета. 
Добавить к разработанному классу методы, реализующие алгоритм Стейна (бинарный алгоритм Евклида) для расчета НОД двух, трех и т.д. целых чисел.
Методы должны также  определять значение времени, необходимое для выполнения расчетов. 
Разработать unit-тесты для тестирования методов данного типа.

Task2. Реализовать алгоритм “пузырьковой” сортировки непрямоугольного целочисленного массива 
(методы сортировки класса System.Array не использовать) таким образом, чтобы была возможность упорядочить строки матрицы: 
- в порядке возрастания (убывания) сумм элементов строк матрицы;
- в порядке возрастания (убывания) максимальных элементов строк матрицы;
- в порядке возрастания (убывания) минимальных элементов строк матрицы.
В класс с алгоритмом сортировки не прямоугольной матрицы, принимающим как компаратор делегат добавить метод, принимающий как параметр интерфейс IComparer<int[]>, инкапсулирующий логику сравнения строк матрицы.

Task3. Task2 с использованием интерфейса вместо делегатов. В класс с алгоритмом сортировки не прямоугольной матрицы, принимающим как компаратор интерфейс IComparer<int[]> добавить метод, принимающий как параметр делегат-компаратор, инкапсулирующий логику сравнения строк матрицы.
