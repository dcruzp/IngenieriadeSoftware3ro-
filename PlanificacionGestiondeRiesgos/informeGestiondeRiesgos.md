# Informe Planificaci�n de Gesti�n de Riesgos

## 1 Metodolog�a a aplicar para el desarrollo del Proyecto 
 
Para el desarrollo de este software consideramos usar Crystal Clear como metodolog�a 

La raz�n por la que escogimos Crystal Clear es por la facilidad que nos brinda para administrar este 
tipo de entorno y de problema dado que es una metodolog�a �gil. Adem�s que somos un equipo 
de 4 integrante, y esta metodolog�a est� orientada a equipos de 3 a 8 integrantes, es decir 
equipos peque�os.

Esta metodolog�a tiene una caracter�stica que favorece mucho y son las entregas frecuentes, 
que se basa en las entregas del software a los usuarios para permitir que los cliente 
pueda interactuar con este para identificar los problemas que puedan surgir. 
Adem�s que puede servir como una referencia para posibles problemas que ocurran. 

Como somos un equipo peque�o la  *Seguridad Personal* donde cada miembro del equipo tiene permitido hablar cuando 
hay algo que consideren que est� mal acerca del proyecto, sin tener miedos ni 
represalias(todo esto lo favorece el hecho de que el equipo es solo de 4 personas y somos muy buenos compa�eros de equipo).

Ademas que se puede definir las partes sobre las cuales cada desarrollador debe 
concentrar su trabajo, e interactuar con las dem�s partes de desarrollo que tiene el software.

#### Planificaci�n 

La planificaci�n tendr�a lugar al principio del desarrollo del software, aunque despu�s 
tendr�a una revision y modificaci�n en el calendario del desarrollo y revisiones 
provocadas por imprevistos que puedan surgir a lo largo de la producci�n del software.

#### Ventajas y desventajas para la gesti�n de riesgos 

Como ventajas tendr�amos la prevenci�n de futuras inconformidades del cliente. 
Pero sobretodo la planificaci�n bien detallada de un resultado podr�a traer 
buena aceptaci�n por parte del cliente y sobre todo favorecer al desarrollo al tomarse en cuenta 
aspectos que mejorar�a el rendimiento ya sea para futuras versiones del software o para aspectos espec�ficos del desarrollo 
que puedan traer resultado positivos a largo plazo. 

Podr�a decirse que la productividad del equipo se ver�a beneficiada y el tiempo de desarrollo se podr�a acortar si 
se toman decisiones bien fundamentada en el desarrollo. 

Podr�amos decir que tomar una decision que no haya sido consultada y depurada lo suficiente podr�a traer impacto para el producto 

Como desventajas el producto final pudiera ver afectada su replicabilidad y futuras correcciones en el software. 
Entonces futuros cambios debido a correcci�n de errores o simplemente requerimientos del usuario pudieran ser imposibles o requerir un cambio completo en el dise�o del software 

Pues si en alg�n punto se decide tomar una decision que no este bien materializada(por falta de tiempo en la gesti�n o por simplemente considerarse beneficiosa por parte de los desarrolladores).
## 2 Planificaci�n para la ejecuci�n del Proyecto 

El diagrama describe la planificaci�n para la ejecuci�n del proyecto mediante un diagrama de Gantt

![imagen](../DiagramadeGantt/DiagramadeGantt.png)

El diagrama esta hecho en Project Pro . En la carpeta *DiagramadeGantt* hay un fichero con nombre *DiagramadeGant.mpp* , en este fichero esta el source  del Diagrama hecho en  Project Pro 


Descripci�n y asignaci�n de las actividades 

![imagen_5](img/TareaseHitos.png)

Mejoras reflexivas 
![imagen_1](img/1.png)

Gesti�n de las ofertas de pizzeria (Base de Datos)
![imagen_2](img/2.png)

Actualizar ofertas diarias
![imagen_3](img/3.png)

Actualizar cantidad y producto 
![imagen_4](img/4.png)

Gesti�n de usuarios del sistema
![imagen_5](img/5.png)

