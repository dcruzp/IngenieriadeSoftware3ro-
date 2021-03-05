# Proyecto: Clash Royale
- ## Ejecutores:  
    + ##### Lider 
        - Daniel de la Cruz Prieto  
         
    + ##### Integrantes del Equipo 
       > - Daniel de la Cruz Prieto 
       > - Camilo Rodriguez Velazquez
       > - Julio Jose Horta Vazquez 
       > - Frank Adrian Perez Morales



## 1. Introduccion 

Clash Royale, tambi�n conocido por su abreviatura CR, es un videojuego de estrategia en l�nea para dispositivos m�viles, tanto para IOS como Android. Es un videojuego Premium, es decir, que descargarlo y jugarlo va a ser gratis, pero va existir una tienda que funcionara con dinero real para comprar algunos complementos del juego, que van a ser de gran inter�s para los jugadores que esten interesados en avanzar m�s r�pido en el juego, es un juego de estrategia en tiempo real basado en los personajes de Clash of Clans, popular juego de la compa��a Supercell. Combina elementos de los juegos de cartas coleccionables y defensa de torres.

### 1.1 Proposito del Documento 

El objetivo del documento es dar una caracterizacion del producto a desarrollar, asi como 
Aspectos escenciales para el desarrollo de este videojuego(Descripion General , Especificaciones de Requerimientos ,Objetivos que debe cubrir el producto entra otras ). 

### 1.2 Alcance del Producto 

Como es un videojuego online , cualquier usuario puede hacer uso del producto, pues no es un software de pago excepto algunas funcionalidades. 
Desde cualquier terminal(android,IOs) con conexion a internet  es posible hacer uso del software. 

### 1.3 Referencias 

   ALgunos referencias digitales para las consultas en el desarrollo del software

  1. [Desarrollo de videojuegos - Wikipedia](https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&ved=2ahUKEwjB5tnO15nvAhWURzABHbmjCgcQFjABegQIBxAD&url=https%3A%2F%2Fes.wikipedia.org%2Fwiki%2FDesarrollo_de_videojuegos&usg=AOvVaw3xh6gruRjDoHF-zYqLorG5)

  2. [Fases mas importantes en el desarrollo de videojuegos](https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&ved=2ahUKEwjB5tnO15nvAhWURzABHbmjCgcQFjACegQIAxAD&url=https%3A%2F%2Fdocs.hektorprofe.net%2Fescueladevideojuegos%2Farticulos%2Ffases-del-desarrollo-de-videojuegos%2F&usg=AOvVaw2zdJIzhEefMdPCPYKjHEVC)



## 2. Desripcion General 

### 2.1 Pespectiva del Producto 


Es un videojuego online , por lo que esta dedicado a la industria del entretenimiento. El producto va dirigido a todo publico, fundamentalmente a ninos y jovenes. Dado el alto consumo de estos grupos de poblacion a productos dirigidos al entretenimieto.
Es un producto ligero(pocos recursos de hardware), por lo que no se requieren de tecnologias avanzadas para el consumo del mismo. 
Facil de entender y utilizar por lo que no requiere una curva elevada de aprendizaje. 

Inicialmente tendra soporte solo para dispositivos moviles(sistemas Android , IOs), pero se extendera a  otras plataformas como windows y Mac   

### 2.2 Funciones del Producto 


EL producto debe tener un sistema de gestion de los usuarios inscritos en la plataforma , asi como un registro para almecenar y procesar los datos de los mismo(solo usuarios privilegiados escogidos por los desarrolladores tendran al acceso a dichos datos )
una aplicacion grafica sencilla, (que consuma pocos recursos de software) y a la vez rapida. pero agradable para la interaccion de los usuarios que hacen uso de ella (consumidores del producto )

debe ser extensible por lo que debe de ser pensado y disenado con ese fin.

Debe estar basado en un sistema de versiones para futuras mejoras e incorporar funcionalidades a medida que se estudien los datos de los consumidores del producto para atraer a mas usuarios a la plataforma 

 

