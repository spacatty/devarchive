## IF1

```pascal
var
N : integer;

begin
N := 4;

if N mod 2 = 0 then
begin
  N := N + 1;
end;

writeln(IntToStr(N));

end.
```

## IF28

```pascal
var
N : integer;

begin
  N := 2000;
  if N mod 4 <> 0 then writeln('365')
  else if N mod 100 <> 0 then writeln('366')
  else if N mod 400 <> 0 then writeln('365')
  else writeln(366)
end.
```

## FOR16

```pascal
var
  A,Rez:Real;
  N, i :Integer;
begin
  Write('Введите A: ');
  Readln(A);
  Write('Введите N: ');
  Readln(N);
  Rez:=1;
  For i:=1  to N do
   begin
    Rez:=Rez*A;
    Writeln(Rez);
   end;
end.
```

## FOR35

```pascal
var
Ak,Ak1,Ak2, Ak3 :Real;
N, i :Integer;
begin
 Write('Введите N: ');
 Readln(N);
 Writeln('Значения функции:');
 Writeln('A(1)=1');
 Writeln('A(2)=2');
 Writeln('A(3)=3');
 Ak1:=1;
 Ak2:=2;
 Ak3:=3;
 For i:=4  to N do
  begin
   Ak:=Ak3+Ak2-2*Ak1;
   Writeln('A(',i,')=',Ak);
   Ak1:=Ak2;
   Ak2:=Ak3;
   Ak3:=Ak;
  end;
end.
```

## FOR24

```pascal
program For24;
var
  X,Rez,factorial,pow:Real;
  N, i :Integer;
begin
  Write('Введите X: ');
  Readln(X);
  Write('Введите N: ');
  Readln(N);
  Rez:=1;
  pow:=1;
  factorial:=1;
  For i:=1  to 2*N do
   begin
    factorial:=factorial*i;
    pow:=pow*X;
    if (i mod 2) = 0 then
     begin
      pow:=pow*(-1);
      Rez:=Rez+pow/factorial;
     end;
   end;
  Writeln(Rez);
end.
```

## WHILE27

```pascal
var
  N,F,F1,F2,K :Integer;
begin
  Write('Введите число N: ');
  Readln(N);
  F1:=1;
  F2:=1;
  F:=0;
  K:=2;
  while F < N do
   begin
    inc(K,1);
    F:=F2+F1;
    F2:=F1;
    F1:=F;
   end;
  Writeln(k);
end.
```

## WHILE28

```pascal
var
  k:Integer;
  Ak1,Ak,e:Real;
begin
  Write('Введите e: ');
  Readln(e);
  Ak1:=0;
  Ak:=2;
  K:=1;
  while Abs(Ak-Ak1) >= e do
   begin
    Inc(k,1);
    Ak1:=Ak;
    Ak:=2+1/Ak1;
   end;
  Writeln('k=', k, ', A(k-1)=',Ak,', A(k)=',Ak1);
end.
```

## WHILE4

```pascal
var
  n:integer;
begin
  writeln('¬видите число n: ');
  read(n);
  repeat
    n:=n div 3
  until n<=3;
  if n=3
  then
    writeln('True')
  else
    writeln('False');
end.
```

## STRING50

```pascal
var
 S,S2:String;
 i,poz:integer;


begin
  Write('S: ');
  Readln(S);

  i:=1;
  S2:='';
  poz:=pos(' ',S);
  While (poz<>0) do
   begin
    if poz=1 then delete(S,1,1);
    if poz>1 then
     begin
      S2:=copy(S,1,poz-1)+' '+S2;
      Delete(S,1,poz);
     end;
    poz:=pos(' ',S);
   end;
  S2:=S+' '+S2;
  Writeln(S2);
end.
```

## STRING68

