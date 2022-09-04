# Zadanie rekrutacyjne
Junior C# ANTLR Developer

## Sposób uruchomienia

Aby uruchomić testy:
```bash
dotnet test
```

Program główny nie zawiera kodu. Działanie kodu prezentują testy jednostowe

## Struktura projektu

- Folder `Antlr` zawiera plik z gramatyką. Plik jest kopią:
`https://github.com/sirensolutions/antlr4-javascript-sql/blob/master/grammars/sql/SQL.g4`
<br />
- Folder `Tools` zawiera klase statyczną, której metoda 
zwraca tablice stringów o następującej budowie:
```
<DatabaseName?>.<TableName>.<ColumnName>
```

- Folder `Visitors` zawiera klasy dziedziczące po `BaseVisitor`,
których działanie opiera się na przejściu drzewa parsujące.<br />
Zadaniem tych klas jest pogrupowanie nazw kolumn, nazw tabel oraz ich aliasów, w celu ich powiązania.<br />

Ze względu na budowe drzewa parsującego, w celu poszukiwania nazw kolumn i aliasów z nimi powiązanych, 
wystarczy szukać do klauzuli JOIN. Z tego powodu "wizytacja" węzłów jest przerywana w momencie dotarcia do odpowiedniego węzła.<br />

- Testy polegają na porównaniu wartości stworzych przez program z listą kolumn użytych w zapytaniu posortowanych według tabel i koleności.
