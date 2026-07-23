Algoritmo Lecc32_Act2
	
    Definir dia, mes Como Entero
    Definir signo, mensaje Como Cadena
	
    Escribir "Ingrese el día de nacimiento:"
    Leer dia
	
    Escribir "Ingrese el mes de nacimiento (1-12):"
    Leer mes
	
    Si (mes = 3 Y dia >= 21) O (mes = 4 Y dia <= 19) Entonces
        signo <- "Aries"
        mensaje <- "Hoy es un buen día para comenzar nuevos proyectos."
    Sino
        Si (mes = 4 Y dia >= 20) O (mes = 5 Y dia <= 20) Entonces
            signo <- "Tauro"
            mensaje <- "La paciencia será tu mejor aliada."
        Sino
            Si (mes = 5 Y dia >= 21) O (mes = 6 Y dia <= 20) Entonces
                signo <- "Geminis"
                mensaje <- "Tendrás buenas oportunidades si sabes aprovecharlas."
            Sino
                Si (mes = 6 Y dia >= 21) O (mes = 7 Y dia <= 22) Entonces
                    signo <- "Cancer"
                    mensaje <- "Confía en tus capacidades."
                Sino
                    Si (mes = 7 Y dia >= 23) O (mes = 8 Y dia <= 22) Entonces
                        signo <- "Leo"
                        mensaje <- "Hoy destacarás entre los demás."
                    Sino
                        Si (mes = 8 Y dia >= 23) O (mes = 9 Y dia <= 22) Entonces
                            signo <- "Virgo"
                            mensaje <- "La organización será la clave del éxito."
                        Sino
                            Si (mes = 9 Y dia >= 23) O (mes = 10 Y dia <= 22) Entonces
                                signo <- "Libra"
                                mensaje <- "Busca el equilibrio en tus decisiones."
                            Sino
                                Si (mes = 10 Y dia >= 23) O (mes = 11 Y dia <= 21) Entonces
                                    signo <- "Escorpio"
                                    mensaje <- "Es un buen momento para superar retos."
                                Sino
                                    Si (mes = 11 Y dia >= 22) O (mes = 12 Y dia <= 21) Entonces
                                        signo <- "Sagitario"
                                        mensaje <- "Las aventuras traerán aprendizajes."
                                    Sino
                                        Si (mes = 12 Y dia >= 22) O (mes = 1 Y dia <= 19) Entonces
                                            signo <- "Capricornio"
                                            mensaje <- "El esfuerzo dará buenos resultados."
                                        Sino
                                            Si (mes = 1 Y dia >= 20) O (mes = 2 Y dia <= 18) Entonces
                                                signo <- "Acuario"
                                                mensaje <- "Tu creatividad será tu fortaleza."
                                            Sino
                                                signo <- "Piscis"
                                                mensaje <- "Escucha tu intuición."
                                            FinSi
                                        FinSi
                                    FinSi
                                FinSi
                            FinSi
                        FinSi
                    FinSi
                FinSi
            FinSi
        FinSi
    FinSi
	
    Escribir "Su signo es: ", signo
    Escribir mensaje

FinAlgoritmo