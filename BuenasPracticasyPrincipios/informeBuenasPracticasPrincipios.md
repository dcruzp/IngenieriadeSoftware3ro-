# Informe de Buenas Pr�cticas y principios 


 ##### Integrantes del Equipo:
  - Daniel de la Cruz Prieto 
  - Camilo Rodriguez Velazquez
  - Julio Jose Horta Vazquez 
  - Frank Adrian Perez Morales


El Principio de Sustituci�n de Liskov o LSP (Liskov Substitution Principle) corresponde a la sigla L dentro de los cinco principios SOLID para mantener una buena pr�ctica de programaci�n.

Este fue presentado en una conferencia titulada Abstracci�n de Datos y Jerarqu�a en el a�o 1988 por B�rbara Liskov, una reconocida ingeniera de software americana que fue la primera mujer en Estados Unidos en conseguir un Doctorado en Ciencias de la Computaci�n. Liskov lo defini� como algo parecido a la siguiente propiedad de sustituci�n:

- �Si S es un subtipo de T entonces los objetos de tipo T pueden ser pueden ser reemplazados con objetos de tipo S, sin alterar ninguna de las propiedades deseadas del programa (correctitud, ejecuci�n de sus m�todos, etc.)

Posteriormente fue formulado por Barbara Liskov y Jeannette Wing de manera conjunta en un art�culo en el a�o 1994.

LSP es una serie de pautas para guiar jerarqu�as de herencia en las cuales, el desarrollador podr� utilizar de manera confiable cualquier clase o �clase hija� (clases que heredan de otra clase) sin comprometer su comportamiento. Es decir, se debe cumplir (si se realiza la herencia de una manera correcta) que el comportamiento de una clase hija, debe permanecer compatible con el de su �clase padre� (clase de la cual hereda). Este principio se evidencia mejor en ejemplos de como violarlo: si cuando se sobrescribe un m�todo en la �clase hija� se necesita poner una excepci�n o simplemente el m�todo no realiza nada, probablemente se est� violando el LSP.

Algunas de las pautas que conforman LSP son: 
-  Las condiciones previas (m�todos, atributos) de una clase padre no pueden �fortalecerse� en una clase hija,
-  las invariantes (condiciones que deben permanecer verdaderas) de la clase padre deben conservarse en cualquier clase que herede de esta, entre otras m�s.

En nuestra opini�n este Principio es de gran importancia para facilitar la reusabilidad del c�digo de cualquier tipo de programa, sus conceptos fundamentales son vitales en el desarrollo de frameworks y librer�as, debido a que al cumplir el LSP en estos, sus clases podr�n ser utilizadas por terceros evitando las ambig�edades y los fallos que pueda tener la jerarqu�a de las clases de estos.


## C�digo 

Este es el esquema del c�digo que realizamos para mostrar como ser�a una debida implementaci�n de el ejemplo. 

Hicimos una soluci�n de **Visual Studio 2019**  , abajo esta el diagrama(jerarqu�a de clases ) de como esta implementada la soluci�n nuestra.

![](img/gerarquiadeclases.jpg)



