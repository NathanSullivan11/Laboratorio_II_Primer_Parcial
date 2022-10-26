# Laboratorio_II_Primer_Parcial RECUPERATORIO

## Costa Cruceros

### Presentación 

Hola! Este el proyecto que realice para el recuperatorio del primer parcial de Laboratorio II, el cual fue bastante más desafiante que la primera instancia, porque me exigí mas. Pero al fin y al cabo termino siendo divertido y pude aprender mucho más.

### Resumen

La aplicación consiste en un sistema de administración de cruceros, el cual es gestionado y administrado por el usuario (un vendedor de la empresa). El vendedor puede acceder a diferentes funcionalidades, tales como; vender pasajes; visualizar información detallada, ya sea de los mismos viajes, como de sus pasajeros y respectivos cruceros, y también puede acceder a la información histórica almacenada en la base de datos. 

## Manual de uso

### 'Inicio de sesión' 

Contamos con un botón de 'Autocompletado' que nos trae a un usuario aleatorio de los 4 hardcodeados, luego un botón 'Salir' que nos va pedir que confirmemos si queremso cerrar la aplicación. Y por último el botón 'Ingresar', para empezar la aplicación.

![login](https://user-images.githubusercontent.com/97369033/198014604-47ba4ee1-387d-472f-ad43-e0d7fd5464fc.png)

### 'Menú principal' 

Al loguear tenemos este formulario, el cual tiene un barra lateral con todos los botones para acceder a otros formularios, una barra superior con el botón de 'Ayuda', 'Minimizar', etc. Y en la parte inferior izquierda información del usuaio logueado 
, con el botón 'Mi cuenta' que nos permite modificar el perfil, y un botón de apagado, para cerrrar la sesión. <br/>

![menu](https://user-images.githubusercontent.com/97369033/198015354-bd3022c1-cfdb-4e36-88ea-855cfcc1d960.png)

Si seleccionamos la primer opción de la barra lateral, se nos abrirá dentro del panel central el formulario de 'Viajes'<br/>

El cual tiene 4 funcionalidades: 'Listar pasajeros' - 'Venta de pasaje' - 'Agregar viaje' - 'Bajar viaje'

### 'Viajes'

![viajes](https://user-images.githubusercontent.com/97369033/198015781-4349ee46-bc22-4b34-9371-7352e3718417.png)

#### 'Listar pasajeros'

Podremos visualizar la lista completa de pasajeros con la información detallada de cada, pudiendo filtrar por nombre, apellido, pasaporte y edad. Y tambien por servicio (premium o turista). Podremos combinar ambos filtros para una búsqueda mas específica.
Y también cuenta con un botón 'Info crucero' el cual nos muestra la información básica del crucero.

![listado pasajeros](https://user-images.githubusercontent.com/97369033/198016245-8e063b4c-5dc8-4eeb-a642-c119473d2078.png)

#### 'Vender pasaje' 

Podremos vender hasta 4 pasajes en una misma venta
<br/> Primero se debe seleccionar el cliente, puede ser uno existente o uno nuevo. Si se intenta crear uno nuevo que ya existe en la base de datos, no deja,
y trae la info del que esta cargado. Al seleccionar uno válido ya sea de la base de datos o uno nuevo, se nos habilitara el ingreso del pasaporte.
<br/>
EL número de pasaporte respeta un formato (yo se que en cada nacionalidad es diferente pero era para poner una validación) 'AAA1234' (primero 3 letras, y le tienen que seguir mínimo 4 números)
Luego, le asignamos que tipo de servicio y dependiendo si es premium o no podra ir con 2 valijas o 1. Despues, el pasaporte y ya cuando tenemos cargado estos 3 objetos podremos crear al objeto pasajero que va a comprar el pasaje.
<br/> Se va a verificar que no se haya seleccionado un mismo pasaporte que pertenezca a algún pasajero de ese mismo viaje, y tambíen se verificará que no se ingresen 2 integrantes del mismo grupo familiar con el mismo pasaporte o dni.
<br/> Al cargar el pasaporte, podremos seleccionar el equipaje si seleccionamos 'Turista' el máximo de kg será de 25 y 'Premium' el máximo para ingresar se cambia a '50'
<br/> Una vez que tengamos 'Cliente', 'Pasaporte' y 'Equipaje' cargados, podremos crear en memoria al pasajero, que se almacenerá temporalmente en una lista por sí se desea seguir sumando integrantes al grupo familiar
<br/> Se puede cargar hasta 4 pasajeros por (grupo familiar) y los integrantes deben tener el mismo servicio (todos premium o todos turistas). Es por eso que a la hora de cargar al primer pasajero se bloquea la opción de elegir servicio teniendo en cuenta cual fue elegido.
<br/> A medida que vayamos cargando va a aparecer el precio del pasaje, neto y bruto, y el total que se va acumulando por grupo familiar.
<br/> Si se desea 'Finalizar venta' Sse verificará si el crucero tiene espacio disponible, si todavía no zarpo. O si hay suficientes camarotes premium o turistas.
<br/> El formulario tambíen cuenta con un botón de 'Ayuda' para facilitar la venta. Y un botón de 'Info crucero'.

![venta](https://user-images.githubusercontent.com/97369033/198018081-4f50170f-6d8d-4a30-92b7-b6d0e862be19.png)


 
#### 'Agregar viaje'
Se podrá agregar un viaje, siempre y cuando el crucero este disponible (Respetando las fechas de salida y llegada). 
![alta](https://user-images.githubusercontent.com/97369033/198018208-1d1418c5-6b90-43da-a51e-e2c9b1975a6e.png)
#### 'Bajar viaje' (hereda de 'Agregar viaje')
Se podrá dar de baja un viaje simplemente seleccionadólo del data grid y luego clickeando 'Bajar viaje'
![baja](https://user-images.githubusercontent.com/97369033/198018213-98256ca6-ce6e-41b1-9c80-501191fe13d7.png)

### 'Clientes'

Visualizaremos la lista de todos los clientes que tuvo la empresa. 
<br/>Podremos ordenar por id, dni y cantidad de viaje. (ASCENDENTEMENTE O DESCENDENTEMENTE)

![clientes](https://user-images.githubusercontent.com/97369033/198018413-6ed6dfa2-ed86-44a3-99b8-d7f34c0a1096.png)

### 'Estadísticas'

El botón de estadísticas nos desplega un submenú con otros tres formularios.

#### 'Destinos' (Hereda de 'Clientes'

Podremos visualizar la lista de todos los destinos disponibles, con las ganancias recaudadas de cada uno y la cantidad de viajes que se viajo
<br/> Podremos ordenar ascendente o descendentemente

![destinos](https://user-images.githubusercontent.com/97369033/198018917-5190dcd3-514a-4d94-bc88-346631f265fd.png)

#### 'Cruceros'  

Podremos visualiza lista de todos los cruceros con información completa , y podremos calcular las horas de viajes realizadas por cada uno.

![cruceros](https://user-images.githubusercontent.com/97369033/198019794-90d93b17-c787-44c8-826b-9c966a8f3ae6.png)

#### 'Viajes totales'

Tendremos acceso a la informacion detallada de todos los viajes finalizados y activos. Pudiendo calcular las ganancias totales, y las ganancias clasificadas por servicio (REGIONAL O EXTRAREGIONAL)

![viajes totales](https://user-images.githubusercontent.com/97369033/198019960-57961c75-1c43-4e6d-b669-c34230fa542e.png)

### Aclaración

Todos los formularios son responsive

### Diagrama de clases

![Diagrama Recu PP labo2](https://user-images.githubusercontent.com/97369033/197950946-dc836356-12f6-4173-ba01-80e81fb2634b.png)

### Justificación técnica

###### Clases estáticas
Lo primero que podemos observar en la primer imagen del diagrama son las clases **estáticas** del programa, que son la de SISTEMA, BASE DE DATOS y VALIDADOR, y decidí implementarlas de manera estática debido a que tengo un solo sistema y una sola base de datos. Y no manejan ningun estado de instancia.

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
Entidad Persona es mi única __clase abstracta__  , de la cual heredan Cliente y Usuario. 
<br/>Yo pensé a las entidades Pasajero y Cliente de manera separada. Aunque esten relacionadas, una no hereda de la otra ni viceversa. <br/>
Para mi un Cliente, es una persona que alguna vez viajó con la empresa y quedo registrada en la base de datos. 
<br/>Y mi Pasajero, antes de ser un pasajero tiene que ser un Cliente, es decir, que el constructor de Pasajero recibe un Cliente. <br/>
Puede ser un cliente que ya compró (que existe en la base de datos) o un cliente nuevo, y si es nuevo debo crear en memoria primero al Cliente para asi poder crear a mi Pasajero.
Por eso mi Pasajero tiene un atributo del tipo Cliente, el cual tiene nombre, apellido, dni (que hereda de persona) y también tiene un ID y una cantidad de viajes.

##### Funcionalidad extra

Se podrá modificar la cuenta del usuario logueado. (Editando mail, usuario o contraseña)

##### Herencia de forms con Polimorfismo

FrmBajaViaje hereda de FrmAltaViaje
FrmEstadisticasDestino hereda de FrmCliente

En ambas herencias tendremos podemos encontrar tanto métodos virutales como métodos override (Polimorfismo)

##### Encapsulamiento

En todo momento se busca aplicar este principio, encapsulando de manera correcta todas las clases, con sus respectivos atributos, propiedes y métodos. 


# Eso es todo, gracias!
