# sistema_agentes
Un sistema de información cuenta con tres agentes (A, B y C) cada agente cumple con dos funcionalidades:

# Funcionalidad 1: Obtener media
-	Definir la función getMedia(Lista de números reales)  valor de retorno: número real
-	Agente A: Obtener la media aritmética o promedio
-	Agente B: Obtener media armónica  
![image](https://user-images.githubusercontent.com/8541422/226695890-14490a12-c956-462d-bb8d-4f91bee02fca.png)
-	Agente C: Obtener mediana
Si la cantidad de datos es impar, la mediana es el valor que queda en la mitad al ordenar los datos de menor a mayor.
Si la cantidad de datos es par, la mediana es el promedio de los dos valores que quedan al centro al ordenar los datos de menor a mayor.


# Funcionalidad 2: Escalera
-	Definir función getStaircase(número entero)  valor de retorno: cadena de texto
-	Agente A: 
La base y altura son ambas iguales a n. Se dibuja usando el símbolo # símbolos y espacios. La última línea no va precedida de ningún espacio. Escriba un programa que imprima una escalera de tamaño n. Formato de entrada: Un único entero, n, que denota el tamaño de la escalera.
Restricciones:  0 < n < 100.  La escalera debe estar alineada a la derecha.

Ejemplo:

![image](https://user-images.githubusercontent.com/8541422/226696356-592d9b07-8cd5-4c89-90bf-c6211b0f3540.png)

(Escalera de tamaño n = 4)

-	Agente B:
La cima y altura son ambas iguales a n. Se dibuja usando el símbolo # símbolos y espacios. La primera línea no va precedida de ningún espacio. Escriba un programa que imprima una escalera de tamaño n. Formato de entrada: Un único entero, n, que denota el tamaño de la escalera.
Restricciones:  0 < n < 100.  La escalera debe estar alineada a la derecha.

Ejemplo:

![image](https://user-images.githubusercontent.com/8541422/226695968-9136abac-9f42-4521-af9f-2d9c6bd71e8e.png)

(Escalera de tamaño n = 4)

-	Agente C:
La base y cima son ambas iguales a n. Entre los extremos superior e inferior debe haber una distancia igual a n con el centro. Se dibuja usando el símbolo # símbolos y espacios. La línea central no va precedida de ningún espacio. Escriba un programa que imprima una escalera de tamaño n. Formato de entrada: Un único entero, n, que denota el tamaño de la primera y última línea de la escalera.
Restricciones:  0 < n < 100.  La escalera debe estar alineada al centro.

Ejemplo

![image](https://user-images.githubusercontent.com/8541422/226696036-cae5a565-bf58-44e5-bb62-9ee37a51a357.png)

(Escalera de tamaño n = 4)

# Criterios de evaluación:
-	Aplicar patrones de diseño que habilite la selección dinámica de los agentes.
-	Implementar Test unitarios
-	Aplicar principios de Clean architecture
-	Aplicar principios y buenas prácticas de desarrollo
-	Implementar en tecnología .NET C#