```pascal
const
   LowerCase = ['a'..'z'];

var
   Line            : string;
   Counter, Result : byte;
   Spare           : char;

begin
   writeln('Enter a string of letters and numbers: ');
   readln(Line);
   Counter := 1;
   Spare   := chr(ord('a') - 1);
   Result  := 0;
   while (Counter <= Length(Line)) and (Result = 0) do
      begin
         if (Line[Counter] in LowerCase) then
            if (Line[Counter] > Spare) then
               Spare := Line[Counter]
            else
               Result := Counter;
         inc(Counter);
      end;
   writeln('The element number breaking the sequence is ', Result);
end.
```

## STRING15

```pascal
var
  i,Num:integer;
  S:string;

begin
 Write('S:');
 Readln (S);

 Num:=0;
 for i:=1 to Length(S) do
  if (ord(S[i]) in  [97..122,160..175,224..239]) then inc(Num);

 Writeln(Num);
end.
```

## PROC30

```pascal
Function DigitN(K,N:Integer):Integer;
var i :integer;
begin
  for i:=1 to N-1 do
  begin
    K:=K div 10;
  end;
  if K<> 0 then DigitN:=K mod 10
  Else DigitN:=-1;
end;

var
  i,i2,K:Integer;

begin
 for i:=1 to 5 do
  begin
   Write('K :');
   Readln(K);
   for i2:=1 to 5 do
    begin
      Writeln(DigitN(K,i2));
    end;
  end;
end.
```

## PROC36

```pascal
Function Fib(N:Integer):Integer;
var
  i:integer;
  Fk,Fk1,Fk2 :Integer;
begin
  Fk1:=1;
  Fk2:=1;
  For i:=3  to N do
  begin
   Fk:=Fk2+Fk1;
   Fk2:=Fk1;
   Fk1:=Fk;
  end;
   Fib:=Fk;
end;

var
  N,i:Integer;

begin
 for i:=1 to 5 do
  begin
   Write('N :');
   Readln(N);
   Writeln( Fib(N) );
  end;
   Readln;
end.
```

## PROC34

```pascal
Function Fact(N:Integer):Real;
var
  i:integer;
  tempRez:Real;
begin
  tempRez:=1;
  for i:=1 to N do tempRez:=tempRez*i;
  Fact:=tempRez;
end;

var
  N,i:Integer;

begin
 for i:=1 to 5 do
  begin
   Write('N :');
   Readln(N);
   Writeln( Fact(N) );
  end;
end.
```

## MARTIX51

```pascal
type
  matrix = array [1..10,1..10] of integer;

var
  a:matrix;
  MinI,MinJ, MaxI, MaxJ, M, N, i, j, K1, K2:Integer;

procedure Swap(var X,Y:Integer);
begin
 if x<>y then
  begin
   X:=X+Y;
   Y:=X-Y;
   X:=X-Y;
  end;
end;

procedure SwapMatrixRow(var mat:matrix; X,Y:Integer);
var
 j:integer;
begin
 if x<>y then
  for j:=1 to N do
   swap(mat[x,j], mat[y,j]);
end;

begin
 Write('N: ');
 Readln(N);
 Write('M: ');
 Readln(M);

 for  i:=1 to M do
  begin
   writeln(i,': ');
   for j:=1 to N do
    begin
     Write(j,' : ');
     Read(a[i,j]);
    end;
  end;

 MaxI:=1;
 MaxJ:=1;
 MinI:=1;
 MinJ:=1;

 for  j:=1 to N do
  begin

   for i:=2 to M do
    begin
     if a[i,j]>a[MaxI,MaxJ] then
      begin
       MaxI:=i;
       MaxJ:=j
      end;
     if a[i,j]<a[MinI,MinJ] then
      begin
       MinI:=i;
       MinJ:=j;
      end;
    end;
  end;

 SwapMatrixRow(a, MaxI, MinI);

 for  i:=1 to M do
  begin
   for j:=1 to N do
    begin
     Write(' : ',a[i,j]);
    end;
   writeln(' : ');
  end;
end.
```

## MARTIX42

