# Informe de Arquitecturas 

### Integrantes: 
 - Daniel de la Cruz Prieto
 - Camilo Rodriguez Velazquez
 - Julio Jose Horta Vazquez
 - Frank Adrian Perez Morales

### Arquitectura Microkernel 

La Arquitectura de Microkernel (Plug-in) permite crear aplicaciones extensibles, 
mediante la cual es posible agregar nueva funcionalidad mediante la adici�n de 
peque�os plugins que extienden la funcionalidad inicial del sistema.

En este tipo de arquitectura las aplicaciones tienes dos tipos de componentes: 
 -  EL sistema Core (o sistema central) 
 -  Plugins (o m�dulos)
 
El Sistema Core contiene los elementos m�nimos para hacer que la aplicaci�n 
funcione y cumpla el prop�sito para el cual fue dise�ada.

Los  plugins o m�dulos son componentes perif�ricos que se a�aden o instalan al 
componente Core para extender su funcionalidad. Es decir que solo puede haber 
un componente Core y muchos Plugins, como se muestra en el esquema siguiente: 

![](img/ArquitecturaMicrokernel.png)

El objetivo de esta arquitectura es permitir la extensi�n de su funcionalidad 
o personalizaci�n, respetando el principio Open-Closed, es decir, est� abierto 
para extender la funcionalidad, pero cerrado para modificar su funcionalidad 
principal. De esta forma, es posible que los desarrolladores pueden crear 
plugins para agregar nueva funcionalidad o extender la existente, pero sin 
alterar la funcionalidad Core del sistema.

***Ejemplos*** de esta arquitectura son los IDE�s de desarrollo como *Eclipse*, 
*Netbeans*, *Visual Studio*, *Visual Studio Code* o los sistemas de ofim�tica 
como *Word*, *Powerpoint*, *Excel*, etc. Todas estas aplicaciones permiten que 
los desarrolladores creen nueva funcionalidad, la cual se instala para extender 
o agregar nuevas caracter�sticas. 

En el caso de los IDE�s de desarrollo, tenemos plugins para permitir el uso 
de servidores de aplicaciones, soportar nuevos lenguajes de programaci�n, 
para editar archivos de determinada extensi�n, para conectarnos a la base de 
datos, utilizar terminales, consumir servicios, etc. 

En el caso de los programas de ofim�tica tenemos la opci�n de conectarnos con 
servicios como Sharepoint, almacenamiento en la nube con Google Drive, DropBox, 
One Drive, integraci�n con Slack, plugins para insertar firmas electr�nicas, 
traducci�n, etc.

### Como se estructura una arquitectura *Microkernel*

Los sistemas que usan esta arquitectura no son f�ciles de desarrollar, pues se 
necesita crear aplicaciones que sean capaces de agrandar din�micamente su 
funcionalidad a medida que nuevos plugins sean instalados, al mismo tiempo debemos 
tener mucho cuidado de que los plugins no modifiquen o alteren la esencia de la 
aplicaci�n.

El hecho de lograr que un sistema acepte plugins es complicado, porque por lo 
general el Sistema Core y los Plugins son desarrollados por equipos separados, 
por lo que el sistema Core debe de dejar muy en claro como los plugins deben ser 
desarrollados. Adem�s debe tener un archivo descriptor que le diga al sistema 
Core como debe de instalarse o deber�a de mostrar el plugin ante el usuario.

El sistema Core debe de proporcionar un API o una definici�n la cual el plugin 
debe de implementar, de esta forma tenemos el sistema Core y el API que provee 
para que los desarrolladores creen los plugins. El API es una serie de clases 
o interfaces que deben ser implementadas por el Plug-in, las cuales ser�n 
analizadas por el sistema Core al momento de la instalaci�n.

![](img/apidelmicrokernel.png)

El API en realidad es un componente independiente del sistema Core(como se 
muestra en la imagen anterior), el cual contiene solamente las clases e 
interfaces que deber�n conocer tanto el sistema Core como los Plugins.

Por lo general hay una interface o clase abstracta llamada Plugin la cual 
servir� como punto de entrada para el sistema Core, y le dar� toda la 
informaci�n del Plugin al sistema Core.

