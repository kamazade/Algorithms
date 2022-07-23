# MERGE SORT
Tüm elemanlar tek kalana kadar diziyi ortadan ikiye bölüyoruz.

 | 16 | 21 | 11 | 8 | 12 | 22 |
 |:---|:---|:---|:---|:---|:---|

* |   | 16 | 21 | 11 |   | 8 | 12 | 22 |    |
* | 16 |  | 21 | 11 |     | 8 |   | 12 | 22 |
* | 16 | | 21 | | 11 |   | 8 | | 12 | | 22 |
Devamında Sıralayarak Birleştiriyoruz

* | 16 | | 11 | 21 |     | 8 | | 12 | 22 |
* | 11 | 16 | 21 |         | 8 | 12 | 22 |
* |    | 8 | 11 | 12 | 16 | 21 | 22 |    |
