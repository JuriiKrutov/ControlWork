# Control work

## Задача
написать программу, которая из иммеющегося массива строк формирует массив строк, длинна которых меньше или равна 3 символа. 
первоночальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами

## Решение
1. Создаем два массива. Один массив с данными, второй пустой.
2. Пишем цикл внутри которого проверяем каждый эллемент первого массива на соответствие условию (длинна эллемента <= 3)
3. При выполнении условия записываем этот эллемент во второй массив. Увеличиваем счетчик count служащий индексом второго массива.