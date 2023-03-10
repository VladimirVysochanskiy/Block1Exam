# Итоговая проверочная работа.  

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого   блока обучения на программе разработчик. Мы должны убедиться что базовое знакомство с it  прошло успешно.  
  
Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы  необходимо:  
1. Создать репозиторий на GitHub  
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части,   если вы выделяете ее в отдельный метод)  
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)  
4. Написать программу, решающую поставленную задачу  
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что   все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Задача:** Написать программу, которая из имеющегося массива строк  формирует массив из строк, длина которых Меньше либо равна 3 символа.  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться  коллекциями, лучше обойтись исключительно массивами.  

**Примеры:**

* ["hello", "2", "world", ":)"]-> ["2", ":-)"]  
* ["1234", "1567", "-2", "computer science"] > ["-2*]  
* ["Russia", "Denmark", "Kazan"]> ]]  

# Решение

Консольное приложение разделено на два блока.
В первом блоке реализована возможность выбора способа наполнения массива автоматически либо вручную.  
  
  ### Автоматическая генерация
Автоматическое наполнение генерирует строки случайной длины от 1 символа до значения указанного в переменной **strLenMax** и  
наполняет их случайными символами из кодовой таблицы.  
Случайные символы выбираются путем генерации случайных чисел соответствующих диапазону кодов из кодовой таблицы. Диапазон  значений для генерации задаётся переменными **chMin** и **chMax**.  

* З3 - 127  По умолчанию используется символы из основной кодовой таблицы ASCII.  
* 61 - 122  Латинский алфавит в нижнем регистре.  
* 1040 - 1103 Русский алфавит в обоих регистрах.  
* По желанию можно выбрать и другие диапазоны для генерации.  
    
Длина генерируемого массива ограничена 20 ячейками. Этот параметр задан переменной **arrLen**
  
  ### Ручная генерация   

Ручное наполнение массива предлагает пользователю вводить любые комбинации строк. Прервать наполнение можно нажатием кнопки
**Ввод (Enter)** в пустой строке.  
  
  В результате получаем массив **myArray** который передается во второй блок для обработки.

  ### Выборка срок заданной длины  
  
После создания массива программа просматривает все ячейки и выбирает со строками заданной длины.
Длина строки для выборки задается переменными **selStrLenMin**  и **selStrLenMax**
Выбранные строки переносятся в новый массив **MyArraySelected**, который выводится на печать.  




