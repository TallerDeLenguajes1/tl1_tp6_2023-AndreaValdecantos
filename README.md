- El tipo String es un tipo por referencia.
- Secuencias de escape: \n (salto de línea), \a (alerta), \b (retroceso), \f (avance de página), \r (retorno de carro), \t (salto de tabulación horizontal), \v (salto de tabulación vertical), \' (muestra una comilla simple), \" (muestra una comilla doble), \\ (muestra una barra invertida), \O (caracter nulo)
- El carácter especial @ actúa como un identificador textual. Se usa de estas formas:
  * Para indicar que un literal de cadena se debe interpretar literalmente. El carácter @ de esta instancia define un literal de cadena textual. Las secuencias de escape sencillas (como "\\", que es una barra diagonal inversa), las secuencias de escape hexadecimales (como "\x0041", que es una A mayúscula) y las secuencias de escape Unicode (como "\u0041" que es una A mayúscula) se interpretan literalmente.
  * Para usar palabras clave de C# como identificadores. El carácter @ actúa como prefijo de un elemento de código que el compilador debe interpretar como un identificador en lugar de como una palabra clave de C#.
  * Para permitir que el compilador distinga entre los atributos en caso de conflicto de nomenclatura.
