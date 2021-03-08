# Proyecto: Clash Royale
- ## Ejecutores:  
    + ##### Lider 
        - Daniel de la Cruz Prieto  
         
    + ##### Integrantes del Equipo 
        - Daniel de la Cruz Prieto 
        - Camilo Rodriguez Velazquez
        - Julio Jose Horta Vazquez 
        - Frank Adrian Perez Morales



## 1. Introducci�n 

Clash Royale, tambi�n conocido por su abreviatura CR, es un videojuego de 
estrategia en l�nea para dispositivos m�viles, tanto para IOS como Android. 
Es un videojuego Premium, es decir, que descargarlo y jugarlo va a ser gratis, 
pero va existir una tienda que funcionar� con dinero real para comprar algunos 
complementos del juego, que van a ser de gran inter�s para los jugadores que 
est�n interesados en avanzar m�s r�pido en el juego, es un juego de estrategia 
en tiempo real basado en los personajes de Clash of Clans, popular juego 
de la compa��a Supercell. Combina elementos de los juegos de cartas 
coleccionables y defensa de torres.

### 1.1 Prop�sito del Documento 

El objetivo del documento es dar una caracterizaci�n del producto, 
as� como aspectos escenciales para el desarrollo de este videojuego(Descripi�n 
General, Especificaciones de Requerimientos, Objetivos que debe cubrir el producto, entre otras ). 

Se tratan aspectos importantes y de inter�s tanto para desarrolladores que 
deseen colaborar en la aplicaci�n como para consumidores del producto, pero con 
un enfoque t�cnico y descriptivo. 

### 1.2 Alcance del Producto 

Como es un videojuego online , cualquier usuario puede hacer uso del producto, 
pues no es un software de pago excepto algunas funcionalidades. 
Desde cualquier terminal(android,IOs) con conexi�n a internet es posible hacer 
uso de la aplicacion. 

Este producto va dirigido al p�blico joven con necesidaded de entretenimiento 
y distracci�n. Aunque no hay restriciones, esta abierto a todo p�blico que 
vea en la apliaci�n la saciedad en momentos de ocio. 

### 1.3 Referencias 

   ALgunas referencias digitales para las consultas en el desarrollo del producto:

  1. [Desarrollo de videojuegos - Wikipedia](https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&ved=2ahUKEwjB5tnO15nvAhWURzABHbmjCgcQFjABegQIBxAD&url=https%3A%2F%2Fes.wikipedia.org%2Fwiki%2FDesarrollo_de_videojuegos&usg=AOvVaw3xh6gruRjDoHF-zYqLorG5)

  2. [Fases mas importantes en el desarrollo de videojuegos](https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&ved=2ahUKEwjB5tnO15nvAhWURzABHbmjCgcQFjACegQIAxAD&url=https%3A%2F%2Fdocs.hektorprofe.net%2Fescueladevideojuegos%2Farticulos%2Ffases-del-desarrollo-de-videojuegos%2F&usg=AOvVaw2zdJIzhEefMdPCPYKjHEVC)



## 2. Descripci�n General 

### 2.1 Pespectiva del Producto 


Es un videojuego online ,por lo que est� dedicado a la industria del entretenimiento. 
El producto va dirigido a todo p�blico, fundamentalmente a ni�os y j�venes. Dado el alto 
consumo de estos grupos de poblaci�n a productos que est�n dirigidos al entretenimieto.
Es un software ligero(pocos recursos), por lo que no se requieren de
tecnolog�as avanzadas para hacer uso de la aplicaci�n. 
F�cil de entender y utilizar por lo que no requiere una curva elevada de aprendizaje. 

Inicialmente tendr� soporte solo para dispositivos m�viles(sistemas Android , IOs), 
pero se extender� a  otras plataformas como Windows y Mac

Se espera una gran cantidad de usuarios haciendo uso de la plataforma , dada la 
gran masividad de  personas que d�a a  d�a dedican el tiempo a hacer uso de 
tecnolog�as y productos como estos para el entretenimiento.   

### 2.2 Funciones del Producto 

EL producto debe tener un sistema de gesti�n de los usuarios inscritos en la 
plataforma , as� como un registro para almacenar y procesar los datos de los 
mismo(solo usuarios privilegiados escogidos por los desarrolladores tendr�n el 
acceso a dichos datos) una aplicaci�n gr�fica sencilla, (que consuma pocos 
recursos de software) y a la vez r�pida. pero agradable para la interacci�n 
de los usuarios que hacen uso de ella (consumidores del producto).

Debe ser extensible por lo que tiene que ser pensado y dise�ado con ese fin .

Debe estar basado en un sistema de versiones para futuras mejoras e incorporar 
funcionalidades a medida que se estudien los datos de los consumidores del 
producto con el objetivo de atraer a m�s usuarios a la plataforma. 

La principal funci�n del producto es dar un servicio did�ctico, educativo  y a la 
vez de entretenimiento a los usuarios , adem�s de interacci�n social mediante 
esta app, pues es un juego en l�nea en la que participan una cantidad 
considerable de usuarios y tienen una interacci�n casi directa 
haciedo uso de la aplicaci�n.     

 