##### algunos carateristicas basicas que debe tener el producto a peticion del cliente:
  - una Base de datos para almacenar los records de los usuarios
  - Informacion de registros estadisticos(visibles para todo los usuarios de la plataforma )
  - Libre acceso y costo. (solo algunas funcionalidades de pago)
  - Tener un entorno grafico liviano pero que guste y atraiga a usuarios 
  - Facil de manipular y entender para todo tipo de usuario 

### 2.3 Caracteristicas de los usuarios

El producto va dirigido a todo tipo de publico. Pero va a estar dorientado fundamentalmente a jovenes y ninos. El grado de experiencia es marcado por el alto contenido y competitividad 
en la industria del entretenimiento , y en videojuegos de este tipo , Por lo que los usuarios son critios y tiene un alto conocimiento en el manejo de productos de este tipo.
La rapidez y fluidez de la plataforma es fundamental dado el gran volumen de usuarios de la plataforma que se prevee dado el alto impacto de otros productos similares 
 

### 2.4 Restricciones Generales 

Entre las restricciones de la aplicaci�n tenemos que el juego solamente correr� online. Deben implementarse versiones para Android e IOS, la ambientaci�n y dise�o deben ser respetar la animaci�n seleccionada, los precios de los elementos de la tienda de dinero real deben mantenerse m�nimos. Se tiene que la interfaz debe ser lo m�s sencilla posible y f�cil de entender. Los tutoriales deben estar asequibles para todo el p�blico y deben cubrir de forma abarcadora cada aspecto del juego.


### 2.5 Dependencias y suposiciones  

Debe poder conectarse  a servicios en linea , que sean de pago(tajetas, etc) , para el desbloqueo de funcionalidades de pago que tendra la aplicacion 

Debe tener un registro en PlayStore(servicio de Google). para publicidad 

Preferiblemnte el derarrollo de la aplicacion  WEB debe desarrollarse usando bibliotecas .net 

## 3. Requerimientos Especificos 


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

Estas caracter�sticas se actualizar�n a medida que el usuario evolucione en el juego, ser�a una estad�stica personal. Tambi�n en su perfil debe aparecer los amigos del usuario a los cuales puede enviarle mensajes de texto y recibir tambi�n, �chatear�. 

   ##### Selecci�n de modos de batallas:
   
   > El usuario debe decidir qu� tipo de modo de combate puede seleccionar:
   > 
   >- Combate 1 vs 1
   >- Combate 2 vs 2


  ##### Mantener informado al usuario: 

  >Se requiere que la aplicaci�n informe al usuario acerca de ciertos hechos que puedan interesarle, como cuando uno de los cofres de su posesi�n se abre y pueda tener acceso al premio que contiene, o cuando alg�n miembro de su clan publique alg�n mensaje que puede ser que tenga relaci�n con el o no.

  ##### Almacenamiento de Cofres: 
   >Debe existir una secci�n donde el usuario pueda almacenar los cofres obtenidos como trofeos en las batallas. Solo puede tener al mismo tiempo cuatro cofres. Para abrir estos el usuario debe esperar una cierta cantidad de tiempo en dependencia la calidad del cofre que posee, mientras menor sea la calidad de este menor tiempo demorara en abrirse.
    
  ##### Almacenamiento de Cartas: 

   >Debe existir una secci�n donde se almacenen las cartas que tenga el usuario en tiempo real y que este pueda decidir cuales seleccionar para la pr�xima batalla incluso subirlas de nivel si el usuario desea.

  ##### Chat:

   > El usuario debe tener una plataforma donde pueda intercambiar mensajes de texto con los otros miembros de su clan, donde pueda enterarse de las pr�ximas acciones que realizaran los miembros o para solicitar ayuda sobre un tema en especifico.


  ##### Obtenci�n de art�culos: 
  
  >El usuario tendr� una opci�n de decidir que articulo quiere comprar a trav�s de un pago con dinero real. Por cierta cantidad de dinero puede obtener art�culos como cofres y cartas.


  ##### Funcionalidad: 
  >El usuario debe ser capaz de decidir que opciones de las anteriores quiere realizar.

