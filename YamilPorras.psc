
Proceso ControlPacientes
	
    Definir pacientes Como Cadena
    Definir urgencias Como Entero
    Definir cantidad, opcion, i, posicion Como Entero
	
    Dimension pacientes[20]
    Dimension urgencias[20]
	
    cantidad <- 0
	
    Repetir
		
        Escribir "=============================="
        Escribir "       MENU PRINCIPAL"
        Escribir "=============================="
        Escribir "1. Registrar paciente"
        Escribir "2. Mostrar pacientes"
        Escribir "3. Modificar urgencia"
        Escribir "4. Eliminar paciente"
        Escribir "5. Salir"
        Escribir "=============================="
        Escribir "Digite una opcion:"
        Leer opcion
		
        Segun opcion Hacer
			
            1:
                Si cantidad < 20 Entonces
					
                    Escribir "Nombre del paciente:"
                    Leer pacientes[cantidad]
					
                    Escribir "Nivel de urgencia (1-5):"
                    Leer urgencias[cantidad]
					
                    Mientras urgencias[cantidad] < 1 O urgencias[cantidad] > 5 Hacer
                        Escribir "Error. El nivel debe estar entre 1 y 5."
                        Escribir "Digite nuevamente el nivel:"
                        Leer urgencias[cantidad]
                    FinMientras
					
                    cantidad <- cantidad + 1
					
                    Escribir "Paciente registrado correctamente."
					
                Sino
					
                    Escribir "No hay espacio disponible."
					
                FinSi
				
            2:
                Escribir "=============================="
                Escribir "     LISTA DE PACIENTES"
                Escribir "=============================="
				
                Si cantidad = 0 Entonces
					
                    Escribir "No hay pacientes registrados."
					
                Sino
					
                    Para i <- 0 Hasta cantidad - 1 Hacer
						
                        Escribir i + 1, ". ", pacientes[i], " - Urgencia: ", urgencias[i]
						
                    FinPara
					
                FinSi
				
            3:
                Escribir "=============================="
                Escribir "    MODIFICAR URGENCIA"
                Escribir "=============================="
				
                Si cantidad = 0 Entonces
					
                    Escribir "No hay pacientes registrados."
					
                Sino
					
                    Para i <- 0 Hasta cantidad - 1 Hacer
						
                        Escribir i + 1, ". ", pacientes[i], " - Urgencia: ", urgencias[i]
						
                    FinPara
					
                    Escribir "Digite el numero del paciente:"
                    Leer posicion
					
                    Si posicion >= 1 Y posicion <= cantidad Entonces
						
                        Escribir "Digite el nuevo nivel de urgencia:"
                        Leer urgencias[posicion - 1]
						
                        Mientras urgencias[posicion - 1] < 1 O urgencias[posicion - 1] > 5 Hacer
							
                            Escribir "Error. El nivel debe estar entre 1 y 5."
                            Escribir "Digite nuevamente el nivel:"
                            Leer urgencias[posicion - 1]
							
                        FinMientras
						
                        Escribir "Urgencia modificada correctamente."
						
                    Sino
						
                        Escribir "Paciente no encontrado."
						
                    FinSi
					
                FinSi
				
            4:
                Escribir "=============================="
                Escribir "     ELIMINAR PACIENTE"
                Escribir "=============================="
				
                Si cantidad = 0 Entonces
					
                    Escribir "No hay pacientes registrados."
					
                Sino
					
                    Para i <- 0 Hasta cantidad - 1 Hacer
						
                        Escribir i + 1, ". ", pacientes[i], " - Urgencia: ", urgencias[i]
						
                    FinPara
					
                    Escribir "Digite el numero del paciente a eliminar:"
                    Leer posicion
					
                    Si posicion >= 1 Y posicion <= cantidad Entonces
						
                        Para i <- posicion - 1 Hasta cantidad - 2 Hacer
							
                            pacientes[i] <- pacientes[i + 1]
                            urgencias[i] <- urgencias[i + 1]
							
                        FinPara
						
                        pacientes[cantidad - 1] <- ""
                        urgencias[cantidad - 1] <- 0
						
                        cantidad <- cantidad - 1
						
                        Escribir "Paciente eliminado correctamente."
						
                    Sino
						
                        Escribir "Paciente no encontrado."
						
                    FinSi
					
                FinSi
				
            5:
                Escribir "Saliendo del programa..."
				
            De Otro Modo:
                Escribir "Opcion no valida."
				
        FinSegun
		
        Si opcion <> 5 Entonces
            Escribir ""
            Escribir "Presione una tecla para continuar..."
            Esperar Tecla
            Limpiar Pantalla
        FinSi
		
    Hasta Que opcion = 5
	
FinProceso

