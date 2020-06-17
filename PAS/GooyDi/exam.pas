// # 1 - Create and display 5x5 matrix
program CountArray;
const N = 5; // размерность
const M = 5; // массива
var A: array [1..N, 1..M] of integer; // объявление массива по его размерам
var i, j: integer; // счетчики
begin
    for i := 1 to N do // иттерация по N-стороне 2D-массива
    begin
        for j := 1 to M do // иттерация по M-стороне 2D-массива
        begin
          A[i, j] := random(2); // заполнение текущего значения 2D-массива случайным значением в пределе сотни
        end;
    end;
    writeln; // пустая строка
    for i:=1 to N do // двумерная иттерация для вывода двумерного массива...
     begin  
        for j:=1 to M do  
           write(a[i,j]:2,' ');  // вывод
        writeln;   // пустая линия
     end;
end.

// # 1 - 5x5 Main Diaginal Max
program MaxDiagArray;
const N = 5; // размерность
const M = 5; // массива
var A: array [1..N, 1..M] of integer; // объявление массива по его размерам
var i, j, mx: integer; // счетчики
begin
    for i := 1 to N do // иттерация по N-стороне 2D-массива
    begin
        for j := 1 to M do // иттерация по M-стороне 2D-массива
        begin
          A[i, j] := random(2); // заполнение текущего значения 2D-массива случайным значением в пределе сотни
        end;
    end;
    writeln; // пустая строка
    mx := A[1, 1];
    for i:=1 to N do // иттерация по вертикали
     begin  
        if a[i,i]>mx then mx:=a[i,i]; // поиск максимального элемента
     end;
    writeln('Максимальный элемент на главной диагонали=',mx);
    for i:=1 to N do // двумерная иттерация для вывода двумерного массива...
     begin  
        for j:=1 to M do  
           write(a[i,j]:2,' ');  // вывод
        writeln;   // пустая линия
     end;
end.