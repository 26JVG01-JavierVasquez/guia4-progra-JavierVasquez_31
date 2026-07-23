Algoritmo Lecc35_Act1
	
    Definir cantidad Como Real
    Definir opcion Como Caracter
	
    Repetir
		
        Escribir "Ingrese la cantidad en quetzales:"
        Leer cantidad
		
        Escribir "Equivalencias:"
        Escribir "Dólar (EE.UU.): ", cantidad * 7.75
        Escribir "Euro: ", cantidad * 8.50
        Escribir "Peso Mexicano: ", cantidad * 2.30
        Escribir "Lempira (Honduras): ", cantidad * 3.15
        Escribir "Colón Costarricense: ", cantidad * 68.00
		
        Escribir ""
        Escribir "¿Desea convertir otra cantidad? (S/N)"
        Leer opcion
		
    Hasta Que Mayusculas(opcion) = "N"
	
FinAlgoritmo