##### algunas carater�sticas b�sicas que debe tener el producto a petici�n del cliente:
  - Una Base de datos para almacenar los records de los usuarios
  - Informaci�n de registros estad�sticos(visibles para todo los usuarios de la plataforma )
  - Libre acceso y costo. (solo algunas funcionalidades de pago)
  - Tener un entorno gr�fico ligero pero que guste y atraiga a buena cantidad de usuarios 
  - F�cil de manipular y entender para todo tipo de usuario
  - Apartado para sugerencias y reporte de errores a los desarrolladores  

### 2.3 Caracter�sticas de los usuarios

El producto va dirigido a todo tipo de p�blico. Pero va a estar orientado 
fundamentalmente a j�venes y ni�os. El grado de experiencia de este tipo de 
p�blico es marcado por el alto contenido y competitividad que existe en la 
industria del entretenimiento, y sobretodo en videojuegos de este tipo, por 
lo que los usuarios son cr�ticos y tiene un gran conocimiento en el uso de estas
aplicaciones.

La rapidez y fluidez de la aplicaci�n es fundamental dado el gran volumen de 
usuarios en la plataforma que se prevee, basado en el alto impacto de otros 
productos similares en la industria de los videojuegos.
 
### 2.4 Restricciones Generales 

Entre las restricciones de la aplicaci�n tenemos que el juego solamente 
correr� online(es decir que es necesario estar conectado para poder hacer 
uso de la app, y poder jugar con otras personas).
 
Deben implementarse versiones para Android e IOs, la ambientaci�n y dise�o 
deben respetar la animaci�n seleccionada, los precios de los elementos 
de la tienda de dinero real deben mantenerse m�nimos. Se tiene que la 
interfaz debe ser lo m�s sencilla posible y f�cil de entender. 
Los tutoriales deben estar asequibles para todo el p�blico y deben ser lo m�s 
abarcadores posibles en cada aspecto del juego.


### 2.5 Dependencias y suposiciones  

Debe poder conectarse  a servicios en l�nea , que sean de pago(tarjetas, 
cuentas bancarias etc), para el desbloqueo de funcionalidades de pago que 
tendr� la aplicaci�n(como estrateg�a de ingresos para los desarrolladores) 

Debe tener un registro en PlayStore(servicio de Google). para publicidad y 
evaluaci�n de la aplicaci�n , as� como para publicidad del producto. Debido 
al alto impacto y uso de esta tienda online que esta bastante difundida en 
la red.  

Preferiblemente el desarrollo de la aplicaci�n WEB debe realizarse usando 
bibliotecas .net, requerido as� por el gran soporte que tienen para el futuro 
las tecnolog�as de Microsoft. 

## 3. Requerimientos Espec�ficos 


### 3.1 Requerimientos Funcionales 

Creaci�n y edici�n del perfil:  La aplicaci�n debe permitir al jugador crear su perfil con su identificaci�n �nica: el nombre del perfil. 

  ##### Perfil del Jugador:  Se requiere que en el perfil de jugador est�n las estad�sticas de cada usuario: 

  - Apodo del usuario;
  - Nivel del usuario;
  - Cantidad de victorias;
  - Cantidad de cartas encontradas;
  - M�ximo de trofeos obtenidos;
  - M�ximo de Trofeos alcanzados;
  - Carta Favorita Actual.

Estas caracter�sticas se actualizar�n a medida que el usuario evolucione en el 
juego, ser�a una estad�stica personal. Tambi�n en su perfil debe aparecer los 
amigos del usuario a los cuales puede enviarle mensajes de texto y recibir 
tambi�n, �chatear�. 

   ##### Selecci�n de modos de batallas:
   
   > El usuario debe decidir qu� tipo de modo de combate puede seleccionar:
   > 
   >- Combate 1 vs 1
   >- Combate 2 vs 2


  ##### Mantener informado al usuario: 

  >Se requiere que la aplicaci�n informe al usuario acerca de ciertos hechos 
  >que puedan interesarle, como cuando uno de los cofres de su posesi�n se 
  >abre y pueda tener acceso al premio que contiene, o cuando alg�n miembro 
  >de su clan publique alg�n mensaje que puede ser que tenga relaci�n con �l o 
  >no.

  ##### Almacenamiento de Cofres: 
   >Debe existir una secci�n donde el usuario pueda almacenar los cofres 
   >obtenidos como trofeos en las batallas. Solo puede tener al mismo tiempo 
   >cuatro cofres. Para abrir estos el usuario debe esperar una cierta 
   >cantidad de tiempo en dependencia de la calidad del cofre que posee, 
   >mientras menor sea la calidad de este menor tiempo demorar� en abrirse.
    
  ##### Almacenamiento de Cartas: 

   >Debe existir una secci�n donde se almacenen las cartas que tenga el usuario 
   >en tiempo real y que este pueda decidir cuales seleccionar para la pr�xima 
   >batalla incluso subirlas de nivel si el usuario desea.

  ##### Chat:

   > El usuario debe tener una plataforma donde pueda intercambiar mensajes de 
   > texto con los otros miembros de su clan, donde pueda enterarse de las 
   > pr�ximas acciones que realizar�n los miembros o para solicitar ayuda sobre 
   > un tema en espec�fico.


  ##### Obtenci�n de art�culos: 
  
  >El usuario tendr� una opci�n de decidir que art�culo quiere comprar a trav�s
  > de un pago con dinero real. Por cierta cantidad de dinero puede obtener 
  >art�culos como cofres y cartas.


  ##### Funcionalidad: 
  >El usuario debe ser capaz de decidir que opciones de las anteriores quiere 
  >realizar.

