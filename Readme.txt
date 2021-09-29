Este es un proyecto de log muy simple. 

Esta la aplicación de consola para visualizar las pruebas y un proyecto donde se define los tipos de log

He habilitado 2 tipos de logs
  * Consola
  * Fichero

Los logs implementan una interfaz para poder inyectarla en caso necesario y una clase abstracta.

La interfaz define los métodos que todos los tipos de logs deben implementar, cada uno con su propia funcionalidad.

La clase abstracta me sirve para tener un método común a todos los tipos de logs, además, si algún tipo de log necesita añadir funcionalidad
puede sobreescribir la clase para implementarla.

Comentarios:
  * La aplicación habéis comentado que tiene que ser simple. No hay validaciones ni tratamiento de errores
  * Podía haber creado una factoría para crear los diferentes tipos de logs, pero quería entregar esto rápido (no tengo mucho tiempo "libre"), además de que fuese algo simple _:)

