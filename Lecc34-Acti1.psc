Algoritmo Lecc34_Act1
	
    Definir numero, residuo Como Entero
    Definir binario Como Cadena
	
    Escribir "Ingrese un número decimal:"
    Leer numero
	
    binario <- ""
	
    Si numero = 0 Entonces
        binario <- "0"
    Sino
        Mientras numero > 0 Hacer
            residuo <- numero MOD 2
            binario <- ConvertirATexto(residuo) + binario
            numero <- Trunc(numero / 2)
        FinMientras
    FinSi
	
    Escribir "El número en binario es: ", binario
	
FinAlgoritmo