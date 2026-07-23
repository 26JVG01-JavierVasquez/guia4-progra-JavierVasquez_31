Algoritmo Lecc35_Act3
	
    Definir jugador, computadora Como Entero
    Definir respuesta Como Caracter
	
    Repetir
		
        Escribir "===== PIEDRA, PAPEL O TIJERAS ====="
        Escribir "1. Piedra"
        Escribir "2. Papel"
        Escribir "3. Tijeras"
        Escribir "Seleccione una opción:"
        Leer jugador
		
        computadora <- Aleatorio(1,3)
		
        Escribir ""
		
        Segun jugador Hacer
            1:
                Escribir "Usted eligió: Piedra"
            2:
                Escribir "Usted eligió: Papel"
            3:
                Escribir "Usted eligió: Tijeras"
            De Otro Modo:
                Escribir "Opción inválida."
        FinSegun
		
        Segun computadora Hacer
            1:
                Escribir "La computadora eligió: Piedra"
            2:
                Escribir "La computadora eligió: Papel"
            3:
                Escribir "La computadora eligió: Tijeras"
        FinSegun
		
        Si jugador = computadora Entonces
            Escribir "Resultado: ¡Empate!"
        Sino
            Si (jugador = 1 Y computadora = 3) O (jugador = 2 Y computadora = 1) O (jugador = 3 Y computadora = 2) Entonces
                Escribir "Resultado: ¡Ganaste!"
            Sino
                Escribir "Resultado: La computadora gana."
            FinSi
        FinSi
		
        Escribir ""
        Escribir "¿Desea jugar nuevamente? (S/N)"
        Leer respuesta
		
    Hasta Que Mayusculas(respuesta) = "N"
	
FinAlgoritmo