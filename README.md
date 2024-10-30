# Typy-generyczne
W C# typy generyczne pozwalają na definiowanie klas, interfejsów i metod, które mogą działać na dowolnych typach danych. Dzięki nim można tworzyć bardziej elastyczne i wielokrotnego użytku struktury danych i algorytmy, zachowując jednocześnie typowanie statyczne. Poniżej opisano, jak tworzy się typy generyczne w C#.

1. Generyczne klasy
Aby stworzyć generyczną klasę, należy użyć nawiasów ostrokątnych (<>) po nazwie klasy, wewnątrz których określa się typ parametrów generycznych. Taki parametr generyczny można później wykorzystywać w całej klasie.


W powyższym przykładzie klasa Box<T> przechowuje obiekt dowolnego typu T. Można ją użyć do przechowywania różnych typów danych

2. Generyczne metody
Generyczne metody pozwalają na definiowanie metod, które mogą działać na różnych typach, niezależnie od tego, jaki typ został użyty w klasie. Parametry generyczne definiuje się po nazwie metody.





W C# słowo kluczowe ref jest używane do przekazywania argumentów metod przez referencję. Zwykle parametry są przekazywane przez wartość, co oznacza, że metoda dostaje kopię wartości parametru. Kiedy jednak używasz ref, metoda może modyfikować zmienną, którą przekazano, i te zmiany będą widoczne poza metodą, ponieważ pracuje bezpośrednio na oryginalnej zmiennej.



Kiedy przekazujesz parametr z użyciem ref, oznacza to, że metoda otrzymuje dostęp do oryginalnej zmiennej (a nie tylko do jej kopii), więc wszelkie zmiany wprowadzone do tego parametru wewnątrz metody będą widoczne poza nią.


3. Generyczne interfejsy
Generyczne interfejsy działają podobnie jak klasy. Parametry generyczne umożliwiają definiowanie interfejsów, które mogą pracować na różnych typach.


4. Ograniczenia (Constraints) w typach generycznych
C# pozwala na stosowanie ograniczeń, które pozwalają zawęzić typy, jakie mogą być używane jako argumenty generyczne. Ograniczenia są definiowane przy użyciu słowa kluczowego where.

Typowe ograniczenia to:

where T : class – typ musi być klasą (referencją).
where T : struct – typ musi być typem wartościowym (np. int, bool).
where T : new() – typ musi mieć domyślny konstruktor.
where T : BaseClass – typ musi dziedziczyć po podanej klasie.



Zadanie 

Napisz algorytm sortowania przez wstawiania przy użyciu typów generycznych tak aby można było podawać mu liczby całkowite lub zmiennoprzecinkowe.
Napisz algorytm do porównywania dwóch różnych typów generycznych (Pamiętaj o zabezpieczeniu algorytmu do różnych przypadków).
