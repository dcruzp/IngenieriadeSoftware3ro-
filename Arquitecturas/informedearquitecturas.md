# Informe de Arquitecturas 

### Integrantes: 
 - Daniel de la Cruz Prieto
 - Camilo Rodriguez Vel�zquez
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


### Ventajas y Desventajas 

La arquitectura Microkernel (plug-in) nos aporta ciertas ventajas para implementar 
nuestros proyectos como: este tipo de arquitectura reacciona a los cambios 
realizados en los m�dulos de plug-in mientras minimiza los cambios en el sistema 
principal, por lo tanto requiere pocos cambios en el tiempo, lo cual nos aporta 
una estabilidad a largo plazo. A diferencia de las arquitecturas en capas, tener 
m�dulos de plug-in significa que es m�s f�cil de implementar, minimizando as� el 
tiempo de inactividad durante la implementaci�n.

Las pruebas en este tipo de arquitectura son muy f�ciles de realizar debido a que 
los m�dulos de plug-in se pueden probar de manera aislada, lo que implica muy 
pocos o casi ning�n cambio en el sistema central. Aunque generalmente no es la 
arquitectura ideal para usarse en aplicaciones de alto rendimiento, puede 
funcionar bien debido a la personalizaci�n de la aplicaci�n para incluir solo 
las caracter�sticas que se necesitan.

Sin embargo, en las implementaciones con la arquitectura de microkernel las 
aplicaciones tienden a ser de un tama�o peque�o, por lo tanto, no son altamente 
escalables, esta caracter�stica depende de como se implementan los m�dulos de 
plug-in en ciertos niveles. Adem�s, requiere un an�lisis exhaustivo del dise�o 
antes de la implementaci�n: los elementos a analizar incluyen el control de 
versiones de contratos, los registros internos de los plug-in y las amplias 
opciones disponibles para la conectividad plug-in.

### Implementaci�n 

El producto que utilizaremos para nuestra implementaci�n es el presentado en el 
seminario de especificaci�n de requerimientos: �Clash Royale�.

Utilizaremos varios tipos de arquitectura para este programa una de estas es la 
arquitectura Cliente-Servidor N-Capas (tres capas) donde existen tres tipos de 
capas: 

Capa de Presentaci�n: Esta capa est� destinada al usuario, por lo cual tambi�n se 
le denomina "Capa de Usuario". En esta, el usuario intercambiar� con una interfaz 
gr�fica, donde se le presentar� el sistema de una manera f�cil y entendible de 
usar. Es donde el usuario podr� analizar que acciones quiere realizar en nuestra 
aplicaci�n, como la creaci�n y edici�n de un perfil, selecci�n del modo de 
batalla, etc... 

Capa de Negocio: En esta se reciben las peticiones del usuario, a trav�s de la 
comunicaci�n con la Capa de Usuario, se eval�a esta informaci�n y se procesa 
para solicitar al gestor de base de datos lo que se necesita. Luego se comunica 
nuevamente con la Capa de Presentaci�n para presentar los resultados adquiridos. 
En esta capa se consideran los programas de la aplicaci�n. 

Capa de datos: Es la capa encargada del almacenamiento de los datos y tambi�n del 
acceso a los mismos. En esta se almacenan, recuperan o se reciben a trav�s de la 
Capa de Negocio los datos utilizados. Esta capa es de vital importancia en nuestro 
proyecto debido a la gran cantidad de informaci�n que se desea de recopilar en 
nuestra aplicaci�n como: informaci�n de las cartas, usuarios, cofres, batallas, 
entre otras m�s. 

En la Capa de Negocio utilizaremos la arquitectura de Microkernel (plug-in) en 
donde implementaremos cada una de las funcionalidades que puede tener nuestro 
programa como: creaci�n y edici�n del perfil, almacenamiento de cofres, chat del 
programa, obtenci�n de art�culos, etc� cada una de estas ser�n implementadas por 
separado siendo los plug-in todos los m�todos que cada una de estas pueden 
realizar. Por ejemplo en el requisito de Perfil del jugador cada uno de los 
plug-in ser�n la informaci�n que se desea saber del jugador en cuesti�n: como su 
apodo, nivel , cantidad de victorias , etc.(todas estas informaciones van a estar 
almacenadas en la base de datos (Capa de datos)) y el sistema principal se 
encargar� de funcionalidades principales como la actualizaci�n en la base de 
datos de todas estas informaciones. 

Este tipo de arquitectura nos permite a la hora de crear cada uno de los 
plug-in una f�cil implementaci�n e incluso cuando se les realicen pruebas a 
estos poder modificarlos sin afectar el sistema principal. Adem�s, se toma en 
cuenta este tipo de arquitectura debido a que si se le desea a�adir alguna otra 
funcionalidad m�s simplemente se le puede a�adir otro plug-in a la funcionalidad 
que se quiera actualizar. 


### Conclusiones 

Como se ha podido analizar el estilo arquitect�nico de Microkernel permite 
extender la funcionalidad de sistema mediante la adici�n de Plugins, 
dichos plugins pueden ser desarrollados por terceros, lo que ampl�a las 
posibilidades de la aplicaci�n Core si necesidad de costear los desarrollos, 
al mismo tiempo que permites que puedan personalizar al m�ximo el sistema.

Por otra parte, podemos observar que un sistema basado en Microkernel permite 
tener m�ltiples equipos de desarrollo que construyen los m�dulos en paralelo 
sin interferir unos con otros, al mismo tiempo que permite que estos componentes 
sean probados de forma independientes, por lo que podemos decir que este estilo 
es f�cil de probar.

Sin embargo, hemos visto que uno de las principales problem�ticas de este estilo 
arquitect�nico es su alta complejidad de desarrollar y su escalabilidad, lo cual 
puede ser una limitante para sistemas que deben ser dise�ados para un alto 
escalamiento.