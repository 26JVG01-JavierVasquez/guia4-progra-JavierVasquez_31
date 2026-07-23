Algoritmo Lecc34_Act2
	
    Definir peso, estatura, imc Como Real
	
    Escribir "Ingrese su peso en kilogramos:"
    Leer peso
	
    Escribir "Ingrese su estatura en metros:"
    Leer estatura
	
    imc <- peso / (estatura * estatura)
	
    Escribir "Su IMC es: ", imc
	
    Si imc < 18.5 Entonces
        Escribir "Clasificación: Bajo peso"
    Sino
        Si imc < 25 Entonces
            Escribir "Clasificación: Peso normal"
        Sino
            Si imc < 30 Entonces
                Escribir "Clasificación: Sobrepeso"
            Sino
                Escribir "Clasificación: Obesidad"
            FinSi
        FinSi
    FinSi
	
FinAlgoritmo