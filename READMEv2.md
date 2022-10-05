# Laboratorio_II_Primer_Parcial

## App Cruceritos 

### Presentación 

Hola! En este repositorio van a encontrar el proyecto que realice para el primer parcial de la materia Laboratorio II, el cual fue bastante desafiante pero al fin y al cabo termino siendo divertido y pude aprender un montón.

### Resumen

La aplicación consiste en un sistema de administración de cruceros, el cual es gestionado y administrado por el usuario (un vendedor de la empresa). El vendedor puede acceder a diferentes funcionalidades, tales como; vender pasajes; visualizar información detallada, ya sea de los mismos viajes, como de sus pasajeros y respectivos cruceros, ycceder a la información histórica almacenada en la base de datos. 


### Diagrama de clases

![Captura de pantalla (53)](https://user-images.githubusercontent.com/97369033/194107735-7dae1bbc-62a1-4484-ae6b-bb70fcacc897.png)

![Captura de pantalla (52)](https://user-images.githubusercontent.com/97369033/194107758-99bc761b-1c39-4736-9d01-3a1064acfb08.png)


### Justificación técnica

###### Clases estáticas
Lo primero que podemos observar en la primer imagen del diagrama son las clases **estáticas** del programa, que son la de SISTEMA y BASE DE DATOS, y decidí implementarlas de manera estática debido a que tengo un solo sistema y una sola base de datos. Y no manejan ningun estado de instancia.

Por otro lado, vemos las entidades Viaje y Crucero, que estan estrictamente relacionadas. Esta relacionadas de manera tal que, un crucero pueda estar asignado en diferentes viajes (siempre y cuando respeten fechas de salida y llegada), y un viaje pueda tener asignado únicamente un solo crucero. Es por eso que decidí que la entidad Viaje tenga un atributo del tipo Crucero, y no al reves.

###### Abstracción
Los cruceros a su vez, tienen sus atributos básicos, tales como; capacidad máxima de bodega, cantidad de camarotes, tipos de salones, etc. Pero estas caracteristicas son "constantes" a cada crucero, es decir que el valor de estos atributos no cambia. 
Y luego estan los atributos que si varían (por ej; el aumento de kilos en bodega a medida que suben pasajeros), pero estos no pertenecen a la entidad Crucero. Sino que se encuentran en la entidad Viaje, ya que es la encargada de llevar la cuenta de estos atributos que varían. 
Si no hubiera implementado esta **abstracción** de esta manera, (si cada crucero llevase la cuenta de cuanta capacidad le va quedando libre, etc) el problema estaria en que si tengo, por ejemplo, 3 viajes (con distintas fechas) que comparten un mismo crucero, todos tendrían la misma capacidad libre de camarotes, bodega, etc. Estos atributos tendrían el mismo valor en cada viaje. Por lo tanto, no podría tratar a estos viajes de manera independiente.

###### Sobrecarga de constructores - Indexador
La entidad Viaje tiene una  **sobrecarga de constructores** que se usa dependendiendo si el viaje a dar de alta es regional o extra regional. Se llamará al constructor adecuado en base a si el parámetro de destino es de tipo Enum Regional o si es de tipo Enum Extra Regional. ("Declaración y uso de al menos 2 enums)
<br/> Los viajes tambien poseen un **indexador**, que responde a la lista de pasajeros de ese viaje. Y lo utilice, por ejemplo, cuando tuve recorrer todos los viajes preguntando por cada pasajero (si premium o turista), para determinar cual era el total facturado de ese viaje.

###### Colecciones
Como dije recién cada viaje tiene una **coleccion generica de tipo lista**, y eso es así ya que esta lista va variando de manera dinámica a lo largo del programa. No hubiera sido correcto utilizar un array, por ejemplo.
<br/>También implemento el uso de otro tipo de coleccion, **diccionario**. Estos los uso para calcular algunas de las estadisticas, por ejemplo, habia que determinar cuantas veces se viajo a cada destino, y mi diccionario en ese caso tiene como llave un string (que representa el destino), y como valor, de esa llave, un entero (cantidad de veces que se viajo). 

###### Sobrecarga de operadores
Mi entidad Equipaje que le pertenece a cada pasajero, esta **sobrecargada de manera ímplicita** para que al momento de sumarle el respectivo peso a la bodega del crucero, se convierta implicitamente en un entero que representa los kg del mismo.

Tuve un confusión con respecto a la **sobrecarga del ==**. Porque yo habia entendido que si sobrecargamos el Equals ya no era necesario el ==, por lo tanto no tengo la sobrecarga del == en mi código, y comparo únicamente con la sobrecarga del Equals.
 
##### Clase abstracta 
Entidad Persona es mi única __clase abstracta__  , de la cual heredan Cliente y Usuario. Y la pregunta es 
<br/>¿Por qué no hereda Pasajero también? <br/>
Y la cuestión es que yo tomo a las entidades Pasajero y Cliente de manera separada. Aunque esten relacionadas, una no hereda de la otra ni viceversa. <br/>
Para mi un Cliente, es una persona que alguna vez viajó con esta compañia y quedo registrada en la base de datos. <br/>
Y mi Pasajero, antes de ser un pasajero tiene que ser un Cliente, es decir, que el constructor de Pasajero recibe un Cliente. Puede ser un cliente que ya compró (que existe en la base de datos) o un cliente nuevo, y si es nuevo debo crear en memoria primero al Cliente para asi poder crear a mi Pasajero.
Por eso mi Pasajero tiene un atributo del tipo Cliente, el cual tiene nombre, apellido, dni (que hereda de persona) y también tiene un ID y una cantidad de viajes.

##### Funcionalidad extra

Ok, ¿Y porqué Usuario hereda de Persona si lo único que me interesa es el nombre de usuario, mail y contraseña?
Bueno, esto lo arme así debido a que mi **funcionalidad extra**, es poder modificar la cuenta del usuario logueado. (Editando mail, usuario o contraseña)
Y el nombre, dni y esos datos, me sirven para identificar a cada usuario-vendedor. 

##### Herencia de forms - Polimorfismo

Una CONTRA de mi programa es que pude haber implementado más herencia de FORMS, porque al principio no sabía bien como funcionaban, Ya que me hice lío intentando hacer herencia y mdi al mismo tiempo.
Sin embargo pude aplicar estos cnceptos, MDI Y HERENCIA.

La herencia de forms esta en los formularios de "Alta de viaje" y "Baja de viaje", el cual implementa polimorfismo, ya que ambos responden al mismo botón con una diferente funcionalidad

Y los MDI de el historial, son todos listados independientes y muy parecido entre sí, por eso si me hubiera gustado poderhacer herencia en esos formularios tambíen.

##### Encapsulamiento

Siempre busqué encapsular de manera correcta todas las clases, pero estoy seguro de que se me pasaron por alto algunos modificadores de acceso. Tengo varios metodos, propiedades públic porque son invocados en casi todos mis forms.

# Manual de uso

### Inicio de sesión (Es responsive)

No hay mucho que comentar de este 1er form, simplemente tiene un botón que rellena los campos escogiendo un usuario aleatorio de los 4 usuarios hardcodeados.

![Captura de pantalla (40)](https://user-images.githubusercontent.com/97369033/194109449-ac2ad37f-4133-42ef-a21d-57ec758b1a19.png)

### Menu principal (Es responsive)

Al loguear tenemos el formulario contenedor principal, que tiene 2 opcion dentro del menu strip. La primera es viajes activos, que es la que se abre a penas se inica sesión. <br/> 
La cual tiene 4 funcionalidades: Inspeccion de viaje - Venta de pasaje - Alta viaje - Baja viaje

![Captura de pantalla (41)](https://user-images.githubusercontent.com/97369033/194109813-27a83fbb-def6-44ec-8c59-ed0515673538.png)

### Menu principal (opcion 1) VIAJES ACTIVOS

#### a) Inspeccionar viaje (No es responsive)

Podremos visualizar la lista completa de pasajeros con toda su info detallada, y podremos filtrar por nombre, apellido, pasaport y edad. Y tambien si son premium o no.
Y muestra la info básica del crucero.

![Captura de pantalla (42)](https://user-images.githubusercontent.com/97369033/194109976-cf0ebca1-3c2f-4fa2-a1d8-883bb8ead912.png)

#### b) Vender pasaje (Es responsive)

Esta funcionalidad se me hizo bastante dificil, ya que tiene muchas cosas a tener en cuenta. 
<br/> Primero se debe seleccionar el cliente, puede ser uno existente o uno nuevo. (Si se intenta crear uno nuevo que ya existe en la base de datos, no deja, y trae la info del que esta cargado) <br/>
Luego, le asignamos que tipo de servicio y dependiendo si es premium o no podra ir con 2 valijas o 1. Despues, el pasaporte y ya cuando tenemos cargado estos 3 objetos podremos crear al objeto pasajero que va a comprar el pasaje.
<br/> Se puede cargar hasta 4 pasajeros por venta (grupo familiar) y los integrantes del grupo pueden ser únicamente o todos premium o todos turista. La opcion se bloque al momento que cargamos el primer pasajero.
<br/> Se venderá el pasaje si el crucero no esta lleno, o no zarpo todavia.

![Captura de pantalla (43)](https://user-images.githubusercontent.com/97369033/194111166-7d3f9fb1-780b-4d0e-8fe3-87b988860148.png)

 #### c) d) Alta y baja de viaje
 
 Se podra agregar un viaje, siempre y cuando se respeten las fechas de salida y llegada. Y la baja de viaje es muy simple, nada que explicar.
 
#### Alta
![Captura de pantalla (44)](https://user-images.githubusercontent.com/97369033/194111593-8de41b03-9d0a-4983-b4b0-88e2f43eccde.png)
#### Baja
![Captura de pantalla (45)](https://user-images.githubusercontent.com/97369033/194111610-f7af773a-56d3-4bd4-bc6e-7c5894af56f4.png)


### Menu principal (opcion 2) HISTORIAL

El historial cuetna con 4 formularios, todos son listados. 

#### a) Clientes (Es responsive)

Podremos ordenar por id, dni y cantidad de viaje. (ASCENDENTEMENTE O DESCENDENTEMENTE)

![Captura de pantalla (48)](https://user-images.githubusercontent.com/97369033/194111965-61c59652-7b68-4398-a75d-5d25171bd9ae.png)

#### b) Destinos (Es responsive)

Podremos calcular las ganancias totales por destino y la cantidad de viajes que se viajo a tal destino

![Captura de pantalla (47)](https://user-images.githubusercontent.com/97369033/194112247-1b3afe27-35f5-4b48-8f20-6453207ebe72.png)

#### c) Viajes (Es responsive)

Tendremos acceso a la informacion detallada de todos los viajes realizados y por realizar. Pudiendo calcular las ganancias totales, y las ganancias clasificadas por servicio (REGIONAL O EXTRAREGIONAL)

![Captura de pantalla (48)](https://user-images.githubusercontent.com/97369033/194112501-2d5a1f3d-754b-4c88-b44f-b9a719b0f3a3.png)

#### d) Cruceros  (Es responsive)

Muestra la informacion completa de todos los cruceros, y podremos calcular las horas de viajes realizadas por cada uno

![Captura de pantalla (49)](https://user-images.githubusercontent.com/97369033/194112670-7d0a9ea5-65fd-495e-a567-cc9e2f8a2166.png)


# Eso es todo, gracias!
