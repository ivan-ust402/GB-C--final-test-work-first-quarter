# Итоговая проверочная работа.

## Необходимо:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3, 4 должны быть расположены в разных коммитах)


**Задача**
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**
> ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

> ["1234", "1567", "-2", "computer science"] -> ["-2"]

> ["Russia", "Denmark", "Kazan"] -> [ ]

**Алгоритм решения:** 


*Текстовый*


1. Обработка входных данных пользователя: ввод размерности массива, и элементов массива
2. Создание пустого входного массива на основе введенной пользователем размерности
3. Заполнение элементов входного массива пользователем в цикле, количество итераций равно размерности массива
4. Вывод на экран отформатированного входного массива.
5. Перебор входного массива и нахождение количества элементов массива, у которых длина меньше или равна 3.
6. Создание результирующего пустого массива на основе результата, полученного в пункте 5.
7. Перебор входного массива и запись элементов по условию длина меньше или равна 3 в созданный в пункте 6 результирующий массив.
8. Вывод на экран результирующего массива


*Алгоритм, представленный в псевдокоде основной части программы, отвечающей за получение результирующего массива*


size = 5
inputArray = ["hello", "2", "world", ":-)"]
count = 0
indexInputArray = 0
indexResultArray = 0


while (indexInputArray < size) do
    if (inputArray[indexInputArray].Length <= 3)
        count = count + 1
    indexInputArray = indexInputArray + 1


sizeResultArray = count
resultArray[sizeResultArray]


while (indexInputArray < size) do
    if (inputArray[indexInputArray].Length <= 3)
        resultArray[indexResultArray] = inputArray[indexInputArray]
    indexInputArray = indexInputArray + 1


print(resultArray)