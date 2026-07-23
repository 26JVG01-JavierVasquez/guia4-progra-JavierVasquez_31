Algoritmo Lecc32_Act1
	
	Definir metros, resultado Como Real
	Definir opcion Como Entero
	
	Escribir "CONVERSIÓN DE METROS"
	Escribir "Ingrese la cantidad de metros:"
	Leer metros
	
	Escribir "Seleccione una opción:"
	Escribir "1. Milímetros"
	Escribir "2. Centímetros"
	Escribir "3. Decímetros"
	Escribir "4. Hectómetros"
	Escribir "5. Kilómetros"
	Leer opcion
	
	Segun opcion Hacer
		1:
			resultado <- metros * 1000
			Escribir metros, " metros = ", resultado, " milímetros"
		2:
			resultado <- metros * 100
			Escribir metros, " metros = ", resultado, " centímetros"
		3:
			resultado <- metros * 10
			Escribir metros, " metros = ", resultado, " decímetros"
		4:
			resultado <- metros / 100
			Escribir metros, " metros = ", resultado, " hectómetros"
		5:
			resultado <- metros / 1000
			Escribir metros, " metros = ", resultado, " kilómetros"
		De Otro Modo:
			Escribir "Opción incorrecta."
	FinSegun

FinAlgoritmo