### 3.2 Requerimientos no funcionales 

  ##### Creaci�n y Edici�n de un Perfil:
   
  > El perfil puede estar asociado a un n�mero de tel�fono en el cual toda la informaci�n del usuario est� relacionada con ese n�mero. Si cambia de n�mero o se desea entrar al perfil desde otro n�mero el usuario en cuesti�n no tendr� acceso a los datos.  La mejor manera para crear un perfil seria la autentificaci�n a trav�s de un correo, que no causar�a los problemas del ejemplo anterior. La identificaci�n del perfil ser�a el correo del cual se cre� y su respectiva contrase�a.
  
>Cuando el perfil es creado la aplicaci�n solo puede permitir que el usuario que creo el perfil lo actualice.

  ##### Sistema de administraci�n:  
  > Se desea que solo los administradores de la plataforma puedan realizar tareas de administraci�n, por lo que es necesario que la aplicaci�n sea capaz de identificar si un usuario es administrador o no, y en consecuencia, proveerlo de las caracter�sticas permitidas para su rol.

  ##### Medio de Pago:  
 >Los pagos se deben realizar a trav�s de una tarjeta magn�tica relacionada con una cuenta bancaria.

  ##### Bases de Datos: 
   >Debido a la gran cantidad de cartas y cofres que se puede obtener en el juego, se debe emplear una base de datos para garantizar la persistencia de estos.

  ##### Experiencia Visual de la aplicaci�n: 
   >el contenido de la aplicaci�n, la interfase con cada uno de sus art�culos, igual como la experiencia a la hora de jugar debe tener una alta calidad visual relacionada con la animaci�n en la que se basa la aplicaci�n. Las acciones realizadas por cada uno de los avatares y objetos del juego deben ser mostrado al usuario con la mayor calidad, tambi�n los entornos y paisajes donde se realizan las batallas.

  ##### Interacci�n t�ctil:   
  >Como la aplicaci�n se desea que se pueda jugas en dispositivos m�viles como tel�fonos celulares, tabletas, etc. Se prefiere la interacci�n por la pantalla t�ctil, d�ndole facilidades al usuario de poder seleccionar las opciones que desea realizar tanto en las batallas que se realicen, en las opciones de configuraci�n del perfil del usuario, y en la selecci�n de cofres y cartas.

  ##### Soporte T�cnico: 
   >Se desea garantizar que el usuario pueda comunicarse con los administradores del juego si este presenta alg�n error en alg�n funcionamiento, para poder repararlo lo m�s r�pido posible, por lo tanto, una secci�n de la interfase estar� dedicada a esta funci�n.
  ##### Requerimiento de Actualizaci�n:
   > Cada cierto tiempo los administradores deber�n crear una nueva actualizaci�n de la aplicaci�n donde se puedan solucionar todos los errores que los usuarios puedan encontrar, y tambi�n donde se actualicen las  funcionalidades de los art�culos.

### 3.3 Requerimientos de entorno 

 ##### Requerimientos del hardware y software del sistema:
 - La aplicaci�n esta destinada para dispositivos m�viles los cuales tengan como sistema Operativo : IOS 9.0.0 o versi�n superior y Android 4,1,0 o versi�n superior. 
 - Se necesita conexi�n de red. 
 - Aproximadamente 400 Mb de capacidad la versi�n inicial tiene 200 Mb y luego poco a poco se actualizaran con las nuevas versiones. 



## Anexos 

 - Jhonatan Joestar, 40 a�os. Beta tester profesional, publica art�culos en varias revistas de videojuegos peri�dicamente. Nos reunimos con �l una vez a la semana en encuentros entre hora y media y dos horas.
 
 - Jotaro Kujo, 19 a�os. Estudiante de preparatoria, dedica gran parte de su tiempo libre a los videojuegos. Las reuniones fueron cada 15 d�as en encuentros menores a la hora.
 
 - Dio Brando, 29 a�os. Empleado de una f�brica de conservas, alto consumidor de videojuegos. Encuentros semanales que duran entre 1 o 2 horas.

    e les iban dando videos hechos por el equipo de trabajo para la explicaci�n de distintas funcionalidades, asi como PowerPoint para mostrar ciertos aspectos.