Actualizar los usuarios del sistema 
![imagen_6](img/6.png)

Parte Visual (Parcial del software) 
![imagen_7](img/7.png)

Entrega al usuario 
![imagen_8](img/8.png)

Gesti�n de Pedidos 
![imagen_9](img/9.png)

Creaci�n de Pedidos 
![imagen_10](img/10.png)

Parte Visual (Parcial del software) II 
![imagen_11](img/11.png)

Entrega al Usuario II 
![imagen_12](img/12.png)

Funcionamiento de los Mensajeros 
![imagen_13](img/13.png)

Entrega Final al usuario
![imagen_14](img/14.png)



## 3 Riesgos que est�n asociados 

##### 1- Suplantaci�n de identidad por parte de un tercero que empiece a realizar pedidos falsos.
Esto se clasifica como una amenaza ya que un usuario troll puede afectar las ganancias de la pizzer�a al empezar a hacer estos pedidos. Este problema no es posible de resolver en su totalidad, ya que es imposible asegurar que alguien se robe las contrase�as de otra persona, pero podemos mitigarlo siguiendo 2 estrategias: 
1. Implementando m�s sistemas de seguridad como la encriptaci�n de los paquetes de datos de los usuarios que solo tenga la llave el usuario una vez se cree su cuenta, entre otras t�cnicas de seguridad.
2. Cuando un usuario se cree una cuenta, se har� hincapi� en que es importante que no le d� su contrase�a a nadie, se podr�a gestionar un sistema de recompensa a los usuarios despu�s de cierto tiempo y en caso de perder estos la cuenta o que le roben las contrase�as perder�an beneficios.


##### 2- Ataque de negaci�n de servicios. 
Esto provocar�a que la el sitio se volviera extremadamente lento o incluso temporalmente inaccesible al estar recibiendo pedidos los cuales tienen solo el objetivo de ocupar la capacidad total de procesamiento de nuestros servidores e imposibilitar el acceso a este por parte de otros usuarios. La opci�n que tomar�a nuestro equipo seria transferir la soluci�n del problema a un tercero que este especializado en seguridad.

1. Este realizara un Sistema de reconocimiento de mensajes de usuarios reales ignorando a los lanzados por maquinas en forma de spam, con alg�n m�todo de Snapchat o algo similar 

##### 3- Problemas con los pedidos (que no se correspondan los que hay en la base de datos y los que realmente hay en oferta  .

Esto pudiera suceder por mala gesti�n de los usuarios a la hora de interactuar con la plataforma. por desconocimiento 
del funcionamiento de la aplicaci�n. Los programadores quedan ajeno a eso , pues sucede que ellos solo se encargan de que la plataforma funcione. Los 
administradores serian los responsables del buen manejo y aplicaci�n de esta

 1 . Esto podr�a ser resuelto asignando a un encargado y responsable de la administraci�n de la aplicaci�n como administrador. 

##### 4- Problemas a la hora de el pago de los cliente 

Pudiera suceder que los clientes tuvieran alg�n contratiempo a la hora del pago de las entregas que se le hacen , esto har�a que si un usuario no hace el pago en el plazo establecido o por los medios que 
se estableci� ocurran algunos desajusten en el correcto funcionamiento de la plataforma en general. 

1. Esto pudiera solucionarse obligando a los usuarios a hacer los pagos de la forma establecida (usando solo tarjetas) y no de otra forma. 
2. Pero esto podr�a suponer que no se llegue a la mayor cantidad de usuarios posibles (que es lo que se quiere). 

##### 5- Problemas con los suministradores de las materias primas 

Esto suceder�a si un suministrador no cumpliera con su entrega a  tiempo o no pudiera suministrara toda la materia prima que tendr�a que entregar en una fecha determinada. Esto podr�a traer consigo que los pedidos programados no se entregaran a tiempo, pues si los administradores de la aplicaci�n no actualizan constantemente la base de datos 
podr�an surgir este tipo de imprevistos. 

1. Esto se solucionar�a poniendo un responsable como administrador de los recursos y su actualizaci�n en la base de datos. 