```pascal
var
  a:array [1..10,1..10] of integer;
  Num, M, N, i, j:Integer;

begin
 Write('N: ');
 Readln(N);
 Write('M: ');
 Readln(M);

 for  i:=1 to M do
  begin
   writeln(i,': ');
   for j:=1 to N do
    begin
     Write(j,' : ');
     Read(a[i,j]);
    end;
  end;

 Num:=0;
 for  i:=1 to M do
  begin
   J:=2;
   While ((a[i,j-1]<a[i,j]) and (j<=N)) do inc(j);
   if J=N+1 then inc(Num);
  end;
 writeln(Num);
end.
```

## MARTIX1

```pascal
var
  a:array [1..10,1..10] of integer;
  M, N, i, j:Integer;

begin
 Write('M: ');
 Readln(M);
 Write('N: ');
 Readln(N);


 for  i:=1 to M do
  for j:=1 to N do
   a[i,j]:=i*10;

 for  i:=1 to M do
  begin
   for j:=1 to N do Write(' : ',a[i,j]);
   writeln(' : ');
  end;
end.
```

## CASE5

```pascal
var
  N,A,B:Integer;
begin
  Write('Введите номер действия: ');
  Readln(N);
  Write('Введите число A: ');
  Readln(A);
  Write('Введите число B: ');
  Readln(B);

  Case N of
    1: Writeln(A+B);
    2: Writeln(A-B);
    3: Writeln(A*B);
    4: Writeln(A/B);
  end;
end.
```

## CASE10

```pascal
var
  C:Char; //*
  N:Integer;
begin
  Write('Введите текущее напрление перемещения робота: ');
  Readln(C);
  Write('Введите команду: ');
  Readln(N);

  Case C of
   'N':Case N of
         1:C:='W';
         0:C:='N';
        -1:C:='E';
       end;
   'E':Case N of
         1:C:='N';
         0:C:='E';
        -1:C:='S';
       end;
   'S':Case N of
         1:C:='E';
         0:C:='S';
        -1:C:='W';
       end;
   'W':Case N of
         1:C:='S';
         0:C:='W';
        -1:C:='N';
       end;
  end;
  Writeln(C);
end.
```

## CASE11

```pascal
var
  C:Char;
  N1,N2:Integer;
begin
  Write('Введите текущее напрление перемещения робота: ');
  Readln(C);
  Write('Введите 1 команду: ');
  Readln(N1);
  Write('Введите 2 команду: ');
  Readln(N2);

  Case C of
   'N':Case N1+N2 of
         -1,3:C:='E';
         1:C:='W';
         2,-2:C:='S';
       end;
   'E':Case N1+N2 of
         -1,3:C:='S';
         1:C:='N';
         2,-2:C:='W';
       end;
   'S':Case N1+N2 of
         -1,3:C:='W';
         1:C:='E';
         2,-2:C:='N';
       end;
   'W':Case N1+N2 of
         -1,3:C:='N';
         1:C:='S';
         2,-2:C:='E';
       end;
  end;
  Writeln(C);
end.
```

## ARRAY22

```pascal
var
  a:array[1..10] of integer;
  N,K,L,i,Sum:Integer;

begin
  Write('N: ');
  Readln(N);
  Write('K: ');
  Readln(K);
  Write('L: ');
  Readln(L);
  for i:=1 to N do
   begin
    write(i,' :');
    readln(a[i]);
   end;

  Sum:=0;
  for i:=1 to k-1 do Sum:=Sum+a[i];
  for i:=l+1 to n do Sum:=Sum+a[i];

  Writeln (Sum);
end.
```

## ARRAY2

```pascal
var
  a:array[1..10] of integer;
  N,i:Integer;

begin
  Write('N:');
  Readln(N);
  a[1]:=2;
  for i:=2 to N do a[i]:=a[i-1]*2;

  for i:=1 to N do writeln(i,' : ',a[i]);
end.
```

## ARRAY29

```pascal
var
  a:array[1..10] of integer;
  N,i,Max:Integer;

begin
  Write('N: ');
  Readln(N);
  for i:=1 to N do
   begin
    write(i,' :');
    readln(a[i]);
   end;

  i:=1;
  Max:=a[1];
  While (i<=N) do
  begin
 if a[i]>Max then Max:=a[i];
    i:=i+2;
   end;

  Writeln(Max);
end.
```
