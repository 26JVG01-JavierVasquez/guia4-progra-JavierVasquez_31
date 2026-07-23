Algoritmo Lecc33_Act1
	
	Definir nombres Como Cadena
	Dimension nombres[10]
	
	Definir opcion, i, buscar Como Entero
	
	Repetir
		Escribir "======== AGENDA ========"
		Escribir "1. Agregar nombres"
		Escribir "2. Mostrar nombres"
		Escribir "3. Buscar nombre"
		Escribir "4. Salir"
		Leer opcion
		
		Segun opcion Hacer
			
			1:
				Para i <- 0 Hasta 9 Hacer
					Escribir "Ingrese el nombre ", i + 1, ":"
					Leer nombres[i]
				FinPara
				
			2:
				Escribir "Lista de nombres:"
				Para i <- 0 Hasta 9 Hacer
					Escribir i + 1, ". ", nombres[i]
				FinPara
				
			3:
				Escribir "Ingrese la posición del nombre (1-10):"
				Leer buscar
				
				Si buscar >= 1 Y buscar <= 10 Entonces
					Escribir "Nombre: ", nombres[buscar - 1]
				Sino
					Escribir "Posición incorrecta."
				FinSi
				
			4:
				Escribir "Fin del programa."
				
				De Otro Modo
				Escribir "Opción inválida."
				
		FinSegun
		
	Hasta Que opcion = 4
	
FinAlgoritmo