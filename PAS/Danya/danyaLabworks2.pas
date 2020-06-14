// 1
uses crt;

var
  F: Text;
  N: string;
  PA: string = 'C:\Files\'; // папка с рабочими файлами

begin
  writeln('Введите название файла'); 
  readln(N);
  Assign(F, PA + N + '.txt');
  writeln('Проверяем файл по пути: ' + PA + N + '.txt');
  if FileExists(PA + N + '.txt') then
  // если файл существует
  begin
    Reset(F); // открытие файла на чтение
    if Eof(F) then // если файл пустой
    begin
      writeln('ЗАПОЛНИТЬ: Указанный файл существует, но пуст...');
      Close(F); // закрываем предыдущий интерфейс
                // с правами только на чтение
      Append(F); // открываем новый интерфейс для записи
      write(F, random(100), ' '); // записываем в файл случайное число
      writeln('Файл успешно заполнен...');
      Close(F); // закрываем интерфейс
    end
    else
    begin
      writeln('ЗАЧИСТКА: В файле имееются данные...');
      Close(F); // закрываем предыдущий интерфейс
                // с правами только на чтение
      Erase(F); // затираем файл
      writeln('Файл успешно зачищен..');
    end;
  end
  else
  begin
    writeln('Создаем новый файл...');
    Rewrite(F); // перезаписываем файл (создаем)
    write(F, random(100), ' '); // записываем в файл случайное число
    writeln('Файл успешно создан...');
    Close(F);
  end;
end.



//2

uses crt;

var
  I: integer;
  F, P, N: Text;
  Source: string = 'C:\Files\src.txt';
  Positives: string = 'C:\Files\positives.txt';
  Negatives: string = 'C:\Files\negatives.txt';

begin
  Assign(F, Source);
  Assign(P, Positives);
  Assign(N, Negatives);
  Append(P);
  Append(N);
  // назначение файлов и путей для всех выходных значений
  if FileExists(Source) then // если src.txt существует
  begin
    Reset(F); //  открываем его на чтение
    while not Eof(F) then // пока чтение не окончено
    begin
      read(F, I); // читаем число 
      if I >= 0 then 
      begin
        writeln('positive');
        write(P, I, ' '); // если число >= 0, то оно 
                            // вписывается в positive.txt
      end
      else
      begin
        writeln('negative');
        write(N, I, ' ');  // если число < 0, то оно 
                            // вписывается в positive.txt
      end;
    end;
  end;
  writeln;
  Close(F); // закрытие интерфейсов
  Close(P);
  Close(N);
end.



