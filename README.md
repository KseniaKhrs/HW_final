# **Описание решения задачи Итоговой проверочной работы**

*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.*


## Ход программы

Пользователю предлагается ввести число, представляющее собой размер желаемого массива.
Далее с помощью метода *GetArray* создается массив строк, значения которых снова предлагается ввести пользователю.

После, вызывается метод *NMarkArray*, который из полученного массива и заданного числа формирует новый массив из строк, длина которых меньше или равна этому числу (в рамках нашей задачи задано число 3).

Полученный в результате работы метода массив отображается пользователю с помощью цикла.



***В ходе решения задачи был прописаны два метода:**

    string[] GetArray(int size)

    string[] NMarkArray (int n, string[] array)

Более подробно с принципом работы методов можно ознакомиться ниже.

## Метод **GetArray** 
Метод принимает число в формате int и создает массив заданного размера. После создания массива, метод, с помощью цикла, запрашивает элементы массива (строки) у пользователя и возвращает полученный массив.

## Метод **NMarkArray** 
Метод принимает число в формате int и массив строк. Далее, с помощью цикла, метод проверяет каждый элемент массива на соответствие условию (длина строки меньше или равна числу, которое было задано методу). Каждый раз, когда элемент удовлетворяет условию, отмечается в счетчике *count*. 

Полученное число *count* используется в качестве размера нового массива.

Метод снова проходит циклом по заданному массиву: каждый раз, когда строка удовлетворяет нужному условию, значение данного элемента присваивается элементу нового массива. *(Для этого введена дополительная переменная* j, *которая используется, как индекс элемента нового массива и увеличивается только в том случае, если условие выполнено).*

Метод возвращает новый массив строк.