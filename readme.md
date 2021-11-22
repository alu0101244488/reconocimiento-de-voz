## Práctica: Reconocimiento de voz
Nombre: Aram Pérez Dios  
Correo: alu0101244488@ull.edu.es  
Universidad: Universidad de La Laguna 
Asignatura: Interfaces Inteligentes
Grupo: PE102  

### Introducción

En esta práctia se requería implementar dos herramientas que nos proporciona Unity. La primera llamada **KewordRecognizer** y la segunda **DirectionRecognizer**. Esta primera nos permite reconocer palabras especificadas mientras que la segunda nos permite escuchar lo que nos dice la persona y transcribirlo.

### Keyword Recognizer
La primera pherramienta se ha implementado mediante la implementación de un pequeño juego. En este la persona tiene como palabras clave **Arriba**, **Abajo**, **izquierda** y **derecha**. Al nombrar alguna de estas palabras se lana al evento en el cual, dependiendo de la palabra nombrada, el jugador se moverá acorde. En caso de colisión, se lanzará un evento Ontrigger con el que se parará la ejecución del KeywordRecognizer. De la misma manera, existirá una UI con la función de comenzar o finalizar esta ación.


### Dictation Recognizer

El caso de Kyword Recognizer muestra en un elemento de UI la transcripción reconocida como la hipótotesis mendiante un evento. Además cuenta con otros tres eventos a implementar para el dictado reconocido y casos de error. Cuenta a su vez con elementos de interfaz de usuario para su inicialización y finalización.


### Otros elementos

Además de un script para KeywordRecognizer y DictationRecognizer, también se cuentan con scripts para detectar las colisiones y para a KeywordRecognizer y otro script en el que se almacenan todos los eventos onclick de la UI para inicializar ambas herramientas por separado y sus respectivos eventos para finalizarlos (cada uno con su stop() y su dispose()).


### Muestra de la ejecución del juego

E n el siguiente gif se puede observar una ejecución del entorno empleando todas las acciones que se pueden llevar a cabo: 

![](https://github.com/alu0101244488/reconocimiento-de-voz/blob/master/img/ejecuci%C3%B3n%20de%20unity.gif?raw=true)