### 3.2 Requerimientos no funcionales 

  ##### Creaci�n y Edici�n de un Perfil:
   
  > El perfil puede estar asociado a un n�mero de tel�fono en el cual toda la
  >  informaci�n del usuario est� relacionada con ese n�mero. Si cambia de 
  > n�mero o se desea entrar al perfil desde otro n�mero el usuario en 
  > cuesti�n no tendr� acceso a los datos.  
  > La mejor manera para crear un perfil ser�a la autentificaci�n a trav�s 
  > de un correo, que no causar�a los problemas del ejemplo anterior. 
  > La identificaci�n del perfil ser�a el correo del cual se cre� y su 
  > respectiva contrase�a.
  
>Cuando el perfil es creado la aplicaci�n solo puede permitir que el 
>usuario que cre� el perfil lo actualice.

  ##### Sistema de administraci�n:  
  > Se desea que solo los administradores de la plataforma puedan realizar 
  > tareas de administraci�n, por lo que es necesario que la aplicaci�n sea 
  > capaz de identificar si un usuario es administrador o no, y en consecuencia, 
  > proveerlo de las caracter�sticas permitidas para su rol.

  ##### Medio de Pago:  
 >Los pagos se deben realizar a trav�s de una tarjeta magn�tica relacionada 
 >con una cuenta bancaria.

  ##### Bases de Datos: 
   >Debido a la gran cantidad de cartas y cofres que se puede obtener en el juego, 
   >se debe emplear una base de datos para garantizar la persistencia de estos.

  ##### Experiencia Visual de la aplicaci�n: 
   >el contenido de la aplicaci�n, la interfaz con cada uno de sus art�culos, 
   >igual como la experiencia a la hora de jugar debe tener una alta calidad 
   >visual relacionada con la animaci�n en la que se basa la aplicaci�n. 
   >Las acciones realizadas por cada uno de los avatares y objetos del juego 
   >deben ser mostrado al usuario con la mayor calidad, tambi�n los entornos y 
   >paisajes donde se realizan las batallas.

  ##### Interacci�n t�ctil:   
  >Como la aplicaci�n se desea que se pueda jugar en dispositivos m�viles 
  >como tel�fonos celulares, tabletas, etc. Se prefiere la interacci�n por 
  >la pantalla t�ctil, d�ndole facilidades al usuario de poder seleccionar 
  >las opciones que desea realizar tanto en las batallas que se realicen, 
  >en las opciones de configuraci�n del perfil del usuario, y en la selecci�n 
  >de cofres y cartas.

  ##### Soporte T�cnico: 
   >Se desea garantizar que el usuario pueda comunicarse con los administradores
   > del juego si este presenta alg�n error en alg�n funcionamiento, para poder 
   >repararlo lo m�s r�pido posible, por lo tanto, una secci�n de la interfaz 
   >estar� dedicada a esta funci�n.
  ##### Requerimiento de Actualizaci�n:
   > Cada cierto tiempo los administradores deber�n crear una nueva 
   > actualizaci�n de la aplicaci�n donde se puedan solucionar todos los 
   > errores que los usuarios puedan encontrar, y tambi�n donde se actualicen 
   > las  funcionalidades de los art�culos.

### 3.3 Requerimientos de entorno 

 ##### Requerimientos del hardware y software del sistema:
 - La aplicaci�n esta destinada para dispositivos m�viles los cuales tengan como sistema Operativo : IOS 9.0.0 o versi�n superior y Android 4.1.0 o versi�n superior. 
 - Se necesita conexi�n de red. 
 - Aproximadamente 400 Mb de capacidad la versi�n inicial tiene 200 Mb y luego poco a poco se actualizar�n con las nuevas versiones. 



## Anexos 

 - Jhonatan Joestar, 40 a�os. Beta tester profesional, publica art�culos en varias revistas de videojuegos peri�dicamente. Nos reunimos con �l una vez a la semana en encuentros entre hora y media y dos horas.
 
 - Jotaro Kujo, 19 a�os. Estudiante de preparatoria, dedica gran parte de su tiempo libre a los videojuegos. Las reuniones fueron cada 15 d�as en encuentros de menos de una hora.
 
 - Dio Brando, 29 a�os. Empleado de una f�brica de conservas, alto consumidor de videojuegos. Encuentros semanales que duran entre 1 y 2 horas.

   Se les iban dando videos hechos por el equipo de trabajo para la explicaci�n de distintas funcionalidades, asi como PowerPoint para mostrar ciertos aspectos.

