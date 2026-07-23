Algoritmo Lecc34_Act3
	
    Definir celsius, resultado Como Real
    Definir opcion Como Entero
	
    Escribir "Ingrese la temperatura en grados Celsius:"
    Leer celsius
	
    Escribir "Seleccione una opción:"
    Escribir "1. Convertir a Fahrenheit"
    Escribir "2. Convertir a Kelvin"
    Leer opcion
	
    Segun opcion Hacer
        1:
            resultado <- (celsius * 9 / 5) + 32
            Escribir "Temperatura en Fahrenheit: ", resultado
        2:
            resultado <- celsius + 273.15
            Escribir "Temperatura en Kelvin: ", resultado
        De Otro Modo:
            Escribir "Opción inválida."
    FinSegun
	
FinAlgoritmo