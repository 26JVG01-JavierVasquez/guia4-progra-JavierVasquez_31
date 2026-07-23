Algoritmo Lecc32_Act3
	
    Definir lado1, lado2, lado3 Como Real
	
    Escribir "Ingrese el primer lado:"
    Leer lado1
	
    Escribir "Ingrese el segundo lado:"
    Leer lado2
	
    Escribir "Ingrese el tercer lado:"
    Leer lado3
	
    Si (lado1 = lado2) Y (lado2 = lado3) Entonces
        Escribir "El triángulo es EQUILÁTERO."
    Sino
        Si (lado1 = lado2) O (lado1 = lado3) O (lado2 = lado3) Entonces
            Escribir "El triángulo es ISÓSCELES."
        Sino
            Escribir "El triángulo es ESCALENO."
        FinSi
    FinSi
	
FinAlgoritmo